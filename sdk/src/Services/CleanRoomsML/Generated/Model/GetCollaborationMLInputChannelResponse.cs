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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetCollaborationMLInputChannel operation.
    /// </summary>
    public partial class GetCollaborationMLInputChannelResponse : AmazonWebServiceResponse
    {
        private string _collaborationIdentifier;
        private List<string> _configuredModelAlgorithmAssociations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createTime;
        private string _creatorAccountId;
        private string _description;
        private string _membershipIdentifier;
        private string _mlInputChannelArn;
        private string _name;
        private long? _numberOfRecords;
        private int? _retentionInDays;
        private MLInputChannelStatus _status;
        private StatusDetails _statusDetails;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociations. 
        /// <para>
        /// The configured model algorithm associations that were used to create the ML input
        /// channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ConfiguredModelAlgorithmAssociations
        {
            get { return this._configuredModelAlgorithmAssociations; }
            set { this._configuredModelAlgorithmAssociations = value; }
        }

        // Check to see if ConfiguredModelAlgorithmAssociations property is set
        internal bool IsSetConfiguredModelAlgorithmAssociations()
        {
            return this._configuredModelAlgorithmAssociations != null && (this._configuredModelAlgorithmAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the ML input channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The account ID of the member who created the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the membership that contains the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MlInputChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string MlInputChannelArn
        {
            get { return this._mlInputChannelArn; }
            set { this._mlInputChannelArn = value; }
        }

        // Check to see if MlInputChannelArn property is set
        internal bool IsSetMlInputChannelArn()
        {
            return this._mlInputChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property NumberOfRecords. 
        /// <para>
        /// The number of records in the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000000000)]
        public long? NumberOfRecords
        {
            get { return this._numberOfRecords; }
            set { this._numberOfRecords = value; }
        }

        // Check to see if NumberOfRecords property is set
        internal bool IsSetNumberOfRecords()
        {
            return this._numberOfRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// The number of days to retain the data for the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public int? RetentionInDays
        {
            get { return this._retentionInDays; }
            set { this._retentionInDays = value; }
        }

        // Check to see if RetentionInDays property is set
        internal bool IsSetRetentionInDays()
        {
            return this._retentionInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MLInputChannelStatus Status
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
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the ML input channel was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}