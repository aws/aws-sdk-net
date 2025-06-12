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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the GetSecretValue operation.
    /// </summary>
    public partial class GetSecretValueResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdDate;
        private string _name;
        private MemoryStream _secretBinary;
        private string _secretString;
        private string _versionId;
        private List<string> _versionStages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that this version of the secret was created. If you don't specify
        /// which version in <c>VersionId</c> or <c>VersionStage</c>, then Secrets Manager uses
        /// the <c>AWSCURRENT</c> version.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SecretBinary. 
        /// <para>
        /// The decrypted secret value, if the secret value was originally provided as binary
        /// data in the form of a byte array. When you retrieve a <c>SecretBinary</c> using the
        /// HTTP API, the Python SDK, or the Amazon Web Services CLI, the value is Base64-encoded.
        /// Otherwise, it is not encoded.
        /// </para>
        ///  
        /// <para>
        /// If the secret was created by using the Secrets Manager console, or if the secret value
        /// was originally provided as a string, then this field is omitted. The secret value
        /// appears in <c>SecretString</c> instead.
        /// </para>
        ///  
        /// <para>
        /// Sensitive: This field contains sensitive information, so the service does not include
        /// it in CloudTrail log entries. If you create your own log entries, you must also avoid
        /// logging the information in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public MemoryStream SecretBinary
        {
            get { return this._secretBinary; }
            set { this._secretBinary = value; }
        }

        // Check to see if SecretBinary property is set
        internal bool IsSetSecretBinary()
        {
            return this._secretBinary != null;
        }

        /// <summary>
        /// Gets and sets the property SecretString. 
        /// <para>
        /// The decrypted secret value, if the secret value was originally provided as a string
        /// or through the Secrets Manager console.
        /// </para>
        ///  
        /// <para>
        /// If this secret was created by using the console, then Secrets Manager stores the information
        /// as a JSON structure of key/value pairs. 
        /// </para>
        ///  
        /// <para>
        /// Sensitive: This field contains sensitive information, so the service does not include
        /// it in CloudTrail log entries. If you create your own log entries, you must also avoid
        /// logging the information in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=65536)]
        public string SecretString
        {
            get { return this._secretString; }
            set { this._secretString = value; }
        }

        // Check to see if SecretString property is set
        internal bool IsSetSecretString()
        {
            return this._secretString != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The unique identifier of this version of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionStages. 
        /// <para>
        /// A list of all of the staging labels currently attached to this version of the secret.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> VersionStages
        {
            get { return this._versionStages; }
            set { this._versionStages = value; }
        }

        // Check to see if VersionStages property is set
        internal bool IsSetVersionStages()
        {
            return this._versionStages != null && (this._versionStages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}