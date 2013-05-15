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
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for all S3 operation responses. 
    /// Provides a header collection which is used to store the response headers.
    /// Also exposes the RequestId and AmazonId2 from S3 responses, as well as a 
    /// Response Stream is the operation returned a stream. 
    /// Lastly, if the response contained metadata, they are stored in the Metadata
    /// collection.
    /// </summary>
    public class S3Response : IDisposable
    {
        #region Private Members

        /// <summary>
        /// web headers for all requests.
        /// </summary>
        private WebHeaderCollection webHeaders;
        private NameValueCollection metadata;
        private Stream responseStream;
        internal HttpWebResponse httpResponse;
        private bool disposed;
        private string requestId;
        private string amazonId2;
        private string responseXml;

        #endregion

        #region Dispose Pattern

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            if (!this.disposed)
            {
                GC.SuppressFinalize(this);
            }
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //Remove Managed Resources
                    if (webHeaders != null)
                    {
                        webHeaders.Clear();
                    }
                }

                // Remove Unmanaged Resources
                // I.O.W. remove resources that have to be explicitly
                // "Dispose"d or Closed. For an S3 Response, these are:
                // 1. The Response Stream for GET Object requests
                // 2. The HttpResponse object for GET Object requests
                if (responseStream != null)
                {
                    responseStream.Close();
                    responseStream = null;
                }

                if (httpResponse != null)
                {
                    httpResponse.Close();
                    httpResponse = null;
                }
                disposed = true;
            }
        }

        /// <summary>
        /// The destructor for the S3Response class.
        /// </summary>
        ~S3Response()
        {
            Dispose(false);
        }

        #endregion

        #region RequestId

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        #endregion

        #region AmazonId2

        /// <summary>
        /// Gets and sets the AmazonId2 property. 
        /// This property corresponds to the x-amz-id-2 header in the HTTP response from the Amazon S3 service. The value of this header is used for internal troubleshooting purposes.
        /// </summary>
        [XmlElementAttribute(ElementName = "AmazonId2")]
        public string AmazonId2
        {
            get { return this.amazonId2; }
            set { this.amazonId2 = value; }
        }

        #endregion

        #region ResponseStream

        /// <summary>
        /// Gets and sets the ResponseStream property. This property
        /// only has a valid value for GetObjectResponses. In order to
        /// use this stream without leaking the underlying resource, please
        /// wrap access to the stream within a using block.
        /// <code></code>
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseStream")]
        public Stream ResponseStream
        {
            get { return this.responseStream; }
            set { this.responseStream = value; }
        }

        #endregion

        #region Headers

        /// <summary>
        /// Gets and sets the Headers property.
        /// Information like the request-id, the amz-id-2 are
        /// retrieved fro the Headers and presented to the user
        /// via properties of the response object.
        /// </summary>
        [XmlIgnore]
        public virtual WebHeaderCollection Headers
        {
            get
            {
                if (this.webHeaders == null)
                {
                    this.webHeaders = new WebHeaderCollection();
                }
                return this.webHeaders;
            }
            set
            {
                this.webHeaders = value;

                string hdr;
                if (!String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzRequestIdHeader)))
                {
                    RequestId = hdr;
                }
                if (!String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzId2Header)))
                {
                    AmazonId2 = hdr;
                }
                foreach (string key in value.Keys)
                {
                    if (key.StartsWith("x-amz-meta-"))
                    {
                        Metadata.Add(key, value.Get(key));
                    }
                }
            }
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Gets and sets the Metadata property.
        /// </summary>
        [XmlIgnore]
        public NameValueCollection Metadata
        {
            get
            {
                if (this.metadata == null)
                {
                    this.metadata = new NameValueCollection();
                }
                return this.metadata;
            }
        }

        #endregion

        #region ResponseXml

        /// <summary>
        /// Gets and sets the ResponseXml property. This is the 
        /// original xml response received from S3
        /// </summary>
        [XmlIgnore]
        public string ResponseXml
        {
            get { return this.responseXml; }
            set { this.responseXml = value; }
        }

        #endregion

        #region StatusCode

        /// <summary>
        /// Gets the HTTP Status code from the service response.
        /// </summary>
        [XmlIgnore]
        public HttpStatusCode StatusCode
        {
            get { return this.httpResponse.StatusCode; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            StringBuilder xml = new StringBuilder(1024);
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        #endregion

        #region ProcessResponseBody
        /// <summary>
        /// A blank virtual method to allow sub classes to provide
        /// custom response body parsing.
        /// </summary>
        /// <param name="responseBody">The response from a request to S3</param>
        internal virtual void ProcessResponseBody(string responseBody)
        {
        }
        #endregion
    }
}