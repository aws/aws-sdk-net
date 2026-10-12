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
    /// Contains detailed information about the prospected customer account, including company
    /// identifiers, geographic classification, industry segmentation, and program eligibility.
    /// </summary>
    public partial class ProspectingResultCustomer
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property CompanySize. 
        /// <para>
        /// The company size classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string CompanySize { get; set; }

        /// <summary>
        /// Checks to see if the CompanySize property is set.
        /// </summary>
        internal bool IsSetCompanySize() => this.CompanySize != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country code of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CountryCode Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property EligiblePrograms. 
        /// <para>
        /// A list of AWS Greenfield programs that the prospected customer is eligible for. Use
        /// this list to identify relevant go-to-market opportunities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EligiblePrograms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EligiblePrograms property is set.
        /// </summary>
        internal bool IsSetEligiblePrograms() => this.EligiblePrograms != null && (this.EligiblePrograms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Geo. 
        /// <para>
        /// The geographic region classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Geo { get; set; }

        /// <summary>
        /// Checks to see if the Geo property is set.
        /// </summary>
        internal bool IsSetGeo() => this.Geo != null;

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry classification of the prospected customer account.
        /// </para>
        /// </summary>
        public Industry Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property PublicProfileSummary. 
        /// <para>
        /// A summary of publicly available information about the prospected customer. The system
        /// uses this summary to generate customer insights and inform engagement strategies.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 5000)]
        public string PublicProfileSummary { get; set; }

        /// <summary>
        /// Checks to see if the PublicProfileSummary property is set.
        /// </summary>
        internal bool IsSetPublicProfileSummary() => this.PublicProfileSummary != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The specific region of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The market segment classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Segment { get; set; }

        /// <summary>
        /// Checks to see if the Segment property is set.
        /// </summary>
        internal bool IsSetSegment() => this.Segment != null;

        /// <summary>
        /// Gets and sets the property SubIndustry. 
        /// <para>
        /// The sub-industry classification of the prospected customer account. This provides
        /// more granular categorization within the primary industry.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string SubIndustry { get; set; }

        /// <summary>
        /// Checks to see if the SubIndustry property is set.
        /// </summary>
        internal bool IsSetSubIndustry() => this.SubIndustry != null;

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The subregion classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string SubRegion { get; set; }

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null;
    }
}
