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
    /// Contains the AWS-sourced fields (co-sell motion and a trimmed set of insights) returned
    /// for an opportunity in search results.
    /// </summary>
    public partial class OpportunitySearchAwsSummary
    {
        /// <summary>
        /// Gets and sets the property CosellMotion. 
        /// <para>
        /// The engagement classification for this opportunity. Read-only.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CosellMotion { get; set; }

        /// <summary>
        /// Checks to see if the CosellMotion property is set.
        /// </summary>
        internal bool IsSetCosellMotion() => this.CosellMotion != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// Curated insights returned in search results: the engagement score and quality score.
        /// </para>
        /// </summary>
        public OpportunitySearchInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Specifies whether the opportunity originated from AWS or from the partner.
        /// </para>
        /// </summary>
        public OpportunityOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;
    }
}
