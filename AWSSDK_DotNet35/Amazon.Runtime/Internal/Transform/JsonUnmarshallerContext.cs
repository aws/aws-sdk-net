/*
 * Copyright 2011-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        #region Private members

        private StreamReader streamReader = null;
        private JsonReader jsonReader = null;
        private Stack<string> stack = new Stack<string>();
        private string stackString = "";
        private string currentField;
        private JsonToken? currentToken = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseStream">Stream that contains the JSON for unmarshalling</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public JsonUnmarshallerContext(Stream responseStream, IWebResponseData responseData)
        {
            this.WebResponseData = responseData;
            this.ResponseContents = null;

            long contentLength;
            if (long.TryParse(responseData.GetHeaderValue("Content-Length"), out contentLength))
            {
                base.SetupCRCStream(responseData, responseStream, contentLength);
            }

            if (this.CrcStream != null)
                streamReader = new StreamReader(this.CrcStream);
            else
                streamReader = new StreamReader(responseStream);

            jsonReader = new JsonReader(streamReader);
        }

        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseBody">String that contains the JSON for unmarshalling</param>
        /// <param name="responseData">Response data coming back from the request</param>
        public JsonUnmarshallerContext(string responseBody, IWebResponseData responseData)
        {
            this.WebResponseData = responseData;
            this.ResponseContents = responseBody;

            streamReader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(responseBody)));
            jsonReader = new JsonReader(streamReader);
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
                return (CurrentTokenType == JsonToken.None) && (!streamReader.EndOfStream);
            }
        }

        /// <summary>
        /// Is the current token the end of an object
        /// </summary>    
        public override bool IsEndElement
        {
            get { return CurrentTokenType == JsonToken.ObjectEnd; }
        }

        /// <summary>
        /// Is the current token the start of an object
        /// </summary>
        public override bool IsStartElement
        {
            get { return CurrentTokenType == JsonToken.ObjectStart; }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the json
        ///     document being parsed.
        /// </summary>
        public override int CurrentDepth
        {
            get
            {
                int depth = 0;
                foreach (string s in stack)
                {
                    if (!
                            (
                            s.Equals(JsonToken.ObjectStart.ToString(), StringComparison.OrdinalIgnoreCase) ||
                            s.Equals(JsonToken.ArrayStart.ToString(), StringComparison.OrdinalIgnoreCase)
                            )
                        )
                    {
                        depth++;
                    }
                }
                if (currentField != null) depth++;
                return depth;
            }
        }

        /// <summary>
        /// The current Json path that is being unmarshalled.
        /// </summary>
        public override string CurrentPath
        {
            get { return stackString; }
        }

        /// <summary>
        ///     Reads to the next token in the json document, and updates the context
        ///     accordingly.
        /// </summary>
        /// <returns>
        ///     True if a token was read, false if there are no more tokens to read./
        /// </returns>
        public override bool Read()
        {
            bool result = jsonReader.Read();

            if (result)
            {
                currentToken = jsonReader.Token;
                UpdateContext();
            }
            return result;
        }

        /// <summary>
        ///     Returns the text contents of the current token being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current token being parsed.
        /// </returns>
        public override string ReadText()
        {
            object data = jsonReader.Value;
            string text;
            switch (currentToken)
            {
                case JsonToken.Null:
                    text = null;
                    break;
                case JsonToken.String:
                case JsonToken.PropertyName:
                    text = data as string;
                    break;
                case JsonToken.Boolean:
                case JsonToken.Double:
                case JsonToken.Int:
                case JsonToken.Long:
                    IFormattable iformattable = data as IFormattable;
                    if (iformattable != null)
                        text = iformattable.ToString(null, CultureInfo.InvariantCulture);
                    else
                        text = data.ToString();
                    break;
                default:
                    throw new AmazonClientException(
                            "We expected a VALUE token but got: " + currentToken);
            }
            return text;
        }

        #endregion

        #region Internal methods/properties

        /// <summary>
        /// Get the base stream of the jsonStream.
        /// </summary>
        internal Stream Stream
        {
            get { return streamReader.BaseStream; }
        }

        /// <summary>
        /// Peeks at the next (non-whitespace) character in the jsonStream.
        /// </summary>
        /// <returns>The next (non-whitespace) character in the jsonStream, or -1 if at the end.</returns>
        internal int Peek()
        {
            while (Char.IsWhiteSpace((char)StreamPeek()))
            {
                streamReader.Read();
            }
            return StreamPeek();

        }

        /// <summary>
        /// The type of the current token
        /// </summary>
        internal JsonToken CurrentTokenType
        {
            get { return currentToken.Value; }
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

        private void UpdateContext()
        {
            if (!currentToken.HasValue) return;

            if (currentToken.Value == JsonToken.ObjectStart || currentToken.Value == JsonToken.ArrayStart)
            {
                if (currentField != null)
                {
                    stack.Push(currentField);
                    stack.Push(currentToken.ToString());
                    currentField = null;
                }
            }
            else if (currentToken.Value == JsonToken.ObjectEnd || currentToken.Value == JsonToken.ArrayEnd)
            {
                if (stack.Count > 0)
                {
                    bool squareBracketsMatch = currentToken.Value == JsonToken.ArrayEnd && stack.Peek().Equals(JsonToken.ArrayStart.ToString(), StringComparison.OrdinalIgnoreCase);
                    bool curlyBracketsMatch = currentToken.Value == JsonToken.ObjectEnd && stack.Peek().Equals(JsonToken.ObjectStart.ToString(), StringComparison.OrdinalIgnoreCase);
                    if (squareBracketsMatch || curlyBracketsMatch)
                    {
                        stack.Pop();
                        stack.Pop();
                    }
                }
                currentField = null;
            }
            else if (currentToken.Value == JsonToken.PropertyName)
            {
                string t = ReadText();
                currentField = t;
            }

            RebuildStackString();
        }

        private void RebuildStackString()
        {
            stackString = "";

            foreach (string s in stack)
            {
                if (
                    !(
                        s.Equals(JsonToken.ArrayStart.ToString(), StringComparison.OrdinalIgnoreCase) ||
                        s.Equals(JsonToken.ObjectStart.ToString(), StringComparison.OrdinalIgnoreCase)))
                {
                    stackString += "/" + s;
                }
            }

            if (currentField != null)
            {
                stackString += "/" + currentField;
            }

            if (string.IsNullOrEmpty(stackString)) stackString = "/";
        }

        #endregion
    }
}
