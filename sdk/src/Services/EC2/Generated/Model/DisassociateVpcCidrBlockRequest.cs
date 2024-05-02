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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateVpcCidrBlock operation.
    /// Disassociates a CIDR block from a VPC. To disassociate the CIDR block, you must specify
    /// its association ID. You can get the association ID by using <a>DescribeVpcs</a>. You
    /// must detach or delete all gateways and resources that are associated with the CIDR
    /// block before you can disassociate it. 
    /// 
    ///  
    /// <para>
    /// You cannot disassociate the CIDR block with which you originally created the VPC (the
    /// primary CIDR block).
    /// </para>
    /// </summary>
    public partial class DisassociateVpcCidrBlockRequest : AmazonEC2Request
    {
        private string _associationId;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for the CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

    }
}