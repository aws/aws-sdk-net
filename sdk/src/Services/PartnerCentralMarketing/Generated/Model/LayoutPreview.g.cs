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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// A rendering of an AWS-authored layout skeleton or placeholder image. The url is a
    /// stable, cache-friendly CloudFront URL rather than a presigned GET, because the bytes
    /// are AWS marketing content that is already public. The key's random segment is the
    /// object's only protection, so the URL is a bearer credential for the object and is
    /// withheld entirely while a template is not yet effective — see CampaignTemplate.EffectiveDateBegin.
    /// </summary>
    public partial class LayoutPreview
    {
        /// <summary>
        /// Gets and sets the property Format. The format of the referenced object.
        /// </summary>
        [AWSProperty(Required = true)]
        public LayoutFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property PageType. Which page of a multi-page layout this is. Present
        /// only for LANDING_PAGE, which genuinely has two layout objects — the page carrying
        /// the form, and the confirmation page shown after submit — and absent for every other
        /// category, which has one. A confirmation page is a second LAYOUT, never a second asset:
        /// modelling it as its own asset would give it a lifecycle, an activation and a state
        /// it does not have.
        /// </summary>
        public LayoutPageType PageType { get; set; }

        /// <summary>
        /// Checks to see if the PageType property is set.
        /// </summary>
        internal bool IsSetPageType() => this.PageType != null;

        /// <summary>
        /// Gets and sets the property Url. A stable URL serving the object. Not presigned, so
        /// it does not expire.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
