/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;

using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Base class for the UnmarshallerContext objects that are used
    /// to unmarshall a web-service response.
    /// </summary>
    public class UnmarshallerContext
    {
        protected CrcCalculatorStream crcStream;
        protected int crc32Result;

        protected string responseContents;

        public string ResponseBody
        {
            get { return responseContents; }
        }

        internal void ValidateCRC32IfAvailable()
        {
            if (this.crcStream != null)
            {
                if (this.crcStream.Crc32 != this.crc32Result)
                {
                    throw new IOException("CRC value returned with response does not match the computed CRC value for the returned response body.");
                }
            }
        }

        protected void SetupCRCStream(NameValueCollection headers, Stream responseStream, long contentLength)
        {
            this.crcStream = null;

            UInt32 parsed;
            if (UInt32.TryParse(headers["x-amz-crc32"], out parsed))
            {
                this.crc32Result = (int)parsed;
                this.crcStream = new CrcCalculatorStream(responseStream, contentLength);
            }
        }
    }

    /// <summary>
    /// Wrap an <c>XmltextReader</c> for simulating an event stream.
    /// 
    /// Each <c>Read()</c> operation goes either to the next element or next attribute within
    /// the current element. <c>TestExpression()</c> is used to match the current event
    /// to an xpath expression. The general pattern looks like this:
    /// <code>
    /// UnmarshallerContext context = new UnmarshallerContext(xmlReader);
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
        private XmlTextReader xmlReader;
        private Stack<string> stack = new Stack<string>();
        private string stackString = "";
        private Dictionary<string, string> attributeValues;
        private List<string> attributeNames;
        private IEnumerator<string> attributeEnumerator;
        private XmlNodeType nodeType;
        private string nodeContent = String.Empty;
        private NameValueCollection headers;

        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseBody">String with the XML from a service response.</param>
        /// <param name="headers">Headers associated with the request.</param>
        public XmlUnmarshallerContext(string responseBody, NameValueCollection headers)
        {
            this.xmlReader = new XmlTextReader(new StringReader(responseBody));
            this.xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            this.headers = headers ?? new NameValueCollection();
            this.responseContents = responseBody;
        }
        
        /// <summary>
        /// Wrap an XmlTextReader with state for event-based parsing of an XML stream.
        /// </summary>
        /// <param name="responseStream"><c>Stream</c> with the XML from a service response.</param>
        /// <param name="headers">Headers associated with the request.</param>
        public XmlUnmarshallerContext(Stream responseStream, NameValueCollection headers)
        {
            this.xmlReader = new XmlTextReader(new StreamReader(responseStream));
            this.xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            this.headers = headers ?? new NameValueCollection();
            this.responseContents = null;
        }

        /// <summary>
        /// Gets the associated headers for the request.
        /// </summary>
        public NameValueCollection Headers
        {
            get { return this.headers; }
        }

        /// <summary>
        /// The current XML path that is being unmarshalled.
        /// </summary>
        public string CurrentPath
        {
            get { return this.stackString; }
        }

        /// <summary>
        ///     Reads to the next node in the XML document, and updates the context
        ///     accordingly.
        /// </summary>
        /// <returns>
        ///     True if a node was read, false if there are no more elements to read./
        /// </returns>
        public bool Read()
        {
            if (attributeEnumerator != null && attributeEnumerator.MoveNext())
            {
                this.nodeType = XmlNodeType.Attribute;
                stackString = String.Format("{0}/@{1}", StackToPath(stack), attributeEnumerator.Current);
            }
            else
            {
                if (xmlReader.NodeType == XmlNodeType.None || xmlReader.NodeType == XmlNodeType.XmlDeclaration)
                    xmlReader.Read();

                while (xmlReader.IsEmptyElement)
                {
                    xmlReader.Read();
                }

                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.EndElement:
                        this.nodeType = XmlNodeType.EndElement;
                        stack.Pop();
                        stackString = StackToPath(stack);
                        xmlReader.Read();
                        break;
                    case XmlNodeType.Element:
                        nodeType = XmlNodeType.Element;
                        stack.Push(xmlReader.LocalName);
                        stackString = StackToPath(stack);
                        this.ReadElement();
                        break;
                }
            }

            return xmlReader.ReadState != ReadState.EndOfFile;
        }

        /// <summary>
        ///     Returns the text contents of the current element being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current element being parsed.
        /// </returns>
        public string  ReadText()
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
        ///     Tests the specified expression against the current position in the XML
        ///     document </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <returns>
        ///     True if the expression matches the current position in the document, 
        ///     false otherwise.</returns>
        public bool TestExpression(string expression)
        {
            if (expression.Equals("."))
                return true;

            return stackString.EndsWith(expression);
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
            if (expression.Equals("."))
                return true;

            //foreach (string s in expression.Split(new char[] {'/'}))
            //    if (s != null && s.Length > 0 && !s.StartsWith("@"))
            //        startingStackDepth++;
            int index = -1;
            while ((index = expression.IndexOf("/", index + 1)) > -1)
            {
                // Don't consider attributes a new depth level
                if (expression[0] != '@')
                {
                    startingStackDepth++;
                }
            }
            return (startingStackDepth == this.CurrentDepth 
                    && stackString.EndsWith("/" + expression));
        }

        /// <summary>
        ///     Rewinds the context to the start of the XML document being parsed.
        /// </summary>
        public void Reset()
        {
            this.xmlReader.ResetState();
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the XML
        ///     document being parsed.
        /// </summary>
        public int CurrentDepth
        {
            get { return stack.Count; }
        }

        /// <summary>
        /// The <c>XmlNodeType</c> of the current event. Will be one of
        /// <c>Element</c>, <c>EndElement</c>, or <c>Attribute</c> during parsing,
        /// and <c>None</c> at the start and end.
        /// </summary>
        public XmlNodeType NodeType
        {
            get { return this.nodeType; }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>Attribute</c>.
        /// </summary>
        public bool IsAttribute
        {
            get { return this.nodeType == XmlNodeType.Attribute; }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>Element</c>.
        /// </summary>
        public bool IsStartElement
        {
            get { return this.nodeType == XmlNodeType.Element; }
        }

        /// <summary>
        /// True if <c>NodeType</c> is <c>EndElement</c>.
        /// </summary>
        public bool IsEndElement
        {
            get { return this.nodeType == XmlNodeType.EndElement; }
        }

        /// <summary>
        /// True if the context is at the start of the document.
        /// </summary>
        public bool IsStartOfDocument
        {
            get { return xmlReader.ReadState == ReadState.Initial; }
        }

        #region Private Methods
        
        private string StackToPath(Stack<string> stack)
        {
            string path = null;
            foreach (string s in stack.ToArray())
            {
                path = null == path ? s : String.Format("{0}/{1}", s, path);
            }
            return "/" + path;
        }

        // Move to the next element, cache the attributes collection
        // and attempt to cache the inner text of the element if applicable.
        private void ReadElement()
        {
            if (xmlReader.HasAttributes)
            {
                attributeValues = new Dictionary<string, string>();
                attributeNames = new List<string>();
                while (xmlReader.MoveToNextAttribute())
                {
                    attributeValues.Add(xmlReader.LocalName, xmlReader.Value);
                    attributeNames.Add(xmlReader.LocalName);
                }
                attributeEnumerator = attributeNames.GetEnumerator();
            }
            xmlReader.MoveToElement();
            xmlReader.Read();

            if (xmlReader.NodeType == XmlNodeType.Text)
                nodeContent = xmlReader.ReadContentAsString();
            else
                nodeContent = String.Empty;
        }

        #endregion
    }
}
