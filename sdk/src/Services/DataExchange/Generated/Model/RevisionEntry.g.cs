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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// A revision is a container for one or more assets.
    /// </summary>
    public partial class RevisionEntry
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the revision was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with the data set revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property Finalized. 
        /// <para>
        /// To publish a revision to a data set in a product, the revision must first be finalized.
        /// Finalizing a revision tells AWS Data Exchange that your changes to the assets in the
        /// revision are complete. After it's in this read-only state, you can publish the revision
        /// to your products. Finalized revisions can be published through the AWS Data Exchange
        /// console or the AWS Marketplace Catalog API, using the StartChangeSet AWS Marketplace
        /// Catalog API action. When using the API, revisions are uniquely identified by their
        /// ARN.
        /// </para>
        /// </summary>
        public bool? Finalized { get; set; }

        /// <summary>
        /// Checks to see if the Finalized property is set.
        /// </summary>
        internal bool IsSetFinalized() => this.Finalized.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RevocationComment. 
        /// <para>
        /// A required comment to inform subscribers of the reason their access to the revision
        /// was revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 512)]
        public string RevocationComment { get; set; }

        /// <summary>
        /// Checks to see if the RevocationComment property is set.
        /// </summary>
        internal bool IsSetRevocationComment() => this.RevocationComment != null;

        /// <summary>
        /// Gets and sets the property Revoked. 
        /// <para>
        /// A status indicating that subscribers' access to the revision was revoked.
        /// </para>
        /// </summary>
        public bool? Revoked { get; set; }

        /// <summary>
        /// Checks to see if the Revoked property is set.
        /// </summary>
        internal bool IsSetRevoked() => this.Revoked.HasValue;

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The date and time that the revision was revoked, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Checks to see if the RevokedAt property is set.
        /// </summary>
        internal bool IsSetRevokedAt() => this.RevokedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The revision ID of the owned revision corresponding to the entitled revision being
        /// viewed. This parameter is returned when a revision owner is viewing the entitled copy
        /// of its owned revision.
        /// </para>
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the revision was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
