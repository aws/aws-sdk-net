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
    /// Container for the parameters to the DeleteVpcEncryptionControl operation.
    /// Deletes a VPC Encryption Control configuration. This removes the encryption policy
    /// enforcement from the specified VPC.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteVpcEncryptionControlRequest : AmazonEC2Request
    {
        private string _vpcEncryptionControlId;

        /// <summary>
        /// Gets and sets the property VpcEncryptionControlId. 
        /// <para>
        /// The ID of the VPC Encryption Control resource to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcEncryptionControlId
        {
            get { return this._vpcEncryptionControlId; }
            set { this._vpcEncryptionControlId = value; }
        }

        // Check to see if VpcEncryptionControlId property is set
        internal bool IsSetVpcEncryptionControlId()
        {
            return this._vpcEncryptionControlId != null;
        }

    }
}