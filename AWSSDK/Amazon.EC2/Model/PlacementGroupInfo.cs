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
    /// A placement group into which multiple Amazon EC2 instances can be launched.
    /// </summary>
    /// <remarks>
    /// A placement group ensures that Amazon EC2 instances are physically
    /// located close enough to support HPC features, such as higher IO
    /// network connections between instances in the group.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class PlacementGroupInfo
    {    
        private string groupNameField;
        private string strategyField;
        private string stateField;

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
        public PlacementGroupInfo WithGroupName(string groupName)
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
        /// The strategy to use when allocating Amazon EC2 instances for the PlacementGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "Strategy")]
        public string Strategy
        {
            get { return this.strategyField; }
            set { this.strategyField = value; }
        }

        /// <summary>
        /// Sets the strategy to use when allocating Amazon EC2 instances for the PlacementGroup.
        /// </summary>
        /// <param name="strategy">The strategy to use when allocating Amazon EC2
        /// instances for the
        /// PlacementGroup.</param>
        /// <returns>this instance</returns>
        public PlacementGroupInfo WithStrategy(string strategy)
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

        /// <summary>
        /// The state of the PlacementGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the state of the PlacementGroup.
        /// </summary>
        /// <param name="state">The state of this PlacementGroup.</param>
        /// <returns>this instance</returns>
        public PlacementGroupInfo WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

    }
}
