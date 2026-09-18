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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateAgentSpace operation. Updates the configuration
    /// of an existing agent space, including its name, description, AWS resources, target
    /// domains, and code review settings.
    /// </summary>
    public partial class UpdateAgentSpaceRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AwsResources. 
        /// <para>
        /// The updated AWS resources to associate with the agent space.
        /// </para>
        /// </summary>
        public AWSResources AwsResources { get; set; }

        /// <summary>
        /// Checks to see if the AwsResources property is set.
        /// </summary>
        internal bool IsSetAwsResources() => this.AwsResources != null;

        /// <summary>
        /// Gets and sets the property CodeReviewSettings. 
        /// <para>
        /// The updated code review settings for the agent space.
        /// </para>
        /// </summary>
        public CodeReviewSettings CodeReviewSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewSettings property is set.
        /// </summary>
        internal bool IsSetCodeReviewSettings() => this.CodeReviewSettings != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the agent space.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the agent space.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TargetDomainIds. 
        /// <para>
        /// The updated list of target domain identifiers to associate with the agent space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetDomainIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetDomainIds property is set.
        /// </summary>
        internal bool IsSetTargetDomainIds() => this.TargetDomainIds != null && (this.TargetDomainIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
