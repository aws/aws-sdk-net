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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// This is the response object from the GetQualificationsAssociationDetails operation.
    /// </summary>
    public partial class GetQualificationsAssociationDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies your partner resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedPartners. 
        /// <para>
        /// The list of all partner profile and account identifiers currently associated under
        /// the primary partner. This field is null when the status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 6)]
        public List<QualificationsAssociationPartner> AssociatedPartners { get; set; } = AWSConfigs.InitializeCollections ? new List<QualificationsAssociationPartner>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPartners property is set.
        /// </summary>
        internal bool IsSetAssociatedPartners() => this.AssociatedPartners != null && (this.AssociatedPartners.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Your unique partner identifier in the AWS Partner Network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PrimaryPartner. 
        /// <para>
        /// The primary partner's profile and account identifiers. This field is null when the
        /// status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// </summary>
        public QualificationsAssociationPartner PrimaryPartner { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryPartner property is set.
        /// </summary>
        internal bool IsSetPrimaryPartner() => this.PrimaryPartner != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current qualifications association status. Valid values: <c>ASSOCIATED</c> (the
        /// partner is associated with a primary), <c>NOT_ASSOCIATED</c> (the partner has no active
        /// association).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QualificationsAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the qualifications association was last updated, in ISO 8601 format.
        /// This field is null when the status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
