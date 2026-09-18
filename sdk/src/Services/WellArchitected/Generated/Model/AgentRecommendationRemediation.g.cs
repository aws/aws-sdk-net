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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The core fields for a remediation.
    /// </summary>
    public partial class AgentRecommendationRemediation
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the remediation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created this remediation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the remediation was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this remediation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The ARN of the recommendation that this remediation belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationArn property is set.
        /// </summary>
        internal bool IsSetRecommendationArn() => this.RecommendationArn != null;

        /// <summary>
        /// Gets and sets the property ResourceLinks. 
        /// <para>
        /// External references associated with the steps.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ResourceLink> ResourceLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceLink>() : null;

        /// <summary>
        /// Checks to see if the ResourceLinks property is set.
        /// </summary>
        internal bool IsSetResourceLinks() => this.ResourceLinks != null && (this.ResourceLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The procedural steps to perform the remediation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<RemediationStep> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<RemediationStep>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The remediation method.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RemediationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
