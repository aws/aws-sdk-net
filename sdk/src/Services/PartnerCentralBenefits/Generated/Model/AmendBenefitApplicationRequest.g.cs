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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the AmendBenefitApplication operation. Modifies an
    /// existing benefit application by applying amendments to specific fields while maintaining
    /// revision control.
    /// </summary>
    public partial class AmendBenefitApplicationRequest : AmazonPartnerCentralBenefitsRequest
    {
        /// <summary>
        /// Gets and sets the property AmendmentReason. 
        /// <para>
        /// A descriptive reason explaining why the benefit application is being amended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string AmendmentReason { get; set; }

        /// <summary>
        /// Checks to see if the AmendmentReason property is set.
        /// </summary>
        internal bool IsSetAmendmentReason() => this.AmendmentReason != null;

        /// <summary>
        /// Gets and sets the property Amendments. 
        /// <para>
        /// A list of specific field amendments to apply to the benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Amendment> Amendments { get; set; } = AWSConfigs.InitializeCollections ? new List<Amendment>() : null;

        /// <summary>
        /// Checks to see if the Amendments property is set.
        /// </summary>
        internal bool IsSetAmendments() => this.Amendments != null && (this.Amendments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog the application belongs
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotent processing of the amendment
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the benefit application to be amended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the benefit application to ensure optimistic concurrency
        /// control.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;
    }
}
