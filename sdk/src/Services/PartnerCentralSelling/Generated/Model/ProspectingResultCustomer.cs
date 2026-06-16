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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private string _accountName;
        private string _companySize;
        private CountryCode _country;
        private List<string> _eligiblePrograms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _geo;
        private Industry _industry;
        private string _publicProfileSummary;
        private string _region;
        private string _segment;
        private string _subIndustry;
        private string _subRegion;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property CompanySize. 
        /// <para>
        /// The company size classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string CompanySize
        {
            get { return this._companySize; }
            set { this._companySize = value; }
        }

        // Check to see if CompanySize property is set
        internal bool IsSetCompanySize()
        {
            return this._companySize != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country code of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public CountryCode Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property EligiblePrograms. 
        /// <para>
        /// A list of AWS Greenfield programs that the prospected customer is eligible for. Use
        /// this list to identify relevant go-to-market opportunities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EligiblePrograms
        {
            get { return this._eligiblePrograms; }
            set { this._eligiblePrograms = value; }
        }

        // Check to see if EligiblePrograms property is set
        internal bool IsSetEligiblePrograms()
        {
            return this._eligiblePrograms != null && (this._eligiblePrograms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Geo. 
        /// <para>
        /// The geographic region classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Geo
        {
            get { return this._geo; }
            set { this._geo = value; }
        }

        // Check to see if Geo property is set
        internal bool IsSetGeo()
        {
            return this._geo != null;
        }

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry classification of the prospected customer account.
        /// </para>
        /// </summary>
        public Industry Industry
        {
            get { return this._industry; }
            set { this._industry = value; }
        }

        // Check to see if Industry property is set
        internal bool IsSetIndustry()
        {
            return this._industry != null;
        }

        /// <summary>
        /// Gets and sets the property PublicProfileSummary. 
        /// <para>
        /// A summary of publicly available information about the prospected customer. The system
        /// uses this summary to generate customer insights and inform engagement strategies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5000)]
        public string PublicProfileSummary
        {
            get { return this._publicProfileSummary; }
            set { this._publicProfileSummary = value; }
        }

        // Check to see if PublicProfileSummary property is set
        internal bool IsSetPublicProfileSummary()
        {
            return this._publicProfileSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The specific region of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The market segment classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property SubIndustry. 
        /// <para>
        /// The sub-industry classification of the prospected customer account. This provides
        /// more granular categorization within the primary industry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SubIndustry
        {
            get { return this._subIndustry; }
            set { this._subIndustry = value; }
        }

        // Check to see if SubIndustry property is set
        internal bool IsSetSubIndustry()
        {
            return this._subIndustry != null;
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The subregion classification of the prospected customer account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SubRegion
        {
            get { return this._subRegion; }
            set { this._subRegion = value; }
        }

        // Check to see if SubRegion property is set
        internal bool IsSetSubRegion()
        {
            return this._subRegion != null;
        }

    }
}