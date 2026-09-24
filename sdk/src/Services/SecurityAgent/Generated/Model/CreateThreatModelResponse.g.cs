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
    /// This is the response object from the CreateThreatModel operation.
    /// </summary>
    public partial class CreateThreatModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the threat model.
        /// </para>
        /// </summary>
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets included in the threat model.
        /// </para>
        /// </summary>
        public Assets Assets { get; set; }

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the threat model was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the application or system being threat modeled.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the threat model.
        /// </para>
        /// </summary>
        public CloudWatchLog LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property ReportDestination. 
        /// <para>
        /// The destination for publishing scan reports to an integrated document provider.
        /// </para>
        /// </summary>
        public ReportDestination ReportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ReportDestination property is set.
        /// </summary>
        internal bool IsSetReportDestination() => this.ReportDestination != null;

        /// <summary>
        /// Gets and sets the property ScopeDocs. 
        /// <para>
        /// The scoped documents for the agent to focus on during threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> ScopeDocs { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;

        /// <summary>
        /// Checks to see if the ScopeDocs property is set.
        /// </summary>
        internal bool IsSetScopeDocs() => this.ScopeDocs != null && (this.ScopeDocs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role used for the threat model.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property ThreatModelId. 
        /// <para>
        /// The unique identifier of the created threat model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ThreatModelId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatModelId property is set.
        /// </summary>
        internal bool IsSetThreatModelId() => this.ThreatModelId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the threat model.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the threat model was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
