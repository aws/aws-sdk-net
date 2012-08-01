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
    /// Creates a PlacementGroup into which multiple Amazon EC2
    /// instances can be launched. Users must give the group a
    /// name unique within the scope of the user account.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreatePlacementGroupRequest
    {    
        private string groupNameField;
        private string strategyField;

        /// <summary>
        /// Gets and sets the GroupName property.
        /// The name of the PlacementGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the GroupName property
        /// </summary>
        /// <param name="groupName">The name of the PlacementGroup.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Strategy property.
        /// The PlacementGroup strategy.
        /// </summary>
        [XmlElementAttribute(ElementName = "Strategy")]
        public string Strategy
        {
            get { return this.strategyField; }
            set { this.strategyField = value; }
        }

        /// <summary>
        /// Sets the Strategy property
        /// </summary>
        /// <param name="strategy">The PlacementGroup strategy.</param>
        /// <returns>this instance</returns>
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
