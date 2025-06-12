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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// This is the response object from the CreateDataGrant operation.
    /// </summary>
    public partial class CreateDataGrantResponse : AmazonWebServiceResponse
    {
        private DataGrantAcceptanceState _acceptanceState;
        private DateTime? _acceptedAt;
        private string _arn;
        private DateTime? _createdAt;
        private string _dataSetId;
        private string _description;
        private DateTime? _endsAt;
        private GrantDistributionScope _grantDistributionScope;
        private string _id;
        private string _name;
        private string _receiverPrincipal;
        private string _senderPrincipal;
        private string _sourceDataSetId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AcceptanceState. 
        /// <para>
        /// The acceptance state of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataGrantAcceptanceState AcceptanceState
        {
            get { return this._acceptanceState; }
            set { this._acceptanceState = value; }
        }

        // Check to see if AcceptanceState property is set
        internal bool IsSetAcceptanceState()
        {
            return this._acceptanceState != null;
        }

        /// <summary>
        /// Gets and sets the property AcceptedAt. 
        /// <para>
        /// The timestamp of when the data grant was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptedAt
        {
            get { return this._acceptedAt; }
            set { this._acceptedAt = value; }
        }

        // Check to see if AcceptedAt property is set
        internal bool IsSetAcceptedAt()
        {
            return this._acceptedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the data grant was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The ID of the data set associated to the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndsAt. 
        /// <para>
        /// The timestamp of when access to the associated data set ends.
        /// </para>
        /// </summary>
        public DateTime? EndsAt
        {
            get { return this._endsAt; }
            set { this._endsAt = value; }
        }

        // Check to see if EndsAt property is set
        internal bool IsSetEndsAt()
        {
            return this._endsAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrantDistributionScope. 
        /// <para>
        /// The distribution scope for the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GrantDistributionScope GrantDistributionScope
        {
            get { return this._grantDistributionScope; }
            set { this._grantDistributionScope = value; }
        }

        // Check to see if GrantDistributionScope property is set
        internal bool IsSetGrantDistributionScope()
        {
            return this._grantDistributionScope != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the data grant.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiverPrincipal. 
        /// <para>
        /// The Amazon Web Services account ID of the data grant receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReceiverPrincipal
        {
            get { return this._receiverPrincipal; }
            set { this._receiverPrincipal = value; }
        }

        // Check to see if ReceiverPrincipal property is set
        internal bool IsSetReceiverPrincipal()
        {
            return this._receiverPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property SenderPrincipal. 
        /// <para>
        /// The Amazon Web Services account ID of the data grant sender.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SenderPrincipal
        {
            get { return this._senderPrincipal; }
            set { this._senderPrincipal = value; }
        }

        // Check to see if SenderPrincipal property is set
        internal bool IsSetSenderPrincipal()
        {
            return this._senderPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDataSetId. 
        /// <para>
        /// The ID of the data set used to create the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDataSetId
        {
            get { return this._sourceDataSetId; }
            set { this._sourceDataSetId = value; }
        }

        // Check to see if SourceDataSetId property is set
        internal bool IsSetSourceDataSetId()
        {
            return this._sourceDataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated to the data grant. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the data grant was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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