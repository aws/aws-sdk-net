/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironmentEC2 operation.
    /// Creates an AWS Cloud9 development environment, launches an Amazon Elastic Compute
    /// Cloud (Amazon EC2) instance, and then connects from the instance to the environment.
    /// </summary>
    public partial class CreateEnvironmentEC2Request : AmazonCloud9Request
    {
        private int? _automaticStopTimeMinutes;
        private string _clientRequestToken;
        private string _description;
        private string _instanceType;
        private string _name;
        private string _ownerArn;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AutomaticStopTimeMinutes. 
        /// <para>
        /// The number of minutes until the running instance is shut down after the environment
        /// has last been used.
        /// </para>
        /// </summary>
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
        /// A unique, case-sensitive string that helps AWS Cloud9 to ensure this operation completes
        /// no more than one time.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Client
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment to create.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance to connect to the environment (for example, <code>t2.micro</code>).
        /// </para>
        /// </summary>
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
        /// This name is visible to other AWS IAM users in the same AWS account.
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
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment owner. This ARN can be the ARN of
        /// any AWS IAM principal. If this value is not specified, the ARN defaults to this environment's
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
        /// The ID of the subnet in Amazon VPC that AWS Cloud9 will use to communicate with the
        /// Amazon EC2 instance.
        /// </para>
        /// </summary>
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

    }
}