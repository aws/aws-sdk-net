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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
        private string _arn;
        private List<QualificationsAssociationPartner> _associatedPartners = AWSConfigs.InitializeCollections ? new List<QualificationsAssociationPartner>() : null;
        private string _catalog;
        private string _id;
        private QualificationsAssociationPartner _primaryPartner;
        private QualificationsAssociationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies your partner resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedPartners. 
        /// <para>
        /// The list of all partner profile and account identifiers currently associated under
        /// the primary partner. This field is null when the status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<QualificationsAssociationPartner> AssociatedPartners
        {
            get { return this._associatedPartners; }
            set { this._associatedPartners = value; }
        }

        // Check to see if AssociatedPartners property is set
        internal bool IsSetAssociatedPartners()
        {
            return this._associatedPartners != null && (this._associatedPartners.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier echoed from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Your unique partner identifier in the AWS Partner Network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryPartner. 
        /// <para>
        /// The primary partner's profile and account identifiers. This field is null when the
        /// status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// </summary>
        public QualificationsAssociationPartner PrimaryPartner
        {
            get { return this._primaryPartner; }
            set { this._primaryPartner = value; }
        }

        // Check to see if PrimaryPartner property is set
        internal bool IsSetPrimaryPartner()
        {
            return this._primaryPartner != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current qualifications association status. Valid values: <c>ASSOCIATED</c> (the
        /// partner is associated with a primary), <c>NOT_ASSOCIATED</c> (the partner has no active
        /// association).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QualificationsAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the qualifications association was last updated, in ISO 8601 format.
        /// This field is null when the status is <c>NOT_ASSOCIATED</c>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}