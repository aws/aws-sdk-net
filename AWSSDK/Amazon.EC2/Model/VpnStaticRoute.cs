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
    /// Vpn Static Route
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpnStaticRoute
    {
        private string destinationCidrBlockField;
        private string sourceField;
        private string stateField;

        /// <summary>
        /// The destination CIDR block.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCIDRBlock")]
        public string DestinationCIDRBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the destination CIDR block.
        /// </summary>
        /// <param name="cidr">CIDR</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnStaticRoute WithDestinationCIDRBlock(string cidr)
        {
            this.destinationCidrBlockField = cidr;
            return this;
        }

        /// <summary>
        /// Checks if the DestinationCIDRBlock property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetDestinationCIDRBlock()
        {
            return !string.IsNullOrEmpty(this.destinationCidrBlockField);
        }

        /// <summary>
        /// DOCS_TODO
        /// </summary>
        [XmlElementAttribute(ElementName = "Source")]
        public string Source
        {
            get { return this.sourceField; }
            set { this.sourceField = value; }
        }

        /// <summary>
        /// Sets the Source property.
        /// </summary>
        /// <param name="source">DOCS_TODO</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnStaticRoute WithSource(string source)
        {
            this.sourceField = source;
            return this;
        }

        /// <summary>
        /// Checks if the Source property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetSource()
        {
            return !string.IsNullOrEmpty(this.sourceField);
        }

        /// <summary>
        /// Gets and sets the current state of the static route.
        /// Valid values: pending | available | deleting | deleted
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the current state of the static route.
        /// </summary>
        /// <param name="state">Current State; Valid values: pending | available | deleting | deleted</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnStaticRoute WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if the State property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetState()
        {
            return !string.IsNullOrEmpty(this.stateField);
        }
    }
}
