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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInfrastructureConfiguration operation.
    /// Creates a new infrastructure configuration. An infrastructure configuration defines
    /// the environment in which your image will be built and tested.
    /// </summary>
    public partial class CreateInfrastructureConfigurationRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _description;
        private InstanceMetadataOptions _instanceMetadataOptions;
        private string _instanceProfileName;
        private List<string> _instanceTypes = new List<string>();
        private string _keyPair;
        private Logging _logging;
        private string _name;
        private Dictionary<string, string> _resourceTags = new Dictionary<string, string>();
        private List<string> _securityGroupIds = new List<string>();
        private string _snsTopicArn;
        private string _subnetId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private bool? _terminateInstanceOnFailure;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token used to make this request idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// The instance metadata options that you can set for the HTTP requests that pipeline
        /// builds use to launch EC2 build and test instances.
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
        /// The instance profile to associate with the instance used to customize your Amazon
        /// EC2 AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The instance types of the infrastructure configuration. You can specify one or more
        /// instance types to use for this build. The service will pick one of these instance
        /// types based on availability.
        /// </para>
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        /// The key pair of the infrastructure configuration. You can use this to log on to and
        /// debug the instance used to create your image.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The tags attached to the resource created by Image Builder.
        /// </para>
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
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs to associate with the instance used to customize your Amazon
        /// EC2 AMI.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic on which to send image build events.
        /// </para>
        /// </summary>
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
        /// The subnet ID in which to place the instance used to customize your Amazon EC2 AMI.
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstanceOnFailure. 
        /// <para>
        /// The terminate instance on failure setting of the infrastructure configuration. Set
        /// to false if you want Image Builder to retain the instance used to configure your AMI
        /// if the build or test phase of your workflow fails.
        /// </para>
        /// </summary>
        public bool TerminateInstanceOnFailure
        {
            get { return this._terminateInstanceOnFailure.GetValueOrDefault(); }
            set { this._terminateInstanceOnFailure = value; }
        }

        // Check to see if TerminateInstanceOnFailure property is set
        internal bool IsSetTerminateInstanceOnFailure()
        {
            return this._terminateInstanceOnFailure.HasValue; 
        }

    }
}