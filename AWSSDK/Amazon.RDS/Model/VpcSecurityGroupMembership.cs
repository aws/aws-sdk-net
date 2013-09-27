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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>This data type is used as a response element for queries on VPC security group membership.</para>
    /// </summary>
    public class VpcSecurityGroupMembership
    {
        
        private string vpcSecurityGroupId;
        private string status;

        /// <summary>
        /// The name of the VPC security group.
        ///  
        /// </summary>
        public string VpcSecurityGroupId
        {
            get { return this.vpcSecurityGroupId; }
            set { this.vpcSecurityGroupId = value; }
        }

        /// <summary>
        /// Sets the VpcSecurityGroupId property
        /// </summary>
        /// <param name="vpcSecurityGroupId">The value to set for the VpcSecurityGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcSecurityGroupMembership WithVpcSecurityGroupId(string vpcSecurityGroupId)
        {
            this.vpcSecurityGroupId = vpcSecurityGroupId;
            return this;
        }
            

        // Check to see if VpcSecurityGroupId property is set
        internal bool IsSetVpcSecurityGroupId()
        {
            return this.vpcSecurityGroupId != null;
        }

        /// <summary>
        /// The status of the VPC Security Group.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcSecurityGroupMembership WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
