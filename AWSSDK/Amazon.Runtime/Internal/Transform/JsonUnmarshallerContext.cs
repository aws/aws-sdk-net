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
using System.IO;
using System.Text;
using System.Collections.Specialized;

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
        #region Private Members
        private StreamReader jsonStream = null;
        private Stack<string> keyChain = new Stack<string>();
        private string keyChainString = "";
        private bool key = true;
        private bool addedKey = true;
        private Stack<bool> inArray = new Stack<bool>();
        private Token current = new Token();
        private NameValueCollection headers;
        private int httpStatusCode;
        #endregion

        #region Constructors
        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseStream">Stream that contains the JSON for unmarshalling</param>
        /// <param name="httpStatusCode">Status code of the response</param>
        /// <param name="headers">Headers associated with the request.</param>
        public JsonUnmarshallerContext(Stream responseStream, int httpStatusCode, NameValueCollection headers)
        {
            this.headers = headers ?? new NameValueCollection();
            this.responseContents = null;
            this.httpStatusCode = httpStatusCode;

            long contentLength;
            if (long.TryParse(headers["Content-Length"], out contentLength))
            {
                base.SetupCRCStream(headers, responseStream, contentLength);
            }

            if (this.crcStream != null)
                this.jsonStream = new StreamReader(this.crcStream);
            else
                this.jsonStream = new StreamReader(responseStream);
        }
        /// <summary>
        /// Wrap the jsonstring for unmarshalling.
        /// </summary>
        /// <param name="responseBody">String that contains the JSON for unmarshalling</param>
        /// <param name="httpStatusCode">Status code of the response</param>
        /// <param name="headers">Headers associated with the request.</param>
        public JsonUnmarshallerContext(string responseBody, int httpStatusCode, NameValueCollection headers)
        {
            this.responseContents = responseBody;
            this.jsonStream = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(responseBody)));
            this.headers = headers ?? new NameValueCollection();
            this.httpStatusCode = httpStatusCode;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The Http Status Code of the request being unmarshalled.
        /// </summary>
        public int HttpStatusCode
        {
            get { return this.httpStatusCode; }
        }

        /// <summary>
        /// Gets the associated headers for the request.
        /// </summary>
        public NameValueCollection Headers
        {
            get { return this.headers; }
        }

        /// <summary>
        /// Is the current token the start of an object
        /// </summary>
        public bool IsStartElement
        {
            get { return current.Type == TokenType.StartElement; }
        }
        /// <summary>
        /// Is the current token the end of an object
        /// </summary>    
        public bool IsEndElement
        {
            get { return current.Type == TokenType.EndElement; }
        }
        /// <summary>
        /// Is the current token an element seperator
        /// </summary>
        public bool IsElementSeperator
        {
            get { return current.Type == TokenType.ElementSeperator; }
        }
        /// <summary>
        /// Is the current token a string
        /// </summary>
        public bool IsText
        {
            get { return current.Type == TokenType.Text; }
        }
        /// <summary>
        /// Is the current token a key value seperator
        /// </summary>
        public bool IsKeyValueSeperator
        {
            get { return current.Type == TokenType.KeyValueSeperator; }
        }
        /// <summary>
        /// Is the current token the start of an array
        /// </summary>
        public bool IsStartArray
        {
            get { return current.Type == TokenType.StartArray; }
        }
        /// <summary>
        /// Is the current token the end of an array
        /// </summary>
        public bool IsEndArray
        {
            get { return current.Type == TokenType.EndArray; }
        }
        /// <summary>
        /// Is the current token a number
        /// </summary>
        public bool IsNumber
        {
            get { return current.Type == TokenType.Number; }
        }
        /// <summary>
        /// Is the current token a Boolean.
        /// </summary>
        public bool IsBoolean
        {
            get { return current.Type == TokenType.Boolean; }
        }
        /// <summary>
        /// Is the current token a null
        /// </summary>
        public bool IsNull
        {
            get { return current.Type == TokenType.Null; }
        }

        /// <summary>
        /// The value of the token if the current token is a Boolean, false otherwise.
        /// </summary>
        public bool BooleanValue
        {
            get
            {
                bool ret = false;
                if (IsBoolean)
                {
                    ret = Boolean.Parse(current.Text);
                }
                return ret;
            }
        }
        /// <summary>
        /// The text represention of the number if the current token is a Number, null otherwise.
        /// </summary>
        public string NumberValue
        {
            get
            {
                string ret = null;
                if (IsNumber)
                {
                    ret = current.Text;
                }
                return ret;
            }
        }
        /// <summary>
        /// The text represention of the string if the current token is Text, null otherwise.
        /// </summary> 
        public string TextValue
        {
            get
            {
                string ret = null;
                if (IsText)
                {
                    ret = current.Text;
                }
                return ret;
            }
        }

        /// <summary>
        /// Are we at the start of the json document.
        /// </summary>
        public bool IsStartOfDocument
        {
            get
            {
                return (CurrentTokenType == TokenType.None) && (!jsonStream.EndOfStream);
            }
        }
        /// <summary>
        /// Are we at the end of the json document.
        /// </summary>
        public bool IsEndOfDocument
        {
            get
            {
                while (!jsonStream.EndOfStream && Char.IsWhiteSpace((char)StreamPeek()))
                {
                    jsonStream.Read();
                }

                return (!jsonStream.EndOfStream);
            }
        }
        /// <summary>
        /// Is the current token a Text token that is a key.
        /// </summary>
        public bool IsKey
        {
            get
            {
                return IsText && key;
            }
        }
        /// <summary>
        /// Is the current token a Number, Boolean, Null Token, or a Text token that is a value.
        /// </summary>
        public bool IsLeafValue
        {
            get
            {
                return (IsNumber || IsBoolean || IsNull || (IsText && !key));
            }
        }
        /// <summary>
        /// Is the current token a value token and an array element.
        /// </summary>
        public bool IsLeafArrayElement
        {
            get
            {
                return (IsLeafValue && inArray.Peek());
            }
        }
        /// <summary>
        /// Is the current token the start of an array element
        /// </summary>
        public bool IsArrayElement
        {
            get
            {
                bool ret = false;
                ret |= IsLeafArrayElement;
                if (IsStartArray || IsStartElement)
                {
                    bool store = inArray.Pop();
                    if (inArray.Count != 0)
                    {
                        ret |= inArray.Peek();
                    }
                    inArray.Push(store);
                }
                return ret;
            }
        }

        /// <summary>
        ///     Returns the element depth of the parser's current position in the json
        ///     document being parsed.
        /// </summary>
        public int CurrentDepth
        {
            get { return keyChain.Count; }
        }
        /// <summary>
        /// The token type of the current token.
        /// </summary>
        public TokenType CurrentTokenType
        {
            get { return current.Type; }
        }

        /// <summary>
        /// The current Json path that is being unmarshalled.
        /// </summary>
        public string CurrentPath
        {
            get { return this.keyChainString; }
        }
        #endregion

        #region Private Properties
        /// <summary>
        /// Get the base stream of the jsonStream.
        /// </summary>
        internal Stream Stream
        {
            get { return jsonStream.BaseStream; }
        }
        #endregion

        #region Public Methods
        /// <summary>
        ///     Reads to the next token in the json document, and updates the context
        ///     accordingly.
        /// </summary>
        /// <returns>
        ///     True if a token was read, false if there are no more tokens to read./
        /// </returns>
        public bool Read()
        {
            if (jsonStream.EndOfStream)
            {
                return false;
            }

            current = ReadToken();

            if (current.Type == TokenType.None && jsonStream.EndOfStream)
            {
                return false;
            }

            if (current.Type != TokenType.EndElement)
            {
                addedKey = true;
            }

            switch (current.Type)
            {
                case TokenType.StartElement:
                    inArray.Push(false);
                    key = true;
                    addedKey = false;
                    break;
                case TokenType.EndElement:
                    if (inArray.Pop())
                    {
                        throw new InvalidDataException("']' expected but '}' found.");
                    }
                    if (addedKey)
                    {
                        keyChain.Pop();
                        keyChainString = keyChainString.Substring(0, keyChainString.LastIndexOf('/'));
                    }
                    break;
                case TokenType.ElementSeperator:
                    if (inArray.Peek())
                    {
                        key = false;
                    }
                    else
                    {
                        key = true;
                        keyChain.Pop();
                        keyChainString = keyChainString.Substring(0, keyChainString.LastIndexOf('/'));
                    }
                    break;
                case TokenType.Text:
                    if (key)
                    {
                        keyChain.Push(current.Text);
                        keyChainString = String.Format("{0}/{1}", keyChainString, current.Text);
                    }
                    break;
                case TokenType.KeyValueSeperator:
                    key = false;
                    break;
                case TokenType.StartArray:
                    inArray.Push(true);
                    key = false;
                    break;
                case TokenType.EndArray:
                    if (!inArray.Pop())
                    {
                        throw new InvalidDataException("'}' expected but ']' found.");
                    }
                    break;
                case TokenType.Number:
                case TokenType.Boolean:
                case TokenType.Null:
                    break;
                default:
                    throw new InvalidDataException("Invalid json token");
            }
            return true;
        }

        /// <summary>
        ///     Returns the text contents of the current token being parsed.
        /// </summary>
        /// <returns>
        ///     The text contents of the current token being parsed.
        /// </returns>
        public string ReadText()
        {
            return current.Text;
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the json
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

            return keyChainString.EndsWith("/" + expression);
        }

        /// <summary>
        ///     Tests the specified expression against the current position in the json
        ///     document being parsed, and restricts the expression to matching at the
        ///     specified stack depth. </summary>
        /// <param name="expression">
        ///     The pseudo-XPath expression to test.</param>
        /// <param name="startingStackDepth">
        ///     The depth in the stack representing where the expression must
        ///     start matching in order for this method to return true. </param>
        /// <returns>
        ///     True if the specified expression matches the current position in
        ///     the json document, starting from the specified depth. </returns>
        public bool TestExpression(string expression, int startingStackDepth)
        {
            if (expression.Equals("."))
                return true;

            int index = -1;
            while ((index = expression.IndexOf("/", index + 1)) > -1)
            {
                startingStackDepth++;
            }
            return (startingStackDepth == this.CurrentDepth
                    && keyChainString.ToLower().EndsWith("/" + expression.ToLower()));
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Peeks at the next (non-whitespace) character in the jsonStream.
        /// </summary>
        /// <returns>The next (non-whitespace) character in the jsonStream, or -1 if at the end.</returns>
        internal int Peek()
        {
            while (Char.IsWhiteSpace((char)StreamPeek()))
            {
                jsonStream.Read();
            }
            return StreamPeek();

        }

        /// <summary>
        /// Peeks at the next character in the stream.
        /// If the data isn't buffered into the StreamReader (Peek() returns -1),
        /// we flush the buffered data and try one more time.
        /// </summary>
        /// <returns></returns>
        private int StreamPeek()
        {
            int peek = jsonStream.Peek();
            if (peek == -1)
            {
                jsonStream.DiscardBufferedData();
                peek = jsonStream.Peek();
            }
            return peek;
        }

        /// <summary>
        /// Reads the next token from the stream
        /// </summary>
        /// <returns>The token read or an empty token if at the end of the stream.</returns>
        private Token ReadToken()
        {
            Token ret = new Token();

            int nextChar = jsonStream.Read();
            if (nextChar == -1)
            {
                return ret;
            }

            while (Char.IsWhiteSpace((char)nextChar))
            {
                nextChar = jsonStream.Read();
                if (jsonStream.EndOfStream)
                {
                    return ret;
                }

                if (nextChar == -1)
                {
                    return ret;
                }
            }

            switch (nextChar)
            {
                case '{':
                    ret.Type = TokenType.StartElement;
                    break;
                case '}':
                    ret.Type = TokenType.EndElement;
                    break;
                case ',':
                    ret.Type = TokenType.ElementSeperator;
                    break;
                case '"':
                    ret.Type = TokenType.Text;
                    StringBuilder sb = new StringBuilder();
                    bool escaped = false;
                    while ((((nextChar = jsonStream.Read()) != '"') || (escaped)) && (nextChar != -1))
                    {
                        if ((char)nextChar == '\\')
                        {
                            if (escaped)
                            {
                                sb.Append((char)nextChar); // not calling GetEscapedChar, it would simply return \
                            }
                            escaped = !escaped;
                        }
                        else
                        {
                            if (escaped)
                            {
                                char escapedChar = GetEscapedChar(nextChar);
                                sb.Append(escapedChar);
                            }
                            else
                            {
                                sb.Append((char)nextChar);
                            }
                            escaped = false;
                        }
                    }
                    ret.Text = sb.ToString();
                    break;
                case ':':
                    ret.Type = TokenType.KeyValueSeperator;
                    break;
                case '[':
                    ret.Type = TokenType.StartArray;
                    break;
                case ']':
                    ret.Type = TokenType.EndArray;
                    break;
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ret.Type = TokenType.Number;
                    ret.Text = ReadNumber((char)nextChar);
                    break;
                case 't':
                case 'T':
                    ret.Type = TokenType.Boolean;
                    if (!Read("rue", jsonStream, StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new InvalidDataException("Invalid JSON data");
                    }
                    ret.Text = "true";
                    break;
                case 'f':
                case 'F':
                    ret.Type = TokenType.Boolean;
                    if (!Read("alse", jsonStream, StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new InvalidDataException("Invalid JSON data");
                    }
                    ret.Text = "false";
                    break;
                case 'n':
                case 'N':
                    ret.Type = TokenType.Null;
                    if (!Read("ull", jsonStream, StringComparison.InvariantCultureIgnoreCase))
                    {
                        throw new InvalidDataException("Invalid JSON data");
                    }
                    ret.Text = null;
                    break;
                default:
                    throw new InvalidDataException("Invalid JSON data");
            }
            return ret;
        }

        private static char GetEscapedChar(int character)
        {
            switch (character)
            {
                case 'n':
                    return '\n';

                case 't':
                    return '\t';

                case 'r':
                    return '\r';

                case 'b':
                    return '\b';

                case 'f':
                    return '\f';

                //case '"':
                //case '\'':
                //case '\\':
                //case '/':
                default:
                    return Convert.ToChar(character);
            }
        }

        /// <summary>
        /// Reads a json number from the stream
        /// </summary>
        /// <param name="firstChar">first character of the numbers which has already been read</param>
        /// <returns>the string representation of the number</returns>
        private string ReadNumber(char firstChar)
        {
            StringBuilder sb = new StringBuilder(firstChar.ToString());
            char nextChar;

            while (Char.IsNumber((char)StreamPeek()))
            {
                nextChar = (char)jsonStream.Read();
                sb.Append(nextChar);
            }

            if (((char)StreamPeek()) == '.')
            {
                nextChar = (char)jsonStream.Read();
                sb.Append(nextChar);
                while (Char.IsNumber((char)StreamPeek()))
                {
                    nextChar = (char)jsonStream.Read();
                    sb.Append(nextChar);
                }
            }

            if ((((char)StreamPeek()) == 'e') || (((char)StreamPeek()) == 'E'))
            {
                nextChar = (char)jsonStream.Read();
                sb.Append(nextChar);
                if ((((char)StreamPeek()) == '+') || (((char)StreamPeek()) == '-'))
                {
                    nextChar = (char)jsonStream.Read();
                    sb.Append(nextChar);
                }
                while (Char.IsNumber((char)StreamPeek()))
                {
                    nextChar = (char)jsonStream.Read();
                    sb.Append(nextChar);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Checks that the stream contains toRead next when matched using comparisonType
        /// </summary>
        /// <param name="toRead">The string to verify is next in the stream</param>
        /// <param name="from">The stream to read from</param>
        /// <param name="comparisonType">The type of comparison to perform</param>
        /// <returns>If the stream started with toRead or not</returns>
        private bool Read(string toRead, StreamReader from, StringComparison comparisonType)
        {
            bool ret = true;
            char[] value = new char[toRead.Length];
            from.Read(value, 0, value.Length);

            if (!toRead.Equals(new string(value), comparisonType))
            {
                ret = false;
            }
            return ret;
        }
        #endregion

        #region Data Structures
        /// <summary>
        /// Represents a token in the json document, with the TokenType and value if applicable.
        /// </summary>
        private struct Token
        {
            public TokenType Type { get; set; }
            public string Text { get; set; }
        }

        /// <summary>
        /// The different token types in the json document
        /// </summary>
        public enum TokenType
        {
            None,
            StartElement,
            EndElement,
            ElementSeperator,
            Text,
            KeyValueSeperator,
            StartArray,
            EndArray,
            Number,
            Boolean,
            Null
        }
        #endregion
    }
}
