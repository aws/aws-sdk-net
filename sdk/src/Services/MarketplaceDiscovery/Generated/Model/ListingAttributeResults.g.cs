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
    /// An attribute associated with a listing. Each entry contains one attribute type.
    /// </summary>
    public partial class ListingAttributeResults
    {
        /// <summary>
        /// Gets and sets the property CaseStudy. 
        /// <para>
        /// A case study associated with the listing.
        /// </para>
        /// </summary>
        public CaseStudy CaseStudy { get; set; }

        /// <summary>
        /// Checks to see if the CaseStudy property is set.
        /// </summary>
        internal bool IsSetCaseStudy() => this.CaseStudy != null;

        /// <summary>
        /// Gets and sets the property SpecializationDetail. 
        /// <para>
        /// A specialization earned for the listing. Each result is either a specialization or
        /// a category under a specialization.
        /// </para>
        /// </summary>
        public SpecializationDetail SpecializationDetail { get; set; }

        /// <summary>
        /// Checks to see if the SpecializationDetail property is set.
        /// </summary>
        internal bool IsSetSpecializationDetail() => this.SpecializationDetail != null;

        /// <summary>
        /// Gets and sets the property TrustCenterCertification. 
        /// <para>
        /// A trust center certification associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterCertificationAttribute TrustCenterCertification { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterCertification property is set.
        /// </summary>
        internal bool IsSetTrustCenterCertification() => this.TrustCenterCertification != null;

        /// <summary>
        /// Gets and sets the property TrustCenterControl. 
        /// <para>
        /// A trust center control associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterControl TrustCenterControl { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterControl property is set.
        /// </summary>
        internal bool IsSetTrustCenterControl() => this.TrustCenterControl != null;

        /// <summary>
        /// Gets and sets the property TrustCenterDocument. 
        /// <para>
        /// A trust center document associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterDocumentAttribute TrustCenterDocument { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterDocument property is set.
        /// </summary>
        internal bool IsSetTrustCenterDocument() => this.TrustCenterDocument != null;

        /// <summary>
        /// Gets and sets the property TrustCenterFaq. 
        /// <para>
        /// A trust center frequently asked question associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterFaqAttribute TrustCenterFaq { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterFaq property is set.
        /// </summary>
        internal bool IsSetTrustCenterFaq() => this.TrustCenterFaq != null;

        /// <summary>
        /// Gets and sets the property TrustCenterSource. 
        /// <para>
        /// A trust center source associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterSource TrustCenterSource { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterSource property is set.
        /// </summary>
        internal bool IsSetTrustCenterSource() => this.TrustCenterSource != null;

        /// <summary>
        /// Gets and sets the property TrustCenterUpdate. 
        /// <para>
        /// A trust center update associated with the listing.
        /// </para>
        /// </summary>
        public TrustCenterUpdateAttribute TrustCenterUpdate { get; set; }

        /// <summary>
        /// Checks to see if the TrustCenterUpdate property is set.
        /// </summary>
        internal bool IsSetTrustCenterUpdate() => this.TrustCenterUpdate != null;
    }
}
