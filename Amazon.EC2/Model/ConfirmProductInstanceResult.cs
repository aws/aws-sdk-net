/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Confirm Product Instance Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class ConfirmProductInstanceResult
    {
        private string ownerIdField;

        /// <summary>
        /// Gets and sets the OwnerId property.
        /// The instance owner's account ID. Only present if the product code is attached to
        /// the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the OwnerId property
        /// </summary>
        /// <param name="ownerId">The instance owner's account ID. Only present if the product code is attached to
        /// the instance.</param>
        /// <returns>this instance</returns>
        public ConfirmProductInstanceResult WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

    }
}
