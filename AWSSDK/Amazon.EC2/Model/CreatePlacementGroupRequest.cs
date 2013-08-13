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
    /// Creates a PlacementGroup into which multiple Amazon EC2
    /// instances can be launched. Users must give the group a
    /// name unique within the scope of the user account.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreatePlacementGroupRequest : EC2Request
    {    
        private string groupNameField;
        private string strategyField;

        /// <summary>
        /// The name of the PlacementGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the name of the PlacementGroup.
        /// </summary>
        /// <param name="groupName">The name of the PlacementGroup.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlacementGroupRequest WithGroupName(string groupName)
        {
            this.groupNameField = groupName;
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return this.groupNameField != null;
        }

        /// <summary>
        /// The placement group strategy.
        /// </summary>
        /// <remarks>
        /// Valid values: cluster
        /// </remarks>
        [XmlElementAttribute(ElementName = "Strategy")]
        public string Strategy
        {
            get { return this.strategyField; }
            set { this.strategyField = value; }
        }

        /// <summary>
        /// Sets the placement group strategy.
        /// </summary>
        /// <param name="strategy">The PlacementGroup strategy.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlacementGroupRequest WithStrategy(string strategy)
        {
            this.strategyField = strategy;
            return this;
        }

        /// <summary>
        /// Checks if Strategy property is set
        /// </summary>
        /// <returns>true if Strategy property is set</returns>
        public bool IsSetStrategy()
        {
            return this.strategyField != null;
        }

    }
}
