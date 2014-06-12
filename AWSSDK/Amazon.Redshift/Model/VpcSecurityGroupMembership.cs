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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the members of a VPC security group.
    /// </summary>
    public partial class VpcSecurityGroupMembership
    {
        private string _status;
        private string _vpcSecurityGroupId;


        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcSecurityGroupMembership WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property VpcSecurityGroupId.
        /// </summary>
        public string VpcSecurityGroupId
        {
            get { return this._vpcSecurityGroupId; }
            set { this._vpcSecurityGroupId = value; }
        }


        /// <summary>
        /// Sets the VpcSecurityGroupId property
        /// </summary>
        /// <param name="vpcSecurityGroupId">The value to set for the VpcSecurityGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcSecurityGroupMembership WithVpcSecurityGroupId(string vpcSecurityGroupId)
        {
            this._vpcSecurityGroupId = vpcSecurityGroupId;
            return this;
        }

        // Check to see if VpcSecurityGroupId property is set
        internal bool IsSetVpcSecurityGroupId()
        {
            return this._vpcSecurityGroupId != null;
        }

    }
}