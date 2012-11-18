using System.IO;
using NUnit.Framework;
using RestaurantEventThing.Core;

namespace RestaurantEventThing.Tests
{
    [TestFixture]
    public class EventManagerTests 
    {
        [Test]
        public void CanRegisterEvents()
        {
            var sw = new StringWriter();
            var testCase =new TestCase(sw);
            var eventData = new TestEvent {Name = "Hello"};
            
            EventManager.Register<TestEvent>(testCase.ProcessEvent);
            EventManager.Raise(eventData);
            Assert.AreEqual(sw.ToString(), eventData.Name);
        }

        [Test]
        public void MultipleSubscribersAreCalled()
        {
            var sw = new StringWriter();
            var testCase = new TestCase(sw);
            var testCase2 = new TestCase(sw);
            var eventData = new TestEvent { Name = "Hello" };

            EventManager.Register<TestEvent>(testCase.ProcessEvent);
            EventManager.Register<TestEvent>(testCase2.ProcessEvent);
            EventManager.Raise(eventData);
            Assert.AreEqual(sw.ToString(), eventData.Name + eventData.Name);
            
        }

        [Test]
        public void MultipleSubscribersAreCalled2()
        {
            var sw = new StringWriter();
            var testCase = new TestCase(sw);
            var testCase2 = new TestCase(sw);
            var eventData = new TestEvent { Name = "Hello" };

            EventManager.Register<TestEvent>(testCase.ProcessEvent);
            EventManager.Register<TestEvent>(testCase2.ProcessEvent);
            EventManager.Register<TestEvent>(testCase2.ProcessEventAgain);
            EventManager.Raise(eventData);
            Assert.AreEqual(sw.ToString(), eventData.Name + eventData.Name + "World");

        }

        private class TestEvent : IDomainEvent 
        {
            public string Name { get; set; }
        }

        private class TestCase
        {
            private readonly StringWriter _sw;

            public TestCase(StringWriter sw)
            {
                _sw = sw;
            }

            public void ProcessEventAgain(TestEvent evt)
            {
                _sw.Write("World");
            }

            public void ProcessEvent(TestEvent evt)
            {
                _sw.Write(evt.Name);                 
            }
        }
    }
}
