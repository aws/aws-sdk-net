/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model
{
    using Map = System.Collections.Generic.IDictionary<Amazon.S3.Model.S3QueryParameter, string>;

    /// <summary>
    /// Base class for all S3 operation requests.
    /// Provides a header collection which can is used to store the request headers.
    /// </summary>
    public class S3Request : Amazon.S3.Internal.IS3RequestEvents
    {
        #region Private Members

        private WebHeaderCollection headers;
        private Stream inputStream;
        int timeout = 0;
        int readWriteTimeout = 0;

        // Most requests have less than 10 parameters, so 10 is a safe starting capacity
        // This way, the Map.Add operation will be an O(1) operation
        internal Map parameters = new Dictionary<S3QueryParameter, string>(10);

        // The maximum number of headers removed from an S3 Request is 2:
        // If-Modified and Content-Type. Since this is such a small number, 
        // we choose not to allocate memory for all requests.
        internal NameValueCollection removedHeaders = new NameValueCollection();

        #endregion

        #region Headers

        /// <summary>
        /// The collection of headers for the request.
        /// </summary>
        internal WebHeaderCollection Headers
        {
            get
            {
                if (this.headers == null)
                {
                    this.headers = new WebHeaderCollection();
                }
                return this.headers;
            }
        }

        /// <summary>
        /// Checks if the Headers property is set
        /// </summary>
        /// <returns>true if Headers property is set</returns>
        internal bool IsSetHeaders()
        {
            return (this.headers != null && 
                this.headers.Count > 0);
        }

        /// <summary>
        /// Adds all of the specified key/value pairs into the request headers collection.
        /// </summary>
        /// <param name="collection">A collection of key/value headers</param>
        public void AddHeaders(NameValueCollection collection)
        {
            this.Headers.Add(collection);
        }

        /// <summary>
        /// Adds the header to the collection of headers for the request.
        /// </summary>
        /// <param name="key">The name of the header, for example Content-Disposition.</param>
        /// <param name="value">The value to be set for the header.</param>
        public void AddHeader(string key, string value)
        {
            this.Headers.Add(key, value);
        }

        #endregion

        #region InputStream
        /// <summary>
        /// Input stream for the request; content for the request will be read from the stream.
        /// </summary>
        [XmlElementAttribute(ElementName = "InputStream")]
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        /// <summary>
        /// Sets an input stream for the request; content for the request will be read from the stream.
        /// </summary>
        /// <param name="inputStream">InputStream property</param>
        /// <returns>this instance</returns>
        public S3Request WithInputStream(Stream inputStream)
        {
            this.inputStream = inputStream;
            return this;
        }

        /// <summary>
        /// Checks if InputStream property is set.
        /// </summary>
        /// <returns>true if InputStream property is set.</returns>
        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }

        #endregion


        #region Timeout

        /// <summary>
        /// Overrides the default HttpWebRequest timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the Timeout property of the HTTPWebRequest object used
        /// for S3 GET Object requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if you are certain that the file will not be retrieved within the default intervals
        /// specified for an HttpWebRequest.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this.timeout; }
            set
            {
                if (value > 0 || value == System.Threading.Timeout.Infinite)
                {
                    this.timeout = value;
                }
            }
        }

        /// <summary>
        /// Overrides the default HttpWebRequest timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the Timeout property of the HTTPWebRequest object used
        /// for S3 GET Object requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if you are certain that the file will not be retrieved within the default intervals
        /// specified for an HttpWebRequest.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="timeout">Timeout property</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public S3Request WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        #endregion

        #region ReadWriteTimeout

        /// <summary>
        /// Overrides the default HttpWebRequest ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the
        /// ReadWriteTimeout property of the HTTPWebRequest object
        /// used for S3 GET Object requests.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        public int ReadWriteTimeout
        {
            get { return this.readWriteTimeout; }
            set
            {
                if (value > 0 || value == System.Threading.Timeout.Infinite)
                {
                    this.readWriteTimeout = value;
                }
            }
        }

        /// <summary>
        /// Overrides the default HttpWebRequest ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property (in milliseconds) is assigned to the
        /// ReadWriteTimeout property of the HTTPWebRequest object
        /// used for S3 GET Object requests.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="readWriteTimeout">ReadWriteTimeout property</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        public S3Request WithReadWriteTimeout(int readWriteTimeout)
        {
            ReadWriteTimeout = readWriteTimeout;
            return this;
        }

        #endregion


        #region Request events

        internal event RequestEventHandler BeforeRequestEvent;

        internal S3Request WithBeforeRequestHandler(RequestEventHandler handler)
        {
            BeforeRequestEvent += handler;
            return this;
        }

        S3Request Amazon.S3.Internal.IS3RequestEvents.WithBeforeRequestHandler(RequestEventHandler handler)
        {
            return ((S3Request)this).WithBeforeRequestHandler(handler);
        }

        internal void FireBeforeRequestEvent(object sender, RequestEventArgs args)
        {
            if (BeforeRequestEvent != null)
                BeforeRequestEvent(sender, args);
        }

        void Amazon.S3.Internal.IS3RequestEvents.FireBeforeRequestEvent(object sender, RequestEventArgs args)
        {
            ((S3Request)this).FireBeforeRequestEvent(sender, args);
        }

        #endregion


        #region Internal properties

        internal string RequestDestinationBucket { get; set; }

        #endregion


        #region Metric properties

        private Guid id = Guid.NewGuid();
        internal Guid Id { get { return this.id; } }

        internal long TotalRequestTime { get; set; }
        internal long ResponseReadTime { get; set; }

        internal long ResponseProcessingTime { get; set; }
        internal long ResponseTime { get; set; }
        internal long BytesProcessed { get; set; }
        internal long PauseTime { get; set; }

        private Stopwatch stopwatch = Stopwatch.StartNew();
        internal long ElapsedTicks { get { return stopwatch.GetElapsedDateTimeTicks(); } }

        #endregion

        #region Overrides

        public override string ToString()
        {
            string contents = string.Format("S3Request: Type - {0}, ID - {1}, ResponseTime - {2}, ResponseReadTime - {3}, ResponseProcessingTime - {4}, TotalRequestTime - {5}, Bytes processed - {6}",
                this.GetType().FullName,
                this.Id,
                this.ResponseTime,
                this.ResponseReadTime,
                this.ResponseProcessingTime,
                this.TotalRequestTime,
                this.BytesProcessed);
            return contents;
        }

        #endregion

        #region Virtual methods

        internal virtual bool Expect100Continue
        {
            get { return false; }
        }

        internal virtual void OnRaiseProgressEvent(long incrementTransferred, long transferred, long total)
        {
        }

        #endregion
    }
}