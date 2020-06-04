
using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Ninja.UnitTest
{
    [TestFixture]
    class StackTests
    {
        private Stack<string> _stack;
        [SetUp]
        public void Setup()
        {
            _stack = new Stack<string>();
        }
        [Test]
        public void Push_PushNull_ThrowsArgumentNullException()
        {
           Assert.That(()=> _stack.Push(null),Throws.ArgumentNullException);
        }
        [Test]
        public void Push_PushValidObject_AddObjectToStack()
        {
            _stack.Push("a");
            Assert.That(_stack.Count,Is.EqualTo(1));
        }
        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }
        [Test]
        public void Pop_EmptyStack_InvalidOperationException()
        {
            Assert.That(()=> _stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_ValidStack_ObjectOnTopOfStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            var result = _stack.Pop();
            Assert.That(result,Is.EqualTo("c"));
        }
        [Test]
        public void Pop_ValidStack_ChangeCount()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            _stack.Pop();
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
        [Test]
        public void Peek_EmptyStack_InvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_ValidStack_DoesNotChangeCount()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            _stack.Peek();
            Assert.That(_stack.Count, Is.EqualTo(3));
        }
        [Test]
        public void Peek_ValidStack_ReturnsObjectOnTopOfStack()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");
            var result = _stack.Peek();
            Assert.That(result, Is.EqualTo("c"));
        }
    }
}
