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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Details of the infrastructure configuration.
    /// </summary>
    public partial class InfrastructureConfiguration
    {
        private string _arn;
        private string _dateCreated;
        private string _dateUpdated;
        private string _description;
        private InstanceMetadataOptions _instanceMetadataOptions;
        private string _instanceProfileName;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyPair;
        private Logging _logging;
        private string _name;
        private Placement _placement;
        private Dictionary<string, string> _resourceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _snsTopicArn;
        private string _subnetId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _terminateInstanceOnFailure;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration.
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which the infrastructure configuration was created.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date on which the infrastructure configuration was last updated.
        /// </para>
        /// </summary>
        public string DateUpdated
        {
            get { return this._dateUpdated; }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property InstanceMetadataOptions. 
        /// <para>
        /// The instance metadata option settings for the infrastructure configuration.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions InstanceMetadataOptions
        {
            get { return this._instanceMetadataOptions; }
            set { this._instanceMetadataOptions = value; }
        }

        // Check to see if InstanceMetadataOptions property is set
        internal bool IsSetInstanceMetadataOptions()
        {
            return this._instanceMetadataOptions != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// The instance profile of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types of the infrastructure configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// The Amazon EC2 key pair of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KeyPair
        {
            get { return this._keyPair; }
            set { this._keyPair = value; }
        }

        // Check to see if KeyPair property is set
        internal bool IsSetKeyPair()
        {
            return this._keyPair != null;
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration of the infrastructure configuration.
        /// </para>
        /// </summary>
        public Logging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the infrastructure configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Placement. 
        /// <para>
        /// The instance placement settings that define where the instances that are launched
        /// from your image will run.
        /// </para>
        /// </summary>
        public Placement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags attached to the resource created by Image Builder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public Dictionary<string, string> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs of the infrastructure configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the SNS topic to which we send image build event
        /// notifications.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2 Image Builder is unable to send notifications to SNS topics that are encrypted
        /// using keys from other accounts. The key that is used to encrypt the SNS topic must
        /// reside in the account that the Image Builder service runs under.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID of the infrastructure configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the infrastructure configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property TerminateInstanceOnFailure. 
        /// <para>
        /// The terminate instance on failure configuration of the infrastructure configuration.
        /// </para>
        /// </summary>
        public bool? TerminateInstanceOnFailure
        {
            get { return this._terminateInstanceOnFailure; }
            set { this._terminateInstanceOnFailure = value; }
        }

        // Check to see if TerminateInstanceOnFailure property is set
        internal bool IsSetTerminateInstanceOnFailure()
        {
            return this._terminateInstanceOnFailure.HasValue; 
        }

    }
}