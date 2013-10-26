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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateAddress operation.
    /// <para> The DisassociateAddress operation disassociates the specified elastic IP address from the instance to which it is assigned. This is
    /// an idempotent operation. If you enter it more than once, Amazon EC2 does not return an error. </para>
    /// </summary>
    public partial class DisassociateAddressRequest : AmazonEC2Request
    {
        private string publicIp;
        private string associationId;


        /// <summary>
        /// The elastic IP address that you are disassociating from the instance.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// Association ID corresponding to the VPC elastic IP address you want to disassociate.
        ///  
        /// </summary>
        public string AssociationId
        {
            get { return this.associationId; }
            set { this.associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this.associationId != null;
        }

    }
}
    
