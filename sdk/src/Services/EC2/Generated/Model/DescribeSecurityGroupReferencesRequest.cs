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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSecurityGroupReferences operation.
    /// [EC2-VPC only] Describes the VPCs on the other side of a VPC peering connection that
    /// are referencing the security groups you've specified in this request.
    /// </summary>
    public partial class DescribeSecurityGroupReferencesRequest : AmazonEC2Request
    {
        private List<string> _groupId = new List<string>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// One or more security group IDs in your account.
        /// </para>
        /// </summary>
        public List<string> GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null && this._groupId.Count > 0; 
        }

    }
}