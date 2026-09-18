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
    /// Represents a code review configuration that defines the parameters for automated security-focused
    /// code analysis, including target assets and logging configuration.
    /// </summary>
    public partial class CodeReview
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets included in the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null;

        /// <summary>
        /// Gets and sets the property CodeRemediationStrategy. 
        /// <para>
        /// The code remediation strategy for the code review.
        /// </para>
        /// </summary>
        public CodeRemediationStrategy CodeRemediationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the CodeRemediationStrategy property is set.
        /// </summary>
        internal bool IsSetCodeRemediationStrategy() => this.CodeRemediationStrategy != null;

        /// <summary>
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CodeReviewId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewId property is set.
        /// </summary>
        internal bool IsSetCodeReviewId() => this.CodeReviewId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the code review was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the code review.
        /// </para>
        /// </summary>
        public CloudWatchLog LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property MaxTaskHours. 
        /// <para>
        /// The maximum number of billable task hours allowed for jobs started from this code
        /// review. If a job reaches the configured limit, it is gracefully stopped. If not set,
        /// jobs run to completion with no budget cap.
        /// </para>
        /// </summary>
        public double? MaxTaskHours { get; set; }

        /// <summary>
        /// Checks to see if the MaxTaskHours property is set.
        /// </summary>
        internal bool IsSetMaxTaskHours() => this.MaxTaskHours.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role used for the code review.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the code review was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationMode. 
        /// <para>
        /// The validation mode for the code review. Valid values are SIMULATED and DISABLED.
        /// </para>
        /// </summary>
        public ValidationMode ValidationMode { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMode property is set.
        /// </summary>
        internal bool IsSetValidationMode() => this.ValidationMode != null;
    }
}
