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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstance operation.
    /// Enables you to programmatically create an Amazon Web Services Supply Chain instance
    /// by applying KMS keys and relevant information associated with the API without using
    /// the Amazon Web Services console.
    /// 
    ///  
    /// <para>
    /// This is an asynchronous operation. Upon receiving a CreateInstance request, Amazon
    /// Web Services Supply Chain immediately returns the instance resource, instance ID,
    /// and the initializing state while simultaneously creating all required Amazon Web Services
    /// resources for an instance creation. You can use GetInstance to check the status of
    /// the instance. If the instance results in an unhealthy state, you need to check the
    /// error message, delete the current instance, and recreate a new one based on the mitigation
    /// from the error message.
    /// </para>
    /// </summary>
    public partial class CreateInstanceRequest : AmazonSupplyChainRequest
    {
        private string _clientToken;
        private string _instanceDescription;
        private string _instanceName;
        private string _kmsKeyArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _webAppDnsDomain;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token for idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=126)]
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
        /// Gets and sets the property InstanceDescription. 
        /// <para>
        /// The AWS Supply Chain instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=501)]
        public string InstanceDescription
        {
            get { return this._instanceDescription; }
            set { this._instanceDescription = value; }
        }

        // Check to see if InstanceDescription property is set
        internal bool IsSetInstanceDescription()
        {
            return this._instanceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The AWS Supply Chain instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide
        /// for encryption. This is required if you do not want to use the Amazon Web Services
        /// owned KMS key. If you don't provide anything here, AWS Supply Chain uses the Amazon
        /// Web Services owned KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Amazon Web Services tags of an instance to be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebAppDnsDomain. 
        /// <para>
        /// The DNS subdomain of the web app. This would be "example" in the URL "example.scn.global.on.aws".
        /// You can set this to a custom value, as long as the domain isn't already being used
        /// by someone else. The name may only include alphanumeric characters and hyphens.
        /// </para>
        /// </summary>
        public string WebAppDnsDomain
        {
            get { return this._webAppDnsDomain; }
            set { this._webAppDnsDomain = value; }
        }

        // Check to see if WebAppDnsDomain property is set
        internal bool IsSetWebAppDnsDomain()
        {
            return this._webAppDnsDomain != null;
        }

    }
}