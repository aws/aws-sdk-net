/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Verifies whether a Amazon DevPay product code is associated with an
    /// instance. This can only be executed by the owner of the AMI and is
    /// useful when an AMI owner wants to verify whether a user's instance is
    /// eligible for support.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ConfirmProductInstanceRequest
    {    
        private string productCodeField;
        private string instanceIdField;

        /// <summary>
        /// Gets and sets the ProductCode property.
        /// The product code to confirm.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public string ProductCode
        {
            get { return this.productCodeField; }
            set { this.productCodeField = value; }
        }

        /// <summary>
        /// Sets the ProductCode property
        /// </summary>
        /// <param name="productCode">The product code to confirm.</param>
        /// <returns>this instance</returns>
        public ConfirmProductInstanceRequest WithProductCode(string productCode)
        {
            this.productCodeField = productCode;
            return this;
        }

        /// <summary>
        /// Checks if ProductCode property is set
        /// </summary>
        /// <returns>true if ProductCode property is set</returns>
        public bool IsSetProductCode()
        {
            return this.productCodeField != null;
        }

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The instance to confirm.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The instance to confirm.</param>
        /// <returns>this instance</returns>
        public ConfirmProductInstanceRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

    }
}
