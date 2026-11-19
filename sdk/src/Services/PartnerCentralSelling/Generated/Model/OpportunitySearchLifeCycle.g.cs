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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Contains the lifecycle fields (review status, stage, next steps, and target close
    /// date) returned for an opportunity in search results.
    /// </summary>
    public partial class OpportunitySearchLifeCycle
    {
        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        /// The next steps for the opportunity. Mandatory for co-sell opportunities.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string NextSteps { get; set; }

        /// <summary>
        /// Checks to see if the NextSteps property is set.
        /// </summary>
        internal bool IsSetNextSteps() => this.NextSteps != null;

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        /// The approval status of the opportunity.
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReviewStatus property is set.
        /// </summary>
        internal bool IsSetReviewStatus() => this.ReviewStatus != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the opportunity.
        /// </para>
        /// </summary>
        public Stage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property TargetCloseDate. 
        /// <para>
        /// The projected launch date of the opportunity, in ISO 8601 (YYYY-MM-DD) format.
        /// </para>
        /// </summary>
        public string TargetCloseDate { get; set; }

        /// <summary>
        /// Checks to see if the TargetCloseDate property is set.
        /// </summary>
        internal bool IsSetTargetCloseDate() => this.TargetCloseDate != null;
    }
}
