using Amazon.Runtime.Internal.Util;
using System;
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
                stackString = string.Format(CultureInfo.InvariantCulture, "{0}/@{1}", StackToPath(stack), attributeEnumerator.Current);
            }
            else
            {
                // Skip some nodes
                if (nodesToSkip.Contains(XmlReader.NodeType))
                    XmlReader.Read();

                if (currentlyProcessingEmptyElement)
                {
                    nodeType = XmlNodeType.EndElement;
                    stack.Pop();
                    stackString = StackToPath(stack);
                    XmlReader.Read();
                    currentlyProcessingEmptyElement = false;
                }
                else if (XmlReader.IsEmptyElement)
                {
                    //This is a shorthand form of an empty element <element /> and we want to allow it
                    nodeType = XmlNodeType.Element;
                    stack.Push(XmlReader.LocalName);
                    stackString = StackToPath(stack);
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
