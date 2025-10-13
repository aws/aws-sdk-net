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
    /// Container for the parameters to the CreateWorkloadIdentity operation.
    /// Creates a new workload identity.
    /// </summary>
    public partial class CreateWorkloadIdentityRequest : AmazonBedrockAgentCoreControlRequest
    {
        private List<string> _allowedResourceOauth2ReturnUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedResourceOauth2ReturnUrls. 
        /// <para>
        /// The list of allowed OAuth2 return URLs for resources associated with this workload
        /// identity.
        /// </para>
        /// </summary>
        public List<string> AllowedResourceOauth2ReturnUrls
        {
            get { return this._allowedResourceOauth2ReturnUrls; }
            set { this._allowedResourceOauth2ReturnUrls = value; }
        }

        // Check to see if AllowedResourceOauth2ReturnUrls property is set
        internal bool IsSetAllowedResourceOauth2ReturnUrls()
        {
            return this._allowedResourceOauth2ReturnUrls != null && (this._allowedResourceOauth2ReturnUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workload identity. The name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to the workload identity. Tags enable you to
        /// categorize your resources in different ways, for example, by purpose, owner, or environment.
        /// </para>
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