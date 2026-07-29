using Amazon.Runtime.Internal.Util;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Amazon.Runtime.Internal.Transform
{
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
            XmlNodeType.DocumentType,
            XmlNodeType.CDATA,
            XmlNodeType.Whitespace
        };

        private StreamReader streamReader;
        private XmlTextReader _xmlTextReader;
        private readonly XmlPathBuffer pathBuffer = new XmlPathBuffer();
        private string currentAttributeName;
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
                    _xmlTextReader.WhitespaceHandling = WhitespaceHandling.All;
                    _xmlTextReader.DtdProcessing = DtdProcessing.Ignore;
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

                if (parsedContentLengthHeader && contentLength == 0)
                {
                    IsEmptyResponse = true;
                }
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
        }

        #endregion

        #region Overrides

        /// <summary>
        /// The current XML path that is being unmarshalled.
        /// </summary>
        public override string CurrentPath
        {
            get
            {
                return this.currentAttributeName == null
                    ? this.pathBuffer.CurrentPath
                    : this.pathBuffer.BuildAttributePath(this.currentAttributeName);
            }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the XML
        ///     document being parsed.
        /// </summary>
        public override int CurrentDepth
        {
            get { return pathBuffer.Count; }
        }

        /// <summary>
        /// The local name of the element the parser is currently positioned on (the last path
        /// segment), or an empty string at the document root.
        /// </summary>
        public string CurrentElementName
        {
            get { return this.pathBuffer.TopSegment; }
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

        /// <summary>
        /// Matches an expression against the current path suffix without materializing the path string.
        /// Result-identical to the base string-based <see cref="UnmarshallerContext.TestExpression(string)"/>.
        /// </summary>
        public override bool TestExpression(string expression)
        {
            if (expression.Equals("."))
                return true;

            // Build the comparison span. For an attribute node the effective path is
            // "{elementPath}/@{attr}", which we never materialize on the element buffer; fall back
            // to the string path in that (rare) case to keep behavior identical.
            if (currentAttributeName != null)
                return CurrentPath.EndsWith(expression, StringComparison.OrdinalIgnoreCase);

            return (pathBuffer.PathSpan.Length == 0 ? "/".AsSpan() : pathBuffer.PathSpan)
                 .EndsWith(expression.AsSpan(), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Matches an expression at a given starting stack depth without materializing the path string.
        /// Result-identical to the base string-based <see cref="UnmarshallerContext.TestExpression(string, int)"/>.
        /// </summary>
        public override bool TestExpression(string expression, int startingStackDepth)
        {
            if (expression.Equals("."))
                return true;

            // Count '/' separators to derive the required depth, matching the base algorithm exactly.
            int requiredDepth = startingStackDepth;
            for (int i = expression.IndexOf('/'); i > -1; i = expression.IndexOf('/', i + 1))
            {
                // Don't consider attributes a new depth level
                if (expression[0] != '@')
                    requiredDepth++;
            }

            if (requiredDepth != CurrentDepth)
                return false;

            var path = pathBuffer.PathSpan;
            if (currentAttributeName != null)
            {
                path = CurrentPath.AsSpan();
            }

            return path.Length > expression.Length
                && path[path.Length - expression.Length - 1] == '/'
                && path.EndsWith(expression.AsSpan(), StringComparison.OrdinalIgnoreCase);
        }

        #endregion

        #region Public methods

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public string ReadText()
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
        /// Reads the next token at depth greater than or equal to target depth.
        /// </summary>
        /// <param name="targetDepth">Tokens are read at depth greater than or equal to target depth.</param>
        /// <returns>True if a token was read and current depth is greater than or equal to target depth.</returns>
        public bool ReadAtDepth(int targetDepth)
        {
            return Read() && this.CurrentDepth >= targetDepth;
        }

        /// <summary>
        /// Reads to the next node in the XML document, and updates the context accordingly.
        /// </summary>
        /// <returns>
        /// True if a node was read, false if there are no more elements to read./
        /// </returns>
        public virtual bool Read()
        {
            if (attributeEnumerator != null && attributeEnumerator.MoveNext())
            {
                this.nodeType = XmlNodeType.Attribute;
                // Positioned on an attribute: the element path is unchanged; CurrentPath/matching
                // append "/@{name}" on demand via currentAttributeName.
                this.currentAttributeName = attributeEnumerator.Current;
            }
            else
            {
                this.currentAttributeName = null;

                // Skip some nodes
                if (nodesToSkip.Contains(XmlReader.NodeType))
                    XmlReader.Read();

                if (currentlyProcessingEmptyElement)
                {
                    nodeType = XmlNodeType.EndElement;
                    pathBuffer.Pop();
                    XmlReader.Read();
                    currentlyProcessingEmptyElement = false;
                }
                else if (XmlReader.IsEmptyElement)
                {
                    //This is a shorthand form of an empty element <element /> and we want to allow it
                    nodeType = XmlNodeType.Element;
                    pathBuffer.Push(XmlReader.LocalName);
                    currentlyProcessingEmptyElement = true;
                    nodeContent = String.Empty;

                    //Defer reading so that on next pass we can treat this same element as the end element.
                }
                else
                {
                    switch (XmlReader.NodeType)
                    {
                        case XmlNodeType.EndElement:
                            this.nodeType = XmlNodeType.EndElement;
                            pathBuffer.Pop();
                            XmlReader.Read();
                            break;
                        case XmlNodeType.Element:
                            nodeType = XmlNodeType.Element;
                            pathBuffer.Push(XmlReader.LocalName);
                            this.ReadElement();
                            break;
                        default:
                            // Advance past any unhandled node types (e.g. Text nodes between sibling
                            // elements in malformed/HTML responses) to prevent an infinite loop.
                            XmlReader.Read();

                            // Ensure the context state does not continue to reflect the previous node
                            // after advancing the underlying XmlReader past an unhandled node type.
                            nodeType = XmlNodeType.None;
                            nodeContent = string.Empty;
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
        /// True if <c>NodeType</c> is <c>Attribute</c>.
        /// </summary>
        public bool IsAttribute
        {
            get { return this.nodeType == XmlNodeType.Attribute; }
        }

        #endregion

        #region Private Methods

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

            if (XmlReader.NodeType == XmlNodeType.Text || XmlReader.NodeType == XmlNodeType.Whitespace)
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
                    pathBuffer.Dispose();
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }

        private sealed class XmlPathBuffer : IDisposable
        {
            // The current path as chars, e.g. "/Root/Child/member". Segments are appended on Push and
            // trimmed (by moving pathLength back) on Pop. The buffer is reused for the whole document.
            private char[] pathChars = ArrayPool<char>.Shared.Rent(256);
            private int pathLength;
            // Length (including the leading '/') of each pushed segment, enabling O(1) Pop.
            private readonly Stack<int> segmentLengths = new Stack<int>();
            private string cached;

            /// <summary>Number of element segments on the path (the current depth).</summary>
            public int Count
            {
                get { return segmentLengths.Count; }
            }

            /// <summary>
            /// The full path string, e.g. "/Root/Child". An empty stack yields "/" to match the
            /// historical StackToPath behavior. Materialized lazily and cached until the next mutation.
            /// </summary>
            public string CurrentPath
            {
                get
                {
                    return this.cached ??= pathLength == 0 ? "/" : new string(pathChars, 0, pathLength);
                }
            }

            /// <summary>The path chars without the trailing string allocation, for span matching.</summary>
            public ReadOnlySpan<char> PathSpan
            {
                get { return pathChars.AsSpan(0, pathLength); }
            }

            public string TopSegment
            {
                get
                {
                    if (segmentLengths.Count == 0)
                        return string.Empty;

                    int seg = segmentLengths.Peek();
                    return new string(pathChars, pathLength - seg + 1, seg - 1);
                }
            }

            /// <summary>
            /// Builds the transient attribute path "{CurrentPath}/@{name}" without mutating the buffer.
            /// </summary>
            public string BuildAttributePath(string attributeName)
            {
                return string.Concat(CurrentPath, "/@", attributeName);
            }

            public void Push(string localName)
            {
                int seg = localName.Length + 1; // leading '/'
                EnsureCapacity(seg);
                pathChars[pathLength++] = '/';
                localName.CopyTo(0, pathChars, pathLength, localName.Length);
                pathLength += localName.Length;
                segmentLengths.Push(seg);
                cached = null;
            }

            public void Pop()
            {
                if (segmentLengths.Count == 0)
                    return;

                pathLength -= segmentLengths.Pop();
                cached = null;
            }

            private void EnsureCapacity(int additionalChars)
            {
                if (pathLength + additionalChars <= pathChars.Length)
                    return;

                int newSize = Math.Max(pathChars.Length * 2, pathLength + additionalChars);
                char[] newBuffer = ArrayPool<char>.Shared.Rent(newSize);
                Array.Copy(pathChars, 0, newBuffer, 0, pathLength);
                ArrayPool<char>.Shared.Return(pathChars);
                pathChars = newBuffer;
            }

            public void Dispose()
            {
                if (pathChars != null)
                {
                    // Materialize the path string before returning the buffer so that a post-dispose
                    // CurrentPath read (e.g. AmazonUnmarshallingException diagnostics in an error path)
                    // returns the last known path instead of dereferencing the returned buffer.
                    cached ??= pathLength == 0 ? "/" : new string(pathChars, 0, pathLength);
                    ArrayPool<char>.Shared.Return(pathChars);
                    pathChars = null;
                }
            }
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
