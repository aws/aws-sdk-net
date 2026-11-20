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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A case study associated with a listing.
    /// </summary>
    public partial class CaseStudy
    {
        /// <summary>
        /// Gets and sets the property CaseStudyId. 
        /// <para>
        /// The unique identifier of the case study.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CaseStudyId { get; set; }

        /// <summary>
        /// Checks to see if the CaseStudyId property is set.
        /// </summary>
        internal bool IsSetCaseStudyId() => this.CaseStudyId != null;

        /// <summary>
        /// Gets and sets the property CaseStudyName. 
        /// <para>
        /// The case study name displayed to you.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string CaseStudyName { get; set; }

        /// <summary>
        /// Checks to see if the CaseStudyName property is set.
        /// </summary>
        internal bool IsSetCaseStudyName() => this.CaseStudyName != null;

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// The business challenge that the engagement addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public string Challenge { get; set; }

        /// <summary>
        /// Checks to see if the Challenge property is set.
        /// </summary>
        internal bool IsSetChallenge() => this.Challenge != null;

        /// <summary>
        /// Gets and sets the property EngagementDates. 
        /// <para>
        /// The key implementation dates for the engagement.
        /// </para>
        /// </summary>
        public EngagementDates EngagementDates { get; set; }

        /// <summary>
        /// Checks to see if the EngagementDates property is set.
        /// </summary>
        internal bool IsSetEngagementDates() => this.EngagementDates != null;

        /// <summary>
        /// Gets and sets the property ImplementationApproach. 
        /// <para>
        /// The implementation approach used for the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public string ImplementationApproach { get; set; }

        /// <summary>
        /// Checks to see if the ImplementationApproach property is set.
        /// </summary>
        internal bool IsSetImplementationApproach() => this.ImplementationApproach != null;

        /// <summary>
        /// Gets and sets the property Outcome. 
        /// <para>
        /// The results and outcomes achieved by the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 3000)]
        public string Outcome { get; set; }

        /// <summary>
        /// Checks to see if the Outcome property is set.
        /// </summary>
        internal bool IsSetOutcome() => this.Outcome != null;

        /// <summary>
        /// Gets and sets the property Resolution. 
        /// <para>
        /// How the partner resolved the challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public string Resolution { get; set; }

        /// <summary>
        /// Checks to see if the Resolution property is set.
        /// </summary>
        internal bool IsSetResolution() => this.Resolution != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Resources related to the case study.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CaseStudyResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseStudyResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A brief value proposition for the case study.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;
    }
}
