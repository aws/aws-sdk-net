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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the GetTemporaryGlueTableCredentials operation.
    /// </summary>
    public partial class GetTemporaryGlueTableCredentialsResponse : AmazonWebServiceResponse
    {
        private string _accessKeyId;
        private DateTime? _expiration;
        private string _secretAccessKey;
        private string _sessionToken;
        private List<string> _vendedS3Path = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID for the temporary credentials.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date and time when the temporary credentials expire.
        /// </para>
        /// </summary>
        public DateTime? Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret key for the temporary credentials.
        /// </para>
        /// </summary>
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The session token for the temporary credentials.
        /// </para>
        /// </summary>
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

        /// <summary>
        /// Gets and sets the property VendedS3Path. 
        /// <para>
        /// The Amazon S3 path for the temporary credentials.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VendedS3Path
        {
            get { return this._vendedS3Path; }
            set { this._vendedS3Path = value; }
        }

        // Check to see if VendedS3Path property is set
        internal bool IsSetVendedS3Path()
        {
            return this._vendedS3Path != null && (this._vendedS3Path.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}