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
    /// This is the response object from the GetMLInputChannel operation.
    /// </summary>
    public partial class GetMLInputChannelResponse : AmazonWebServiceResponse
    {
        private string _collaborationIdentifier;
        private List<string> _configuredModelAlgorithmAssociations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createTime;
        private string _description;
        private InputChannel _inputChannel;
        private string _kmsKeyArn;
        private string _membershipIdentifier;
        private string _mlInputChannelArn;
        private string _name;
        private double? _numberOfFiles;
        private long? _numberOfRecords;
        private string _protectedQueryIdentifier;
        private int? _retentionInDays;
        private double? _sizeInGb;
        private MLInputChannelStatus _status;
        private StatusDetails _statusDetails;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// Gets and sets the property InputChannel. 
        /// <para>
        /// The input channel that was used to create the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputChannel InputChannel
        {
            get { return this._inputChannel; }
            set { this._inputChannel = value; }
        }

        // Check to see if InputChannel property is set
        internal bool IsSetInputChannel()
        {
            return this._inputChannel != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that was used to create the ML input
        /// channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
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
        /// Gets and sets the property NumberOfFiles. 
        /// <para>
        /// The number of files in the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public double? NumberOfFiles
        {
            get { return this._numberOfFiles; }
            set { this._numberOfFiles = value; }
        }

        // Check to see if NumberOfFiles property is set
        internal bool IsSetNumberOfFiles()
        {
            return this._numberOfFiles.HasValue; 
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
        /// Gets and sets the property ProtectedQueryIdentifier. 
        /// <para>
        /// The ID of the protected query that was used to create the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ProtectedQueryIdentifier
        {
            get { return this._protectedQueryIdentifier; }
            set { this._protectedQueryIdentifier = value; }
        }

        // Check to see if ProtectedQueryIdentifier property is set
        internal bool IsSetProtectedQueryIdentifier()
        {
            return this._protectedQueryIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// The number of days to keep the data in the ML input channel.
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
        /// Gets and sets the property SizeInGb. 
        /// <para>
        /// The size, in GB, of the ML input channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public double? SizeInGb
        {
            get { return this._sizeInGb; }
            set { this._sizeInGb = value; }
        }

        // Check to see if SizeInGb property is set
        internal bool IsSetSizeInGb()
        {
            return this._sizeInGb.HasValue; 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you applied to the resource to help you categorize and
        /// organize them. Each tag consists of a key and an optional value, both of which you
        /// define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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