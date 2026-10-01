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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The basic information of the flow exluding its definition specifying the steps.
    /// </summary>
    public partial class FlowSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the principal who created the flow.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time this flow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowId { get; set; }

        /// <summary>
        /// Checks to see if the FlowId property is set.
        /// </summary>
        internal bool IsSetFlowId() => this.FlowId != null;

        /// <summary>
        /// Gets and sets the property LastPublishedAt. 
        /// <para>
        /// The last time this flow was published.
        /// </para>
        /// </summary>
        public DateTime? LastPublishedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastPublishedAt property is set.
        /// </summary>
        internal bool IsSetLastPublishedAt() => this.LastPublishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastPublishedBy. 
        /// <para>
        /// The identifier of the last principal who published the flow.
        /// </para>
        /// </summary>
        public string LastPublishedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastPublishedBy property is set.
        /// </summary>
        internal bool IsSetLastPublishedBy() => this.LastPublishedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The identifier of the last principal who updated the flow.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time this flow was modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublishState. 
        /// <para>
        /// The publish state for the flow. The valid values are <c>DRAFT</c>, <c>PUBLISHED</c>,
        /// or <c>PENDING_APPROVAL</c>.
        /// </para>
        /// </summary>
        public FlowPublishState PublishState { get; set; }

        /// <summary>
        /// Checks to see if the PublishState property is set.
        /// </summary>
        internal bool IsSetPublishState() => this.PublishState != null;

        /// <summary>
        /// Gets and sets the property RunCount. 
        /// <para>
        /// The number of runs done for the flow.
        /// </para>
        /// </summary>
        public int? RunCount { get; set; }

        /// <summary>
        /// Checks to see if the RunCount property is set.
        /// </summary>
        internal bool IsSetRunCount() => this.RunCount.HasValue;

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users who have used the flow.
        /// </para>
        /// </summary>
        public int? UserCount { get; set; }

        /// <summary>
        /// Checks to see if the UserCount property is set.
        /// </summary>
        internal bool IsSetUserCount() => this.UserCount.HasValue;
    }
}
