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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironmentEC2 operation.
    /// Creates an Cloud9 development environment, launches an Amazon Elastic Compute Cloud
    /// (Amazon EC2) instance, and then connects from the instance to the environment.
    /// </summary>
    public partial class CreateEnvironmentEC2Request : AmazonCloud9Request
    {
        private int? _automaticStopTimeMinutes;
        private string _clientRequestToken;
        private ConnectionType _connectionType;
        private string _description;
        private bool? _dryRun;
        private string _imageId;
        private string _instanceType;
        private string _name;
        private string _ownerArn;
        private string _subnetId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AutomaticStopTimeMinutes. 
        /// <para>
        /// The number of minutes until the running instance is shut down after the environment
        /// has last been used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20160)]
        public int AutomaticStopTimeMinutes
        {
            get { return this._automaticStopTimeMinutes.GetValueOrDefault(); }
            set { this._automaticStopTimeMinutes = value; }
        }

        // Check to see if AutomaticStopTimeMinutes property is set
        internal bool IsSetAutomaticStopTimeMinutes()
        {
            return this._automaticStopTimeMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive string that helps Cloud9 to ensure this operation completes
        /// no more than one time.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Client
        /// Tokens</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type used for connecting to an Amazon EC2 environment. Valid values
        /// are <code>CONNECT_SSH</code> (default) and <code>CONNECT_SSM</code> (connected through
        /// Amazon EC2 Systems Manager).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud9/latest/user-guide/ec2-ssm.html">Accessing
        /// no-ingress EC2 instances with Amazon EC2 Systems Manager</a> in the <i>Cloud9 User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment to create.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <code>DryRunOperation</code>. Otherwise, it is <code>UnauthorizedOperation</code>.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier for the Amazon Machine Image (AMI) that's used to create the EC2 instance.
        /// To choose an AMI for the instance, you must specify a valid AMI alias or a valid Amazon
        /// EC2 Systems Manager (SSM) path.
        /// </para>
        ///  
        /// <para>
        /// The default Amazon Linux AMI is currently used if the parameter isn't explicitly assigned
        /// a value in the request. 
        /// </para>
        ///  
        /// <para>
        /// In the future the parameter for Amazon Linux will no longer be available when you
        /// specify an AMI for your instance. Amazon Linux 2 will then become the default AMI,
        /// which is used to launch your instance if no parameter is explicitly defined.
        /// </para>
        ///  
        /// <para>
        ///  <b>AMI aliases </b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Linux (default): <code>amazonlinux-1-x86_64</code> </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Linux 2: <code>amazonlinux-2-x86_64</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ubuntu 18.04: <code>ubuntu-18.04-x86_64</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>SSM paths</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Linux (default): <code>resolve:ssm:/aws/service/cloud9/amis/amazonlinux-1-x86_64</code>
        /// </b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Linux 2: <code>resolve:ssm:/aws/service/cloud9/amis/amazonlinux-2-x86_64</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ubuntu 18.04: <code>resolve:ssm:/aws/service/cloud9/amis/ubuntu-18.04-x86_64</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance to connect to the environment (for example, <code>t2.micro</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=20)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment to create.
        /// </para>
        ///  
        /// <para>
        /// This name is visible to other IAM users in the same Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
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
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment owner. This ARN can be the ARN of
        /// any IAM principal. If this value is not specified, the ARN defaults to this environment's
        /// creator.
        /// </para>
        /// </summary>
        public string OwnerArn
        {
            get { return this._ownerArn; }
            set { this._ownerArn = value; }
        }

        // Check to see if OwnerArn property is set
        internal bool IsSetOwnerArn()
        {
            return this._ownerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in Amazon VPC that Cloud9 will use to communicate with the Amazon
        /// EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
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
        /// An array of key-value pairs that will be associated with the new Cloud9 development
        /// environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}