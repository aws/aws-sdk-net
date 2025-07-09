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

/*
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetUploadJobPath operation.
    /// </summary>
    public partial class GetUploadJobPathResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private string _url;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The plaintext data key used to encrypt the upload file. 
        /// </para>
        ///  
        /// <para>
        /// To persist to the pre-signed url, use the client token and MD5 client token as header.
        /// The required headers are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side-encryption-customer-key: Client Token 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-customer-key-MD5: MD5 Client Token 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-customer-algorithm: AES256 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The pre-signed S3 URL for uploading the CSV file associated with the upload job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The expiry timestamp for the pre-signed URL, after which the URL will no longer be
        /// valid. 
        /// </para>
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this._validUntil; }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}