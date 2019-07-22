using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BXFinAssessment.Services;
using NUnit.Framework;

namespace BXFinAssessment.UnitTest
{
    [TestFixture]
    public class ProductServiceTest
    {
        private static IEnumerable<TestCaseData> ReverseTestData()
        {
            yield return new TestCaseData(new int[] {1,2,3,4,5}, new int[] {5,4,3,2,1});
            yield return new TestCaseData(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 });
            yield return new TestCaseData(new int[] { 2, 2, 3, 3, 4 }, new int[] { 4, 3, 3, 2, 2 });
            yield return new TestCaseData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 });
            yield return new TestCaseData(new int[] { 1 }, new int[] { 1 });
            yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 7, 6, 5, 4, 3, 2, 1 });
        }

        private static IEnumerable<TestCaseData> DeletePartTestData()
        {
            yield return new TestCaseData(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5 });
            yield return new TestCaseData(2, new int[] { 1, 2, 3 }, new int[] { 1, 3 });
            yield return new TestCaseData(1, new int[] { 2, 2, 3, 3, 4 }, new int[] { 2, 3, 3, 4 });
            yield return new TestCaseData(5, new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2 });
            yield return new TestCaseData(1, new int[] { 1 }, new int[] { });
            yield return new TestCaseData(4, new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 5, 6, 7 });
        }

        [Test, TestCaseSource(nameof(ReverseTestData))]
        public void Reverse_ExpectedResult(int[] input, int[] expectResult)
        {
            var productService = new ProductService();
            var result = productService.Reverse(input);

            Assert.IsTrue(IsSameResult(result, expectResult), "incorrect reverse array calculator");
        }

        [Test, TestCaseSource(nameof(DeletePartTestData))]
        public void DeletePart_ExpectedResult(int position, int[] input, int[] expectResult)
        {
            var productService = new ProductService();
            var result = productService.DeletePart(position, input);

            Assert.IsTrue(IsSameResult(result, expectResult), "incorrect reverse array calculator");
        }

        private bool IsSameResult(int[] result, int[] expectResult)
        {
            if (result == null || expectResult == null || result.Length != expectResult.Length)
            {
                return false;
            }

            bool isSameResult = true;

            for (var i = 0; i < result.Length; i++)
            {
                if (result[i] != expectResult[i])
                {
                    isSameResult = false;
                    break;
                }
            }

            return isSameResult;
        }
    }
}