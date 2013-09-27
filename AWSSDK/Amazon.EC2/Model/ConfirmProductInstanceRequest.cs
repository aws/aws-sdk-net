/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Determines whether a product code is associated with an instance.
    /// </summary>
    /// <remarks>
    /// This action can only be used by the owner of the product code.
    /// It is useful when a product code owner needs to verify whether another EC2 user�s
    /// instance is eligible for support.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class ConfirmProductInstanceRequest : EC2Request
    {    
        private string productCodeField;
        private string instanceIdField;

        /// <summary>
        /// The product code to confirm.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public string ProductCode
        {
            get { return this.productCodeField; }
            set { this.productCodeField = value; }
        }

        /// <summary>
        /// Sets the product code to confirm.
        /// </summary>
        /// <param name="productCode">The product code to confirm.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The instance to confirm.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance to confirm.
        /// </summary>
        /// <param name="instanceId">The instance to confirm.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
