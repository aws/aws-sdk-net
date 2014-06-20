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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Provides information about the EC2 instances in a cluster grouped by category. For
    /// example, key name, subnet ID, IAM instance profile, and so on.
    /// </summary>
    public partial class Ec2InstanceAttributes
    {
        private string _ec2AvailabilityZone;
        private string _ec2KeyName;
        private string _ec2SubnetId;
        private string _iamInstanceProfile;


        /// <summary>
        /// Gets and sets the property Ec2AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the cluster will run.
        /// </para>
        /// </summary>
        public string Ec2AvailabilityZone
        {
            get { return this._ec2AvailabilityZone; }
            set { this._ec2AvailabilityZone = value; }
        }


        /// <summary>
        /// Sets the Ec2AvailabilityZone property
        /// </summary>
        /// <param name="ec2AvailabilityZone">The value to set for the Ec2AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Ec2InstanceAttributes WithEc2AvailabilityZone(string ec2AvailabilityZone)
        {
            this._ec2AvailabilityZone = ec2AvailabilityZone;
            return this;
        }

        // Check to see if Ec2AvailabilityZone property is set
        internal bool IsSetEc2AvailabilityZone()
        {
            return this._ec2AvailabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property Ec2KeyName. 
        /// <para>
        /// The name of the Amazon EC2 key pair to use when connecting with SSH into the master
        /// node as         a user named "hadoop".
        /// </para>
        /// </summary>
        public string Ec2KeyName
        {
            get { return this._ec2KeyName; }
            set { this._ec2KeyName = value; }
        }


        /// <summary>
        /// Sets the Ec2KeyName property
        /// </summary>
        /// <param name="ec2KeyName">The value to set for the Ec2KeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Ec2InstanceAttributes WithEc2KeyName(string ec2KeyName)
        {
            this._ec2KeyName = ec2KeyName;
            return this;
        }

        // Check to see if Ec2KeyName property is set
        internal bool IsSetEc2KeyName()
        {
            return this._ec2KeyName != null;
        }


        /// <summary>
        /// Gets and sets the property Ec2SubnetId. 
        /// <para>
        ///          To launch the job flow in Amazon VPC, set this parameter to the identifier
        /// of the Amazon VPC subnet where          you want the job flow to launch. If you do
        /// not specify this value, the job flow is launched in the normal AWS cloud, outside
        /// of          a VPC.       
        /// </para>
        ///       
        /// <para>
        ///          Amazon VPC currently does not support cluster compute quadruple extra large
        /// (cc1.4xlarge) instances.           Thus, you cannot specify the cc1.4xlarge instance
        /// type for nodes of a job flow launched in a VPC.      
        /// </para>
        /// </summary>
        public string Ec2SubnetId
        {
            get { return this._ec2SubnetId; }
            set { this._ec2SubnetId = value; }
        }


        /// <summary>
        /// Sets the Ec2SubnetId property
        /// </summary>
        /// <param name="ec2SubnetId">The value to set for the Ec2SubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Ec2InstanceAttributes WithEc2SubnetId(string ec2SubnetId)
        {
            this._ec2SubnetId = ec2SubnetId;
            return this;
        }

        // Check to see if Ec2SubnetId property is set
        internal bool IsSetEc2SubnetId()
        {
            return this._ec2SubnetId != null;
        }


        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. The EC2 instances
        /// of the job flow assume this role.
        /// </para>
        /// </summary>
        public string IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }


        /// <summary>
        /// Sets the IamInstanceProfile property
        /// </summary>
        /// <param name="iamInstanceProfile">The value to set for the IamInstanceProfile property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Ec2InstanceAttributes WithIamInstanceProfile(string iamInstanceProfile)
        {
            this._iamInstanceProfile = iamInstanceProfile;
            return this;
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

    }
}