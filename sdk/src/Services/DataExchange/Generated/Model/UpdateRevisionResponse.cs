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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// This is the response object from the UpdateRevision operation.
    /// </summary>
    public partial class UpdateRevisionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _comment;
        private DateTime? _createdAt;
        private string _dataSetId;
        private bool? _finalized;
        private string _id;
        private string _revocationComment;
        private bool? _revoked;
        private DateTime? _revokedAt;
        private string _sourceId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the revision.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the revision was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with the data set revision.
        /// </para>
        /// </summary>
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Finalized. 
        /// <para>
        /// To publish a revision to a data set in a product, the revision must first be finalized.
        /// Finalizing a revision tells AWS Data Exchange that changes to the assets in the revision
        /// are complete. After it's in this read-only state, you can publish the revision to
        /// your products. Finalized revisions can be published through the AWS Data Exchange
        /// console or the AWS Marketplace Catalog API, using the StartChangeSet AWS Marketplace
        /// Catalog API action. When using the API, revisions are uniquely identified by their
        /// ARN.
        /// </para>
        /// </summary>
        public bool Finalized
        {
            get { return this._finalized.GetValueOrDefault(); }
            set { this._finalized = value; }
        }

        // Check to see if Finalized property is set
        internal bool IsSetFinalized()
        {
            return this._finalized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the revision.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RevocationComment. 
        /// <para>
        /// A required comment to inform subscribers of the reason their access to the revision
        /// was revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=512)]
        public string RevocationComment
        {
            get { return this._revocationComment; }
            set { this._revocationComment = value; }
        }

        // Check to see if RevocationComment property is set
        internal bool IsSetRevocationComment()
        {
            return this._revocationComment != null;
        }

        /// <summary>
        /// Gets and sets the property Revoked. 
        /// <para>
        /// A status indicating that subscribers' access to the revision was revoked.
        /// </para>
        /// </summary>
        public bool Revoked
        {
            get { return this._revoked.GetValueOrDefault(); }
            set { this._revoked = value; }
        }

        // Check to see if Revoked property is set
        internal bool IsSetRevoked()
        {
            return this._revoked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The date and time that the revision was revoked, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime RevokedAt
        {
            get { return this._revokedAt.GetValueOrDefault(); }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The revision ID of the owned revision corresponding to the entitled revision being
        /// viewed. This parameter is returned when a revision owner is viewing the entitled copy
        /// of its owned revision.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the revision was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}