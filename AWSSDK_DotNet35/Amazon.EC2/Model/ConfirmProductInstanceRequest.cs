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
    /// <para>Determines whether a product code is associated with an instance. This action can only be used by the owner of the product code. It is
    /// useful when a product code owner needs to verify whether another user's instance is eligible for support.</para>
    /// </summary>
    public partial class ConfirmProductInstanceRequest : AmazonEC2Request
    {
        private string productCode;
        private string instanceId;


        /// <summary>
        /// The product code. This must be an Amazon DevPay product code that you own.
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
        /// The ID of the instance.
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
    
