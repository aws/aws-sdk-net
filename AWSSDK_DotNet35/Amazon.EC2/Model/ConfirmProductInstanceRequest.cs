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
    /// Container for the parameters to the ConfirmProductInstance operation.
    /// <para> The ConfirmProductInstance operation returns true if the specified product code is attached to the specified instance. The operation
    /// returns false if the product code is not attached to the instance. </para> <para> The ConfirmProductInstance operation can only be executed
    /// by the owner of the AMI. This feature is useful when an AMI owner is providing support and wants to verify whether a user's instance is
    /// eligible. </para>
    /// </summary>
    public partial class ConfirmProductInstanceRequest : AmazonEC2Request
    {
        private string productCode;
        private string instanceId;


        /// <summary>
        /// The product code to confirm.
        ///  
        /// </summary>
        public string ProductCode
        {
            get { return this.productCode; }
            set { this.productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this.productCode != null;
        }

        /// <summary>
        /// The ID of the instance to confirm.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

    }
}
    
