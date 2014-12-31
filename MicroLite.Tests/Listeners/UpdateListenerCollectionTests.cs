﻿namespace MicroLite.Tests.Listeners
{
    using MicroLite.Listeners;
    using Xunit;

    /// <summary>
    /// Unit Tests for the <see cref="UpdateListenerCollection"/> class.
    /// </summary>
    public class UpdateListenerCollectionTests
    {
        public class WhenCallingAdd
        {
            private readonly UpdateListenerCollection collection = new UpdateListenerCollection();
            private readonly TestListener listener1 = new TestListener();
            private readonly TestListener listener2 = new TestListener();

            public WhenCallingAdd()
            {
                this.collection.Add(this.listener1);
                this.collection.Add(this.listener2);
            }

            [Fact]
            public void TheListenersShouldBeAddedAtTheTopOfTheList()
            {
                // The second listener should be added at 0.
                Assert.Same(this.listener2, this.collection[0]);
                Assert.Same(this.listener1, this.collection[1]);
            }
        }

        public class WhenCallingTheConstructor
        {
            private readonly UpdateListenerCollection collection = new UpdateListenerCollection();

            [Fact]
            public void ThereShouldBeNoRegisteredListeners()
            {
                Assert.Equal(0, this.collection.Count);
            }
        }

        private class TestListener : IUpdateListener
        {
            public void AfterUpdate(object instance, int rowsAffected)
            {
            }

            public void BeforeUpdate(object instance)
            {
            }
        }
    }
}