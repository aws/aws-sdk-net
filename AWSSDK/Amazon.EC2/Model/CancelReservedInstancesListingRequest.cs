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
    /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CancelReservedInstancesListingRequest : EC2Request
    {
        private string reservedInstancesListingIdField;

        /// <summary>
        /// The ID of the Reserved Instance listing to be canceled.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesListingId")]
        public string ReservedInstancesListingId
        {
            get { return this.reservedInstancesListingIdField; }
            set { this.reservedInstancesListingIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Reserved Instance listing to be canceled.
        /// </summary>
        /// <param name="reservedInstancesListingId">Listing Id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CancelReservedInstancesListingRequest WithReservedInstancesListingId(string reservedInstancesListingId)
        {
            this.reservedInstancesListingIdField = reservedInstancesListingId;
            return this;
        }

        /// <summary>
        /// Checks if the ReservedInstancesListingId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetReservedInstancesListingId()
        {
            return !string.IsNullOrEmpty(this.reservedInstancesListingIdField);
        }
    }
}
