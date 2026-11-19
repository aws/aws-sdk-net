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
    /// Recorded facts about the matched customer for an account in search results. It carries
    /// the fields that you can filter and group by.
    /// </summary>
    public partial class AwsEnrichmentCustomerSummary
    {
        /// <summary>
        /// Gets and sets the property AccountPlanningQualification. 
        /// <para>
        /// Indicates whether the customer qualifies for account planning with AWS.
        /// </para>
        /// </summary>
        public string AccountPlanningQualification { get; set; }

        /// <summary>
        /// Checks to see if the AccountPlanningQualification property is set.
        /// </summary>
        internal bool IsSetAccountPlanningQualification() => this.AccountPlanningQualification != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of the customer.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property EligiblePrograms. 
        /// <para>
        /// The AWS programs that the customer is eligible for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> EligiblePrograms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EligiblePrograms property is set.
        /// </summary>
        internal bool IsSetEligiblePrograms() => this.EligiblePrograms != null && (this.EligiblePrograms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Geo. 
        /// <para>
        /// The geographic area of the customer, as classified by AWS.
        /// </para>
        /// </summary>
        public string Geo { get; set; }

        /// <summary>
        /// Checks to see if the Geo property is set.
        /// </summary>
        internal bool IsSetGeo() => this.Geo != null;

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry of the customer, as classified by AWS.
        /// </para>
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The market segment of the customer, as classified by AWS.
        /// </para>
        /// </summary>
        public string Segment { get; set; }

        /// <summary>
        /// Checks to see if the Segment property is set.
        /// </summary>
        internal bool IsSetSegment() => this.Segment != null;
    }
}
