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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Determines whether a product code is associated with an instance. This action can
    /// only be used by the owner of the product code. It is useful when a product code owner
    /// needs to verify whether another user's instance is eligible for support.
    /// </summary>
    public partial class ConfirmProductInstanceRequest : AmazonEC2Request
    {
        private string _instanceId;
        private string _productCode;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ConfirmProductInstanceRequest() { }

        /// <summary>
        /// Instantiates ConfirmProductInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="productCode">The product code. This must be a product code that you own.</param>
        /// <param name="instanceId">The ID of the instance.</param>
        public ConfirmProductInstanceRequest(string productCode, string instanceId)
        {
            _productCode = productCode;
            _instanceId = instanceId;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code. This must be a product code that you own.
        /// </para>
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

    }
}