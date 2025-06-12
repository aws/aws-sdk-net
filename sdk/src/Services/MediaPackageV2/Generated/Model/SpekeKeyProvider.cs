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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The parameters for the SPEKE key provider.
    /// </summary>
    public partial class SpekeKeyProvider
    {
        private List<string> _drmSystems = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EncryptionContractConfiguration _encryptionContractConfiguration;
        private string _resourceId;
        private string _roleArn;
        private string _url;

        /// <summary>
        /// Gets and sets the property DrmSystems. 
        /// <para>
        /// The DRM solution provider you're using to protect your content during distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> DrmSystems
        {
            get { return this._drmSystems; }
            set { this._drmSystems = value; }
        }

        // Check to see if DrmSystems property is set
        internal bool IsSetDrmSystems()
        {
            return this._drmSystems != null && (this._drmSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncryptionContractConfiguration. 
        /// <para>
        /// Configure one or more content encryption keys for your endpoints that use SPEKE Version
        /// 2.0. The encryption contract defines which content keys are used to encrypt the audio
        /// and video tracks in your stream. To configure the encryption contract, specify which
        /// audio and video encryption presets to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionContractConfiguration EncryptionContractConfiguration
        {
            get { return this._encryptionContractConfiguration; }
            set { this._encryptionContractConfiguration = value; }
        }

        // Check to see if EncryptionContractConfiguration property is set
        internal bool IsSetEncryptionContractConfiguration()
        {
            return this._encryptionContractConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for the content. The service sends this to the key server to
        /// identify the current endpoint. How unique you make this depends on how fine-grained
        /// you want access controls to be. The service does not permit you to use the same ID
        /// for two simultaneous encryption processes. The resource ID is also known as the content
        /// ID.
        /// </para>
        ///  
        /// <para>
        /// The following example shows a resource ID: <c>MovieNight20171126093045</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN for the IAM role granted by the key provider that provides access to the key
        /// provider API. This role must have a trust policy that allows MediaPackage to assume
        /// the role, and it must have a sufficient permissions policy to allow access to the
        /// specific key retrieval URL. Get this from your DRM solution provider.
        /// </para>
        ///  
        /// <para>
        /// Valid format: <c>arn:aws:iam::{accountID}:role/{name}</c>. The following example shows
        /// a role ARN: <c>arn:aws:iam::444455556666:role/SpekeAccess</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the API Gateway proxy that you set up to talk to your key server. The API
        /// Gateway proxy must reside in the same AWS Region as MediaPackage and must start with
        /// https://.
        /// </para>
        ///  
        /// <para>
        /// The following example shows a URL: <c>https://1wm2dx1f33.execute-api.us-west-2.amazonaws.com/SpekeSample/copyProtection</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}