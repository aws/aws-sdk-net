/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Provides information about the EC2 instances in a cluster grouped by category. For example, EC2 Key Name, Subnet Id, Instance Profile,
    /// and so on.</para>
    /// </summary>
    public class Ec2InstanceAttributes
    {
        
        private string ec2KeyName;
        private string ec2SubnetId;
        private string ec2AvailabilityZone;
        private string iamInstanceProfile;


        /// <summary>
        /// The name of the Amazon EC2 key pair to use when connecting with SSH into the master node as a user named "hadoop".
        ///  
        /// </summary>
        public string Ec2KeyName
        {
            get { return this.ec2KeyName; }
            set { this.ec2KeyName = value; }
        }

        // Check to see if Ec2KeyName property is set
        internal bool IsSetEc2KeyName()
        {
            return this.ec2KeyName != null;
        }

        /// <summary>
        /// To launch the job flow in Amazon VPC, set this parameter to the identifier of the Amazon VPC subnet where you want the job flow to launch.
        /// If you do not specify this value, the job flow is launched in the normal AWS cloud, outside of a VPC. Amazon VPC currently does not support
        /// cluster compute quadruple extra large (cc1.4xlarge) instances. Thus, you cannot specify the cc1.4xlarge instance type for nodes of a job
        /// flow launched in a VPC.
        ///  
        /// </summary>
        public string Ec2SubnetId
        {
            get { return this.ec2SubnetId; }
            set { this.ec2SubnetId = value; }
        }

        // Check to see if Ec2SubnetId property is set
        internal bool IsSetEc2SubnetId()
        {
            return this.ec2SubnetId != null;
        }

        /// <summary>
        /// The Availability Zone in which the cluster will run.
        ///  
        /// </summary>
        public string Ec2AvailabilityZone
        {
            get { return this.ec2AvailabilityZone; }
            set { this.ec2AvailabilityZone = value; }
        }

        // Check to see if Ec2AvailabilityZone property is set
        internal bool IsSetEc2AvailabilityZone()
        {
            return this.ec2AvailabilityZone != null;
        }

        /// <summary>
        /// The IAM role that was specified when the job flow was launched. The EC2 instances of the job flow assume this role.
        ///  
        /// </summary>
        public string IamInstanceProfile
        {
            get { return this.iamInstanceProfile; }
            set { this.iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this.iamInstanceProfile != null;
        }
    }
}
