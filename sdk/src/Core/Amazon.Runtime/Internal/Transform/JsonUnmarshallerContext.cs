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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using ThirdParty.Json.LitJson;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Wraps a json string for unmarshalling.
    /// 
    /// Each <c>Read()</c> operation gets the next token.
    /// <c>TestExpression()</c> is used to match the current key-chain
    /// to an xpath expression. The general pattern looks like this:
    /// <code>
    /// JsonUnmarshallerContext context = new JsonUnmarshallerContext(jsonString);
    /// while (context.Read())
    /// {
    ///     if (context.IsKey)
    ///     {
    ///         if (context.TestExpresion("path/to/element"))
    ///         {
    ///             myObject.stringMember = stringUnmarshaller.GetInstance().Unmarshall(context);
    ///             continue;
    ///         }
    ///     }
    /// }
    /// </code>
    /// </summary>
    public class JsonUnmarshallerContext : UnmarshallerContext
    {
        private const string DELIMITER = "/";
        #region Private members

        private StreamReader streamReader = null;
        private JsonPathStack stack = new JsonPathStack();
        private JsonTokenType? currentToken = null;
        private bool disposed = false;
        private bool wasPeeked = false;
        #endregion

        #region Constructors

        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseStream">Stream that contains the JSON for unmarshalling</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        public JsonUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData responseData,
            bool isException = false)
            : this(responseStream, maintainResponseBody, responseData, isException, null)
        { }

        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseStream">Stream that contains the JSON for unmarshalling</param>
        /// <param name="maintainResponseBody"> If set to true, maintains a copy of the complete response body constraint to log response size as the stream is being read.</param>
        /// <param name="responseData">Response data coming back from the request</param>
        /// <param name="isException">If set to true, maintains a copy of the complete response body as the stream is being read.</param>
        /// <param name="requestContext">Context for the request that produced this response</param>
        public JsonUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData responseData,
            bool isException,
            IRequestContext requestContext)
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

            this.WebResponseData = responseData;
            this.MaintainResponseBody = maintainResponseBody;
            this.IsException = isException;

            //if the json unmarshaller context is being called internally without there being a http response then the response data would be null
            if(responseData != null)
            {
                long contentLength;
                bool parsedContentLengthHeader = long.TryParse(responseData.GetHeaderValue("Content-Length"), out contentLength);

                if (parsedContentLengthHeader && contentLength == 0)
                {
                    IsEmptyResponse = true;
                }

                // Temporary work around checking Content-Encoding for an issue with NetStandard on Linux returning Content-Length for a gzipped response.
                // Causing the SDK to attempt a CRC check over the gzipped response data with a CRC value for the uncompressed value. 
                // The Content-Encoding check can be removed with the following github issue is shipped.
                // https://github.com/dotnet/corefx/issues/6796

                if (parsedContentLengthHeader && responseData.ContentLength.Equals(contentLength) &&
                    string.IsNullOrEmpty(responseData.GetHeaderValue("Content-Encoding")))
                {
                    base.SetupCRCStream(responseData, responseStream, contentLength);
                    base.SetupFlexibleChecksumStream(responseData, CrcStream ?? responseStream, contentLength, requestContext);
                }
            }
            
            if (this.FlexibleChecksumStream != null) // either just flexible checksum, or flexible checksum wrapping the older CRC stream
                streamReader = new StreamReader(this.FlexibleChecksumStream);
            else if (this.CrcStream != null)
                streamReader = new StreamReader(this.CrcStream);
            else
                streamReader = new StreamReader(responseStream);
        }

        #endregion
        #region Public Methods

        /// <summary>
        /// Reads the next token at depth greater than or equal to target depth.
        /// </summary>
        /// <param name="targetDepth">Tokens are read at depth greater than or equal to target depth.</param>
        /// <param name="reader">The Utf8JsonReader used to read the document</param>
        /// <returns>True if a token was read and current depth is greater than or equal to target depth.</returns>
        public bool ReadAtDepth(int targetDepth, ref StreamingUtf8JsonReader reader)
        {
            return Read(ref reader) && this.CurrentDepth >= targetDepth;
        }
        #endregion

        #region Overrides

        /// <summary>
        /// Are we at the start of the json document.
        /// </summary>
        public override bool IsStartOfDocument
        {
            get
            {
                return (CurrentTokenType == JsonTokenType.None) && (!streamReader.EndOfStream);
            }
        }

        /// <summary>
        /// Is the current token the end of an object
        /// </summary>    
        public override bool IsEndElement
        {
            get { return CurrentTokenType == JsonTokenType.EndObject; }
        }

        /// <summary>
        /// Is the current token the start of an object
        /// </summary>
        public override bool IsStartElement
        {
            get { return CurrentTokenType == JsonTokenType.StartObject; }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the json
        ///     document being parsed.
        /// </summary>
        public override int CurrentDepth
        {
            get
            {
                return this.stack.CurrentDepth;
            }
        }

        /// <summary>
        /// The current Json path that is being unmarshalled.
        /// </summary>
        public override string CurrentPath
        {
            get 
            {
                return this.stack.CurrentPath; 
            }
        }

        /// <summary>
        ///     Reads to the next token in the json document, and updates the context
        ///     accordingly.
        /// </summary>
        /// <returns>
        ///     True if a token was read, false if there are no more tokens to read.
        /// </returns>
        public bool Read(ref StreamingUtf8JsonReader reader)
        {
            if (wasPeeked)
            {
                wasPeeked = false;
                return currentToken == null;
            }
            
            bool result = reader.Read();
            if (result)
            {
                currentToken = reader.Reader.TokenType;
                UpdateContext(ref reader);
            }
            else
            {
                currentToken = null;
            }
            wasPeeked = false;
            return result;
        }

        /// <summary>
        /// Peeks at the next token. This peek implementation
        /// reads the next token and makes the subsequent Read() return the same data.
        /// If Peek is called successively, it will return the same data.
        /// Only the first one calls Read(), subsequent calls 
        /// will return the same data until a Read() call is made.
        /// </summary>
        /// <param name="token">Token to peek.</param>
        /// <param name="reader">The Utf8JsonReader</param>
        /// <returns>Returns true if the peeked token matches given token.</returns>
        public bool Peek(JsonTokenType token, ref StreamingUtf8JsonReader reader)
        {
            if (wasPeeked)
                return currentToken != null && currentToken == token;

            if (Read(ref reader))
            {
                wasPeeked = true;
                return currentToken == token;
            }
            return false;
        }

        public string ReadText(ref StreamingUtf8JsonReader reader)
        {
            string text = string.Empty;
            switch (currentToken)
            {
                case JsonTokenType.Null:
                    text = null;
                    break;
                case JsonTokenType.True:
                case JsonTokenType.False:
                    text = reader.Reader.GetBoolean().ToString();
                    break;
                case JsonTokenType.PropertyName:
                    text = reader.Reader.GetString();
                    break;
                case JsonTokenType.String:
                    text = reader.Reader.GetString();
                    break;
                   // For numbers we grab the raw value b/ c we don't want to lose precision.
                case JsonTokenType.Number:
#if NETSTANDARD2_0 || NETFRAMEWORK
                    // overload which accepts a ReadOnlySpan<byte> is only available in netstandard2.1 and netcore2.1+
                    text = Encoding.UTF8.GetString(reader.Reader.ValueSpan.ToArray());
#else
                                    text = Encoding.UTF8.GetString(reader.Reader.ValueSpan);
#endif
                    break;
                default:
                    throw new AmazonClientException($"Unexpected token: {currentToken}");
            }
            return text;
        }

#endregion

        #region Public properties

        /// <summary>
        /// The type of the current token
        /// </summary>
        public JsonTokenType? CurrentTokenType
        {
            get { return currentToken; }
        }

        #endregion

        #region Internal methods/properties

        /// <summary>
        /// Get the base stream of the jsonStream.
        /// </summary>
        public Stream Stream
        {
            get { return streamReader.BaseStream; }
        }

        /// <summary>
        /// Peeks at the next (non-whitespace) character in the jsonStream.
        /// </summary>
        /// <returns>The next (non-whitespace) character in the jsonStream, or -1 if at the end.</returns>
        public int Peek()
        {
            // Per MSDN documentation on StreamReader.Peek(), it's perfectly acceptable to cast
            // int returned by Peek() to char.
            unchecked
            {
                while (Char.IsWhiteSpace((char) StreamPeek()))
                {
                    streamReader.Read();
                }
            }
            return StreamPeek();

        }

        #endregion

        #region Private methods

        /// <summary>
        /// Peeks at the next character in the stream.
        /// If the data isn't buffered into the StreamReader (Peek() returns -1),
        /// we flush the buffered data and try one more time.
        /// </summary>
        /// <returns></returns>
        private int StreamPeek()
        {
            int peek = streamReader.Peek();
            if (peek == -1)
            {
                streamReader.DiscardBufferedData();
                peek = streamReader.Peek();
            }
            return peek;
        }

        private void UpdateContext(ref StreamingUtf8JsonReader reader)
        {
            if (!currentToken.HasValue) return;

            if (currentToken.Value == JsonTokenType.StartObject || currentToken.Value == JsonTokenType.StartArray)
            {
                // Push '/' for object start and array start.
                stack.Push(new PathSegment
                {
                    SegmentType = PathSegmentType.Delimiter,
                    Value = DELIMITER
                });
            }
            else if (currentToken.Value == JsonTokenType.EndObject || currentToken.Value == JsonTokenType.EndArray)
            {
                if (stack.Peek().SegmentType == PathSegmentType.Delimiter)
                {
                    // Pop '/' associated with corresponding object start and array start.
                    stack.Pop();
                    if (stack.Count > 0 && stack.Peek().SegmentType != PathSegmentType.Delimiter)
                    {
                        // Pop the property name associated with the
                        // object or array if present.
                        // e.g. {"a":["1","2","3"]}
                        stack.Pop();
                    }
                }
            }
            // if the stack is empty and the token type is a string, then the document is a raw string with no opening or
            // closing delimeter. Per smithy spec https://smithy.io/2.0/spec/simple-types.html#document this is allowed
            // so we should just push the value so that it can be retrieved later.
            else if (currentToken.Value == JsonTokenType.PropertyName || (stack.Count == 0 && currentToken == JsonTokenType.String))
            {
                string t = ReadText(ref reader);

                // Push property name, it's appended to the stack's CurrentPath,
                // it this does not affect the depth.
                stack.Push(new PathSegment
                {
                    SegmentType = PathSegmentType.Value,
                    Value = t
                });
            }
            else if (currentToken.Value != JsonTokenType.None && stack.Peek().SegmentType != PathSegmentType.Delimiter)
            {
                // Pop if you encounter a simple data type or null
                // This will pop the property name associated with it in cases like  {"a":"b"}.
                // Exclude the case where it's a value in an array so we dont end poping the start of array and
                // property name e.g. {"a":["1","2","3"]}
                stack.Pop();
            }

        }

        #endregion
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (streamReader != null)
                    {
                        streamReader.Dispose();
                        streamReader = null;
                    }
                }
                disposed = true;
            }

            base.Dispose(disposing);
        }

        private enum PathSegmentType
        {
            Value,
            Delimiter
        }

        private struct PathSegment
        {
            internal PathSegmentType SegmentType { get; set; }
            internal string Value { get; set; }
        }

        private class JsonPathStack
        {
            private Stack<PathSegment> stack = new Stack<PathSegment>();
            int currentDepth = 0;
            private StringBuilder stackStringBuilder = new StringBuilder(128);
            private string stackString;

            public int CurrentDepth
            {
                get { return this.currentDepth; }
            }

            public string CurrentPath
            {
                get
                {
                    if (this.stackString == null)                    
                        this.stackString = this.stackStringBuilder.ToString();
                    
                    return this.stackString;
                }
            }                        

            internal void Push(PathSegment segment)
            {
                if (segment.SegmentType == PathSegmentType.Delimiter)
                {
                    currentDepth++;
                }

                stackStringBuilder.Append(segment.Value);
                stackString = null;
                stack.Push(segment);
            }
                        
            internal PathSegment Pop()
            {
                var segment = this.stack.Pop();
                if (segment.SegmentType == PathSegmentType.Delimiter)
                {
                    currentDepth--;
                }

                stackStringBuilder.Remove(stackStringBuilder.Length - segment.Value.Length, segment.Value.Length);
                stackString = null;
                return segment;
            }
            
            internal PathSegment Peek()
            {
                return this.stack.Peek();
            }

            public int Count
            {
                get { return this.stack.Count; }
            }
        }
    }
}
