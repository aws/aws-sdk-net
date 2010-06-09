/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Net;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Amazon.S3.Model
{
    using Map = System.Collections.Generic.IDictionary<Amazon.S3.Model.S3QueryParameter, string>;

    /// <summary>
    /// Base class for all S3 operation requests.
    /// Provides a header collection which can is used to store the request headers.
    /// </summary>
    public class S3Request
    {
        #region Private Members

        private WebHeaderCollection headers;
        private Stream inputStream;

        // Most requests have less than 10 parameters, so 10 is a safe starting capacity
        // This way, the Map.Add operation will be an O(1) operation
        internal Map parameters = new Dictionary<S3QueryParameter, string>(10);

        // The maximum number of headers removed from an S3 Request is 
        // just 1 - If-Modified-Since. No need to allocate capacity
        // for 1 item if that's the most there will ever be.
        internal NameValueCollection removedHeaders = new NameValueCollection();

        #endregion

        #region Headers

        /// <summary>
        /// Gets the Headers property.
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
        /// Checks if Headers property is set
        /// </summary>
        /// <returns>true if Headers property is set</returns>
        internal bool IsSetHeaders()
        {
            return (this.headers != null && 
                this.headers.Count > 0);
        }

        /// <summary>
        /// Adds all of the key/value pairs from collection into our request header.
        /// </summary>
        /// <param name="collection">A collection of key/value headers</param>
        public void AddHeaders(NameValueCollection collection)
        {
            this.Headers.Add(collection);
        }

        #endregion

        # region InputStream
        /// <summary>
        /// Gets and sets the InputStream property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InputStream")]
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        /// <summary>
        /// Sets the InputStream property.
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
    }
}