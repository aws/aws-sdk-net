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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail based on resource type.
    /// </summary>
    public partial class ResourceViolation
    {
        private AwsEc2InstanceViolation _awsEc2InstanceViolation;
        private AwsEc2NetworkInterfaceViolation _awsEc2NetworkInterfaceViolation;
        private AwsVPCSecurityGroupViolation _awsVPCSecurityGroupViolation;

        /// <summary>
        /// Gets and sets the property AwsEc2InstanceViolation. 
        /// <para>
        /// Violation details for an EC2 instance.
        /// </para>
        /// </summary>
        public AwsEc2InstanceViolation AwsEc2InstanceViolation
        {
            get { return this._awsEc2InstanceViolation; }
            set { this._awsEc2InstanceViolation = value; }
        }

        // Check to see if AwsEc2InstanceViolation property is set
        internal bool IsSetAwsEc2InstanceViolation()
        {
            return this._awsEc2InstanceViolation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterfaceViolation. 
        /// <para>
        /// Violation details for network interface.
        /// </para>
        /// </summary>
        public AwsEc2NetworkInterfaceViolation AwsEc2NetworkInterfaceViolation
        {
            get { return this._awsEc2NetworkInterfaceViolation; }
            set { this._awsEc2NetworkInterfaceViolation = value; }
        }

        // Check to see if AwsEc2NetworkInterfaceViolation property is set
        internal bool IsSetAwsEc2NetworkInterfaceViolation()
        {
            return this._awsEc2NetworkInterfaceViolation != null;
        }

        /// <summary>
        /// Gets and sets the property AwsVPCSecurityGroupViolation. 
        /// <para>
        /// Violation details for security groups.
        /// </para>
        /// </summary>
        public AwsVPCSecurityGroupViolation AwsVPCSecurityGroupViolation
        {
            get { return this._awsVPCSecurityGroupViolation; }
            set { this._awsVPCSecurityGroupViolation = value; }
        }

        // Check to see if AwsVPCSecurityGroupViolation property is set
        internal bool IsSetAwsVPCSecurityGroupViolation()
        {
            return this._awsVPCSecurityGroupViolation != null;
        }

    }
}