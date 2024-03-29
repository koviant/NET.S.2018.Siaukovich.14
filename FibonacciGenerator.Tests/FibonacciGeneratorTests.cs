﻿namespace FibonacciGenerator.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    using NUnit.Framework;

    /// <summary>
    /// Class for testing fibonacci generator.
    /// </summary>
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        [Test]
        public void FibonacciGenerator_ValidInput_ValidResult1()
        {
            BigInteger[] expected =
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584,
                4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229,
                832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169,
                63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903,
                2971215073, 4807526976, 7778742049, 12586269025, 20365011074, 32951280099, 53316291173, 86267571272,
                139583862445, 225851433717, 365435296162, 591286729879, 956722026041, 1548008755920, 2504730781961, 4052739537881
            };

            IEnumerable<BigInteger> actual = FibonacciGenerator.GenerateSequence(expected.Length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void FibonacciGenerator_ValidInput_ValidResult2()
        {
            BigInteger[] expected =
            {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584,
                4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229,
                832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169,
                63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903
            };

            IEnumerable<BigInteger> actual = FibonacciGenerator.GenerateSequence(expected.Length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FibonacciGenerator_InvalidInput_ThrowsArgumentOutOfRangeExc(int amount)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FibonacciGenerator.GenerateSequence(amount));
        }
    }
}
