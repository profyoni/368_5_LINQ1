using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace LINQ1_Test
{
    [TestFixture]
    public class LinqLearningTests
    {
        private List<String> list1;
        [SetUp]
        public void Init()
        {
            list1 = new List<string>() { "Bob", "carol", "Abe", "darron", "evelyn" };
        }
        [Test]
        public void WordsWithALetterO()
        {
            var processed = list1;

            processed.Count.Should().Be(2);

        }
        [Test]
        public void WordsWithOneLetterB()
        {
            var processed = list1;

            processed.Single();

        }

        [Test]
        public void WordsStartingWithCapitalLetters()
        {
            var processed = list1;

            processed.ShouldBeEquivalentTo(new[] { "Abe", "Bob" });
        }

        [Test]
        public void WordWithhighestGematria() // 'A' or 'a' = 1....'Z' or 'Z' = 26
        {
            var processed = list1;

            processed.ShouldBeEquivalentTo(new[] { "evelyn" });
        }

        [Test]
        public void WordOrderByMostRepetitiveLetters() 
        {
            var processed = list1;
            
            processed.Take(2).ShouldBeEquivalentTo(new[] { "darron", "evelyn" });
        }
    }
}
