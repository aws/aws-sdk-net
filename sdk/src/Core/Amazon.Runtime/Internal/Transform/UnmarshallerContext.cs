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

        /// <summary>
        /// Reads the next token at depth greater than or equal to target depth.
        /// </summary>
        /// <param name="targetDepth">Tokens are read at depth greater than or equal to target depth.</param>
        /// <returns>True if a token was read and current depth is greater than or equal to target depth.</returns>
        public bool ReadAtDepth(int targetDepth)
        {
            return Read() && this.CurrentDepth >= targetDepth;
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
        /// Reads to the next node in the document, and updates the context accordingly.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read.
        /// </returns>
        public abstract bool Read();

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public abstract string ReadText();

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

    /// <summary>
    /// Wrap an <c>XmltextReader</c> for simulating an event stream.
    /// 
    /// Each <c>Read()</c> operation goes either to the next element or next attribute within
    /// the current element. <c>TestExpression()</c> is used to match the current event
    /// to an xpath expression. The general pattern looks like this:
    /// <code>
    /// UnmarshallerContext context = new UnmarshallerContext(...);
    /// while (context.Read())
    /// {
    ///     if (context.TestExpresion("path/to/element"))
    ///     {
    ///         myObject.stringMember = stringUnmarshaller.GetInstance().Unmarshall(context);
    ///         continue;
    ///     }
    ///     if (context.TestExpression("path/to/@attribute"))
    ///         myObject.MyComplexTypeMember = MyComplexTypeUnmarshaller.GetInstance().Unmarshall(context);
    /// }
    /// </code>
    /// </summary>
    public class XmlUnmarshallerContext : UnmarshallerContext
    {
        #region Private members

        private static HashSet<XmlNodeType> nodesToSkip = new HashSet<XmlNodeType>
        {
            XmlNodeType.None,
            XmlNodeType.XmlDeclaration,
            XmlNodeType.Comment,
            XmlNodeType.DocumentType
        };

        private StreamReader streamReader;
        private XmlTextReader _xmlTextReader;
        private Stack<string> stack = new Stack<string>();
        private string stackString = "";
        private Dictionary<string, string> attributeValues;
        private List<string> attributeNames;
        private IEnumerator<string> attributeEnumerator;
        private XmlNodeType nodeType;
        private string nodeContent = String.Empty;
        private bool disposed = false;
        private bool currentlyProcessingEmptyElement;

        public Stream Stream
        {
            get
            {
                return streamReader.BaseStream;
            }
        }

        /// <summary>
        /// Lookup of element names that are not skipped if empty within the XML response structure.
        /// </summary>
        public HashSet<string> AllowEmptyElementLookup { get; private set; }

        /// <remarks>
        /// Despite Microsoft's recommendation to use XmlReader for .NET Framework 2.0 or greater 
        /// (https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmltextreader#remarks), this class
        /// intentionally uses XmlTextReader to handle the XML related object key constraints 
        /// for S3 (https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html).
        /// </remarks>
        private XmlTextReader XmlReader
        {
            get
            {
                if (_xmlTextReader == null)
                {
                    _xmlTextReader = new XmlTextReader(streamReader);
                    _xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
#if BCL35
                    _xmlTextReader.ProhibitDtd = false;
#else
                    _xmlTextReader.DtdProcessing = DtdProcessing.Ignore;
#endif
                }
                return _xmlTextReader;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        public XmlUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
            : this(responseStream, maintainResponseBody, responseData, isException, null)
        {
        }

        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        /// <param name="requestContext">Context for the request that produced this response</param>
        public XmlUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException, IRequestContext requestContext)
        {
            if (isException)
            {
                this.WrappingStream = new CachingWrapperStream(responseStream);
            }
            else if (maintainResponseBody)
            {
                this.WrappingStream = new CachingWrapperStream(responseStream, AWSConfigs.LoggingConfig.LogResponsesSizeLimit);
            }

            if (isException || maintainResponseBody)
            {
                responseStream = this.WrappingStream;
            }
            // If the unmarshaller context is being called internally without there being a http response then the response data would be null
            if (responseData != null)
            {
                long contentLength;
                bool parsedContentLengthHeader = long.TryParse(responseData.GetHeaderValue("Content-Length"), out contentLength);

                // Validate flexible checksums if we know the content length and the behavior was opted in to on the request
                if (parsedContentLengthHeader && responseData.ContentLength == contentLength &&
                        string.IsNullOrEmpty(responseData.GetHeaderValue("Content-Encoding")) &&
                        requestContext?.OriginalRequest?.CoreChecksumMode == CoreChecksumResponseBehavior.ENABLED)
                {
                    SetupFlexibleChecksumStream(responseData, responseStream, contentLength, requestContext);
                }
            }

            streamReader = new StreamReader(this.FlexibleChecksumStream ?? responseStream);

            this.WebResponseData = responseData;
            this.MaintainResponseBody = maintainResponseBody;
            this.IsException = isException;
            this.AllowEmptyElementLookup = new HashSet<string>();
        }

        #endregion

        #region Overrides

        /// <summary>
        /// The current XML path that is being unmarshalled.
        /// </summary>
        public override string CurrentPath
        {
            get { return this.stackString; }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the XML
        ///     document being parsed.
        /// </summary>
        public override int CurrentDepth
        {
            get { return stack.Count; }
        }

        /// <summary>
        /// Reads to the next node in the XML document, and updates the context accordingly.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read./
        /// </returns>
        public override bool Read()
        {
            if (attributeEnumerator != null && attributeEnumerator.MoveNext())
            {
                this.nodeType = XmlNodeType.Attribute;
                stackString = string.Format(CultureInfo.InvariantCulture, "{0}/@{1}", StackToPath(stack), attributeEnumerator.Current);
            }
            else
            {
                // Skip some nodes
                if (nodesToSkip.Contains(XmlReader.NodeType))
                    XmlReader.Read();

                while (XmlReader.IsEmptyElement && !AllowEmptyElementLookup.Contains(XmlReader.LocalName))
                {
                    XmlReader.Read();
                }

                if (currentlyProcessingEmptyElement)
                {
                    nodeType = XmlNodeType.EndElement;
                    stack.Pop();
                    stackString = StackToPath(stack);
                    XmlReader.Read();
                    currentlyProcessingEmptyElement = false;
                }
                else if(XmlReader.IsEmptyElement && AllowEmptyElementLookup.Contains(XmlReader.LocalName))
                {
                    //This is a shorthand form of an empty element <element /> and we want to allow it
                    nodeType = XmlNodeType.Element;
                    stack.Push(XmlReader.LocalName);
                    stackString = StackToPath(stack);
                    currentlyProcessingEmptyElement = true;          
                    
                    //Defer reading so that on next pass we can treat this same element as the end element.
                }
                else
                {
                    switch (XmlReader.NodeType)
                    {
                        case XmlNodeType.EndElement:
                            this.nodeType = XmlNodeType.EndElement;
                            stack.Pop();
                            stackString = StackToPath(stack);
                            XmlReader.Read();
                            break;
                        case XmlNodeType.Element:
                            nodeType = XmlNodeType.Element;
                            stack.Push(XmlReader.LocalName);
                            stackString = StackToPath(stack);
                            this.ReadElement();
                            break;
                    }
                }
            }

            bool moreDataAvailable = 
                XmlReader.ReadState != ReadState.EndOfFile && 
                XmlReader.ReadState != ReadState.Error &&
                XmlReader.ReadState != ReadState.Closed;
            return moreDataAvailable;
        }

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public override string  ReadText()
        {
            if (this.nodeType == XmlNodeType.Attribute)
            {
                return (attributeValues[attributeEnumerator.Current]);
            }
            else
            {
                return nodeContent;
            }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>Element</c>.
        /// </summary>
        public override bool IsStartElement
        {
            get { return this.nodeType == XmlNodeType.Element; }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>EndElement</c>.
        /// </summary>
        public override bool IsEndElement
        {
            get { return this.nodeType == XmlNodeType.EndElement; }
        }

        /// <summary>
        /// True if the context is at the start of the document.
        /// </summary>
        public override bool IsStartOfDocument
        {
            get { return XmlReader.ReadState == ReadState.Initial; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// True if <c>NodeType</c> is <c>Attribute</c>.
        /// </summary>
        public bool IsAttribute
        {
            get { return this.nodeType == XmlNodeType.Attribute; }
        }

        #endregion

        #region Private Methods

        private static string StackToPath(Stack<string> stack)
        {
            string path = null;
            foreach (string s in stack.ToArray())
            {
                path = null == path ? s : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", s, path);
            }
            return "/" + path;
        }

        // Move to the next element, cache the attributes collection
        // and attempt to cache the inner text of the element if applicable.
        private void ReadElement()
        {
            if (XmlReader.HasAttributes)
            {
                attributeValues = new Dictionary<string, string>();
                attributeNames = new List<string>();
                while (XmlReader.MoveToNextAttribute())
                {
                    attributeValues.Add(XmlReader.LocalName, XmlReader.Value);
                    attributeNames.Add(XmlReader.LocalName);
                }
                attributeEnumerator = attributeNames.GetEnumerator();
            }
            XmlReader.MoveToElement();
            XmlReader.Read();

            if (XmlReader.NodeType == XmlNodeType.Text)
                nodeContent = XmlReader.ReadContentAsString();
            else
                nodeContent = String.Empty;
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (streamReader != null)
                    {
                        streamReader.Dispose();
                        streamReader = null;
                    }
                    if (_xmlTextReader != null)
                    {
#if NETSTANDARD
                        _xmlTextReader.Dispose();
#else
                        _xmlTextReader.Close();
#endif
                        _xmlTextReader = null;
                    }
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }
    }

    public class EC2UnmarshallerContext : XmlUnmarshallerContext
    {
        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        public EC2UnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
            : base(responseStream, maintainResponseBody, responseData, isException)
        {
        }

        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        /// <param name="requestContext">Context for the request that produced this response</param>
        public EC2UnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException, IRequestContext requestContext)
            : base(responseStream, maintainResponseBody, responseData, isException, requestContext)
        {
        }

        /// <summary>
        /// RequestId value, if found in response
        /// </summary>
        public string RequestId { get; private set; }

        /// <summary>
        /// Reads to the next node in the XML document, and updates the context accordingly.
        /// If node is RequestId, reads the contents and stores in RequestId property.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read./
        /// </returns>
        public override bool Read()
        {
            bool result = base.Read();
            if (RequestId == null)
            {
                if (IsStartElement && TestExpression("RequestId", 2))
                {
                    RequestId = StringUnmarshaller.GetInstance().Unmarshall(this);
                }
            }
            return result;
        }
    }

}
