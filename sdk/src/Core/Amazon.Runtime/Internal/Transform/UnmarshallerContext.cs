/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Util.Internal;
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using ThirdParty.Ionic.Zlib;
using System.Text.Json;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Base class for the UnmarshallerContext objects that are used
    /// to unmarshall a web-service response.
    /// </summary>
    public abstract class UnmarshallerContext : IDisposable
    {
        private bool disposed = false;

        protected bool MaintainResponseBody { get; set; }
        protected bool IsException { get; set; }
        protected CrcCalculatorStream CrcStream { get; set; }
        protected int Crc32Result { get; set; }
        protected CoreChecksumAlgorithm ChecksumAlgorithm { get; set; }
        protected HashStream FlexibleChecksumStream { get; set; }
        protected string ExpectedFlexibleChecksumResult { get; set; }
        protected IWebResponseData WebResponseData { get; set; }

        protected CachingWrapperStream WrappingStream { get; set; }
        public bool IsEmptyResponse { get; protected set; }

        public string ResponseBody
        {
            get
            {
                var bytes = GetResponseBodyBytes();
                return System.Text.UTF8Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            }
        }

        public byte[] GetResponseBodyBytes()
        {
            if (IsException)
            {
                return this.WrappingStream.AllReadBytes.ToArray();
            }

            if (MaintainResponseBody)
            {
                return this.WrappingStream.LoggableReadBytes.ToArray();
            }
            else
            {
                return ArrayEx.Empty<byte>();
            }
        }

        public IWebResponseData ResponseData
        {
            get { return WebResponseData; }
        }

        internal void ValidateCRC32IfAvailable()
        {
            if (this.CrcStream != null)
            {
                if (this.CrcStream.Crc32 != this.Crc32Result)
                {
                    throw new IOException("CRC value returned with response does not match the computed CRC value for the returned response body.");
                }
            }
        }

        internal void ValidateFlexibleCheckumsIfAvailable(ResponseMetadata responseMetadata)
        {
            if (FlexibleChecksumStream == null)
            {
                return;
            }
            
            responseMetadata.ChecksumAlgorithm = ChecksumAlgorithm;
            responseMetadata.ChecksumValidationStatus = ChecksumValidationStatus.PENDING_RESPONSE_READ;

            if (FlexibleChecksumStream.CalculatedHash != null)
            {
                if (Convert.ToBase64String(FlexibleChecksumStream.CalculatedHash) != ExpectedFlexibleChecksumResult)
                {
                    responseMetadata.ChecksumValidationStatus = ChecksumValidationStatus.INVALID;
                    throw new AmazonClientException("Expected hash not equal to calculated hash");
                }
                else
                {
                    responseMetadata.ChecksumValidationStatus = ChecksumValidationStatus.SUCCESSFUL;
                }
            }
        }

        protected void SetupCRCStream(IWebResponseData responseData, Stream responseStream, long contentLength)
        {
            this.CrcStream = null;

            UInt32 parsed;
            if (responseData != null && UInt32.TryParse(responseData.GetHeaderValue("x-amz-crc32"), out parsed))
            {
                this.Crc32Result = unchecked((int) parsed);
                this.CrcStream = new CrcCalculatorStream(responseStream, contentLength);
            }
        }

        protected void SetupFlexibleChecksumStream(IWebResponseData responseData, Stream responseStream, long contentLength, IRequestContext requestContext)
        {
            var algorithm = ChecksumUtils.SelectChecksumForResponseValidation(requestContext?.OriginalRequest?.ChecksumResponseAlgorithms, responseData);

            if (algorithm == CoreChecksumAlgorithm.NONE)
            {
                return;
            }

            ChecksumAlgorithm = algorithm;
            ExpectedFlexibleChecksumResult = responseData.GetHeaderValue(ChecksumUtils.GetChecksumHeaderKey(algorithm));
            var checksum = Convert.FromBase64String(ExpectedFlexibleChecksumResult);

            switch (algorithm)
            {
                case CoreChecksumAlgorithm.CRC64NVME:
                    FlexibleChecksumStream = new HashStream<HashingWrapperCRC64NVME>(responseStream, checksum, contentLength);
                    break;
                case CoreChecksumAlgorithm.CRC32C:
                    FlexibleChecksumStream = new HashStream<HashingWrapperCRC32C>(responseStream, checksum, contentLength);
                    break;
                case CoreChecksumAlgorithm.CRC32:
                    FlexibleChecksumStream = new HashStream<HashingWrapperCRC32>(responseStream, checksum, contentLength);
                    break;
                case CoreChecksumAlgorithm.SHA256:
                    FlexibleChecksumStream = new HashStream<HashingWrapperSHA256>(responseStream, checksum, contentLength);
                    break;
                case CoreChecksumAlgorithm.SHA1:
                    FlexibleChecksumStream = new HashStream<HashingWrapperSHA1>(responseStream, checksum, contentLength);
                    break;
                default:
                    throw new AmazonClientException($"Unsupported checksum algorithm {algorithm}");
            }
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the XML
        ///     document </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <returns>
        ///     True if the expression matches the current position in the document, 
        ///     false otherwise.</returns>
        public bool TestExpression(string expression)
        {
            return TestExpression(expression, CurrentPath);
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the XML
        ///     document being parsed, and restricts the expression to matching at the
        ///     specified stack depth. </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <param name="startingStackDepth">
        ///     The depth in the stack representing where the expression must
        ///     start matching in order for this method to return true. </param>
        /// <returns>
        ///     True if the specified expression matches the current position in
        ///     the XML document, starting from the specified depth. </returns>
        public bool TestExpression(string expression, int startingStackDepth)
        {
            return TestExpression(expression, startingStackDepth, CurrentPath, CurrentDepth);
        }

        private static bool TestExpression(string expression, string currentPath)
        {
            if (expression.Equals("."))
                return true;

            return currentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);
        }

        private static bool TestExpression(string expression, int startingStackDepth, string currentPath, int currentDepth)
        {
            if (expression.Equals("."))
                return true;

            int index = -1;
            while ((index = expression.IndexOf("/", index + 1, StringComparison.Ordinal)) > -1)
            {
                // Don't consider attributes a new depth level
                if (expression[0] != '@')
                {
                    startingStackDepth++;
                }
            }
            return startingStackDepth == currentDepth
                   && currentPath.Length > expression.Length
                   && currentPath[currentPath.Length - expression.Length - 1] == '/'
                   && currentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);
        }

        #region Abstract members

        /// <summary>
        /// The current path that is being unmarshalled.
        /// </summary>
        public abstract string CurrentPath { get; }

        /// <summary>
        /// Returns the element depth of the parser's current position in the
        /// document being parsed.
        /// </summary>
        public abstract int CurrentDepth { get; }

        /// <summary>
        /// True if <c>NodeType</c> is <c>Element</c>.
        /// </summary>
        public abstract bool IsStartElement { get; }

        /// <summary>
        /// True if <c>NodeType</c> is <c>EndElement</c>.
        /// </summary>
        public abstract bool IsEndElement { get; }

        /// <summary>
        /// True if the context is at the start of the document.
        /// </summary>
        public abstract bool IsStartOfDocument { get; }

        #endregion

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.CrcStream != null)
                    {
                        CrcStream.Dispose();
                        CrcStream = null;
                    }
                    if (this.WrappingStream != null)
                    {
                        WrappingStream.Dispose();
                        WrappingStream = null;
                    }
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
