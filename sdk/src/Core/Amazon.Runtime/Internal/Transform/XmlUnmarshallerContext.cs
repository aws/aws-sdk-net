using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
#if NET8_0_OR_GREATER
using System.Collections.Frozen;
#endif

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

        private static readonly HashSet<XmlNodeType> nodesToSkipInternal = new HashSet<XmlNodeType>
        {
            XmlNodeType.None,
            XmlNodeType.XmlDeclaration,
            XmlNodeType.Comment,
            XmlNodeType.DocumentType,
            XmlNodeType.CDATA,
            XmlNodeType.Whitespace
        };

#if NET8_0_OR_GREATER
        private static readonly FrozenSet<XmlNodeType> nodesToSkip = nodesToSkipInternal.ToFrozenSet();
#else
        private static readonly HashSet<XmlNodeType> nodesToSkip = nodesToSkipInternal;
#endif

        private StreamReader streamReader;
        private XmlTextReader _xmlTextReader;
        // Stack of full element paths (e.g. "/root/child") built incrementally on push,
        // so the current path never needs to be recomputed by walking the stack.
        private readonly Stack<string> stack = new Stack<string>();
        private string stackString = "";
        private string lastPoppedPath;
        private int lastPoppedDepth = -1;
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
                    _xmlTextReader = new XmlTextReader(streamReader)
                    {
                        WhitespaceHandling = WhitespaceHandling.All,
                        DtdProcessing = DtdProcessing.Ignore
                    };
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
                bool parsedContentLengthHeader = long.TryParse(responseData.GetHeaderValue("Content-Length"), out long contentLength);

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
                stackString = string.Concat(stack.Peek(), "/@", attributeEnumerator.Current);
            }
            else
            {
                // Skip some nodes
                if (nodesToSkip.Contains(XmlReader.NodeType))
                    XmlReader.Read();

                if (currentlyProcessingEmptyElement)
                {
                    nodeType = XmlNodeType.EndElement;
                    PopElementPath();
                    XmlReader.Read();
                    currentlyProcessingEmptyElement = false;
                }
                else if (XmlReader.IsEmptyElement)
                {
                    //This is a shorthand form of an empty element <element /> and we want to allow it
                    nodeType = XmlNodeType.Element;
                    PushElementPath(XmlReader.LocalName);
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
                            PopElementPath();
                            XmlReader.Read();
                            break;
                        case XmlNodeType.Element:
                            nodeType = XmlNodeType.Element;
                            PushElementPath(XmlReader.LocalName);
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
                            stackString = stack.Count > 0 ? stack.Peek() : "/";
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

        private void PushElementPath(string name)
        {
            string parentPath = stack.Count > 0 ? stack.Peek() : string.Empty;
            string path;
            // Reuse the previously popped path when re-entering an element with the same name at
            // the same depth (common for repeated list elements, e.g. <member>), avoiding a new
            // string allocation per sibling. The parent path is guaranteed unchanged because any
            // intermediate pop would have overwritten lastPoppedPath/lastPoppedDepth.
            string reusable = lastPoppedPath;
            if (reusable != null &&
                stack.Count == lastPoppedDepth &&
                reusable.Length == parentPath.Length + name.Length + 1 &&
                string.CompareOrdinal(reusable, parentPath.Length + 1, name, 0, name.Length) == 0)
            {
                path = reusable;
            }
            else
            {
                path = string.Concat(parentPath, "/", name);
            }
            stack.Push(path);
            stackString = path;
        }

        private void PopElementPath()
        {
            lastPoppedPath = stack.Pop();
            lastPoppedDepth = stack.Count;
            stackString = stack.Count > 0 ? stack.Peek() : "/";
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
