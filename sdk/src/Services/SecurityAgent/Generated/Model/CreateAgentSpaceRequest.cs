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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAgentSpace operation.
    /// Creates a new agent space. An agent space is a dedicated workspace for securing a
    /// specific application.
    /// </summary>
    public partial class CreateAgentSpaceRequest : AmazonSecurityAgentRequest
    {
        private AWSResources _awsResources;
        private CodeReviewSettings _codeReviewSettings;
        private string _description;
        private string _kmsKeyId;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _targetDomainIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AwsResources. 
        /// <para>
        /// The AWS resources to associate with the agent space.
        /// </para>
        /// </summary>
        public AWSResources AwsResources
        {
            get { return this._awsResources; }
            set { this._awsResources = value; }
        }

        // Check to see if AwsResources property is set
        internal bool IsSetAwsResources()
        {
            return this._awsResources != null;
        }

        /// <summary>
        /// Gets and sets the property CodeReviewSettings. 
        /// <para>
        /// The code review settings for the agent space.
        /// </para>
        /// </summary>
        public CodeReviewSettings CodeReviewSettings
        {
            get { return this._codeReviewSettings; }
            set { this._codeReviewSettings = value; }
        }

        // Check to see if CodeReviewSettings property is set
        internal bool IsSetCodeReviewSettings()
        {
            return this._codeReviewSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the agent space.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS KMS key to use for encrypting data in the agent space.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The tags to associate with the agent space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property TargetDomainIds. 
        /// <para>
        /// The list of target domain identifiers to associate with the agent space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetDomainIds
        {
            get { return this._targetDomainIds; }
            set { this._targetDomainIds = value; }
        }

        // Check to see if TargetDomainIds property is set
        internal bool IsSetTargetDomainIds()
        {
            return this._targetDomainIds != null && (this._targetDomainIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}