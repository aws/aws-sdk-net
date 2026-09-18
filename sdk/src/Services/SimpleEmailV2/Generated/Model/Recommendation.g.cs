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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A recommendation generated for your account.
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The first time this issue was encountered and the recommendation was generated.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The recommendation description / disambiguator - e.g. <c>DKIM1</c> and <c>DKIM2</c>
        /// are different recommendations about your DKIM setup.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The recommendation impact, with values like <c>HIGH</c> or <c>LOW</c>.
        /// </para>
        /// </summary>
        public RecommendationImpact Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The last time the recommendation was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource affected by the recommendation, with values like <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The recommendation status, with values like <c>OPEN</c> or <c>FIXED</c>.
        /// </para>
        /// </summary>
        public RecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The recommendation type, with values like <c>DKIM</c>, <c>SPF</c>, <c>DMARC</c>, <c>BIMI</c>,
        /// or <c>COMPLAINT</c>.
        /// </para>
        /// </summary>
        public RecommendationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
