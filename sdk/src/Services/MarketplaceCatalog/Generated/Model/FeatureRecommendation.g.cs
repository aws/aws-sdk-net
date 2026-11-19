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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A recommended AWS Marketplace feature for a listing.
    /// </summary>
    public partial class FeatureRecommendation
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// What you should do. It might contain a link to the console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property FeatureId. 
        /// <para>
        /// The feature that is recommended. Valid values are <c>REQUEST_PRIVATE_OFFER</c>, <c>REQUEST_A_DEMO</c>,
        /// <c>PROMOTIONAL_MEDIA</c>, <c>FREE_TRIAL</c>, and <c>QUICK_LAUNCH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendedFeatureId FeatureId { get; set; }

        /// <summary>
        /// Checks to see if the FeatureId property is set.
        /// </summary>
        internal bool IsSetFeatureId() => this.FeatureId != null;

        /// <summary>
        /// Gets and sets the property Rationale. 
        /// <para>
        /// Why the feature is recommended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Rationale { get; set; }

        /// <summary>
        /// Checks to see if the Rationale property is set.
        /// </summary>
        internal bool IsSetRationale() => this.Rationale != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// How much the recommendation blocks the listing. Valid values are <c>BLOCKING</c> and
        /// <c>ADVISORY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether the listing has the feature. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PASS</c> - The listing already has the feature.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAIL</c> - The feature is one to turn on.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendedFeatureStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
