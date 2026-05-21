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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetPaymentCredentialProvider operation.
    /// </summary>
    public partial class GetPaymentCredentialProviderResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTime;
        private string _credentialProviderArn;
        private PaymentCredentialProviderVendorType _credentialProviderVendor;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private PaymentProviderConfigurationOutput _providerConfigurationOutput;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the payment credential provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CredentialProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the payment credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialProviderArn
        {
            get { return this._credentialProviderArn; }
            set { this._credentialProviderArn = value; }
        }

        // Check to see if CredentialProviderArn property is set
        internal bool IsSetCredentialProviderArn()
        {
            return this._credentialProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialProviderVendor. 
        /// <para>
        /// The vendor type for the payment credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentCredentialProviderVendorType CredentialProviderVendor
        {
            get { return this._credentialProviderVendor; }
            set { this._credentialProviderVendor = value; }
        }

        // Check to see if CredentialProviderVendor property is set
        internal bool IsSetCredentialProviderVendor()
        {
            return this._credentialProviderVendor != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the payment credential provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the payment credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ProviderConfigurationOutput. 
        /// <para>
        /// Output configuration (contains secret ARNs, excludes actual secret values).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentProviderConfigurationOutput ProviderConfigurationOutput
        {
            get { return this._providerConfigurationOutput; }
            set { this._providerConfigurationOutput = value; }
        }

        // Check to see if ProviderConfigurationOutput property is set
        internal bool IsSetProviderConfigurationOutput()
        {
            return this._providerConfigurationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the payment credential provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

    }
}