/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3.Util;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ContentRangeParserTests
    {
        #region Parse Method Tests

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_ValidContentRange_ReturnsCorrectValues()
        {
            // Arrange
            var contentRange = "bytes 0-5242879/52428800";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(0, startByte);
            Assert.AreEqual(5242879, endByte);
            Assert.AreEqual(52428800, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_ContentRangeWithoutBytesPrefix_ReturnsCorrectValues()
        {
            // Arrange - After .Replace("bytes ", ""), format becomes just "0-1023/2048"
            var contentRange = "0-1023/2048";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(0, startByte);
            Assert.AreEqual(1023, endByte);
            Assert.AreEqual(2048, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_SingleByteRange_ReturnsCorrectValues()
        {
            // Arrange - Edge case: single byte
            var contentRange = "bytes 0-0/1";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(0, startByte);
            Assert.AreEqual(0, endByte);
            Assert.AreEqual(1, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_LastByteOfObject_ReturnsCorrectValues()
        {
            // Arrange - Edge case: last byte
            var contentRange = "bytes 999-999/1000";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(999, startByte);
            Assert.AreEqual(999, endByte);
            Assert.AreEqual(1000, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_MiddleRange_ReturnsCorrectValues()
        {
            // Arrange
            var contentRange = "bytes 8388608-16777215/33554432";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(8388608, startByte);
            Assert.AreEqual(16777215, endByte);
            Assert.AreEqual(33554432, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_LargeFileRange_ReturnsCorrectValues()
        {
            // Arrange - Test with large values (multi-GB file)
            var contentRange = "bytes 5368709120-10737418239/53687091200"; // 50GB file

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(5368709120L, startByte);
            Assert.AreEqual(10737418239L, endByte);
            Assert.AreEqual(53687091200L, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_NullContentRange_ThrowsException()
        {
            // Act & Assert
            ContentRangeParser.Parse(null);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_EmptyContentRange_ThrowsException()
        {
            // Act & Assert
            ContentRangeParser.Parse(string.Empty);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_MissingSlash_ThrowsException()
        {
            // Arrange - Invalid format: missing slash separator
            var contentRange = "bytes 0-1023";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_MissingDash_ThrowsException()
        {
            // Arrange - Invalid format: missing dash in range
            var contentRange = "bytes 0 1023/2048";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_InvalidStartByte_ThrowsException()
        {
            // Arrange - Invalid: non-numeric start byte
            var contentRange = "bytes abc-1023/2048";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_InvalidEndByte_ThrowsException()
        {
            // Arrange - Invalid: non-numeric end byte
            var contentRange = "bytes 0-xyz/2048";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_InvalidTotalSize_ThrowsException()
        {
            // Arrange - Invalid: non-numeric total size
            var contentRange = "bytes 0-1023/xyz";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_WildcardTotalSize_ThrowsException()
        {
            // Arrange - S3 should never return wildcard, but test handling
            var contentRange = "bytes 0-1023/*";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_TooManySlashes_ThrowsException()
        {
            // Arrange - Invalid format: extra slashes
            var contentRange = "bytes 0-1023/2048/extra";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Parse_TooManyDashes_ThrowsException()
        {
            // Arrange - Invalid format: extra dashes
            var contentRange = "bytes 0-512-1023/2048";

            // Act & Assert
            ContentRangeParser.Parse(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Parse_ExtraSpaces_ReturnsCorrectValues()
        {
            // Arrange - ContentRange with multiple spaces (should handle gracefully)
            var contentRange = "bytes  0-1023/2048";

            // Act
            var (startByte, endByte, totalSize) = ContentRangeParser.Parse(contentRange);

            // Assert
            Assert.AreEqual(0, startByte);
            Assert.AreEqual(1023, endByte);
            Assert.AreEqual(2048, totalSize);
        }

        #endregion

        #region GetStartByte Method Tests

        [TestMethod]
        [TestCategory("S3")]
        public void GetStartByte_ValidContentRange_ReturnsStartByte()
        {
            // Arrange
            var contentRange = "bytes 8388608-16777215/33554432";

            // Act
            var startByte = ContentRangeParser.GetStartByte(contentRange);

            // Assert
            Assert.AreEqual(8388608, startByte);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetStartByte_ZeroStart_ReturnsZero()
        {
            // Arrange
            var contentRange = "bytes 0-1023/2048";

            // Act
            var startByte = ContentRangeParser.GetStartByte(contentRange);

            // Assert
            Assert.AreEqual(0, startByte);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetStartByte_InvalidContentRange_ThrowsException()
        {
            // Arrange
            var contentRange = "invalid";

            // Act & Assert
            ContentRangeParser.GetStartByte(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetStartByte_NullContentRange_ThrowsException()
        {
            // Act & Assert
            ContentRangeParser.GetStartByte(null);
        }

        #endregion

        #region GetTotalSize Method Tests

        [TestMethod]
        [TestCategory("S3")]
        public void GetTotalSize_ValidContentRange_ReturnsTotalSize()
        {
            // Arrange
            var contentRange = "bytes 0-5242879/52428800";

            // Act
            var totalSize = ContentRangeParser.GetTotalSize(contentRange);

            // Assert
            Assert.AreEqual(52428800, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetTotalSize_SingleByte_ReturnsOne()
        {
            // Arrange
            var contentRange = "bytes 0-0/1";

            // Act
            var totalSize = ContentRangeParser.GetTotalSize(contentRange);

            // Assert
            Assert.AreEqual(1, totalSize);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetTotalSize_InvalidContentRange_ThrowsException()
        {
            // Arrange
            var contentRange = "invalid";

            // Act & Assert
            ContentRangeParser.GetTotalSize(contentRange);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetTotalSize_NullContentRange_ThrowsException()
        {
            // Act & Assert
            ContentRangeParser.GetTotalSize(null);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetTotalSize_LargeFile_ReturnsCorrectSize()
        {
            // Arrange - Test with very large file (>50GB)
            var contentRange = "bytes 0-8388607/53687091200";

            // Act
            var totalSize = ContentRangeParser.GetTotalSize(contentRange);

            // Assert
            Assert.AreEqual(53687091200L, totalSize);
        }

        #endregion
    }
}
