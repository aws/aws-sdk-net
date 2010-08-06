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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Represents the capacity that a license is able to support.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class LicenseCapacity
    {    
        private Decimal? capacityField;
        private Decimal? instanceCapacityField;
        private string stateField;
        private string earliestAllowedDeactivationTimeField;

        /// <summary>
        /// Gets and sets the Capacity property.
        /// The number of licenses available.
        /// </summary>
        [XmlElementAttribute(ElementName = "Capacity")]
        public Decimal Capacity
        {
            get { return this.capacityField.GetValueOrDefault(); }
            set { this.capacityField = value; }
        }

        /// <summary>
        /// Sets the Capacity property
        /// </summary>
        /// <param name="capacity">The number of licenses available.</param>
        /// <returns>this instance</returns>
        public LicenseCapacity WithCapacity(Decimal capacity)
        {
            this.capacityField = capacity;
            return this;
        }

        /// <summary>
        /// Checks if Capacity property is set
        /// </summary>
        /// <returns>true if Capacity property is set</returns>
        public bool IsSetCapacity()
        {
            return this.capacityField.HasValue;
        }

        /// <summary>
        /// Gets and sets the InstanceCapacity property.
        /// The number of Amazon EC2 instances that can be
        /// supported with the
        /// license's capacity.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCapacity")]
        public Decimal InstanceCapacity
        {
            get { return this.instanceCapacityField.GetValueOrDefault(); }
            set { this.instanceCapacityField = value; }
        }

        /// <summary>
        /// Sets the InstanceCapacity property
        /// </summary>
        /// <param name="instanceCapacity">The number of Amazon EC2 instances that can be
        /// supported with the
        /// license's capacity.</param>
        /// <returns>this instance</returns>
        public LicenseCapacity WithInstanceCapacity(Decimal instanceCapacity)
        {
            this.instanceCapacityField = instanceCapacity;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCapacity property is set
        /// </summary>
        /// <returns>true if InstanceCapacity property is set</returns>
        public bool IsSetInstanceCapacity()
        {
            return this.instanceCapacityField.HasValue;
        }

        /// <summary>
        /// Gets and sets the State property.
        /// The state of this license capacity,
        /// indicating
        /// whether the license is actively being used or not.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The state of this license capacity,
        /// indicating
        /// whether the license is actively being used or not.</param>
        /// <returns>this instance</returns>
        public LicenseCapacity WithState(string state)
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

        /// <summary>
        /// Gets and sets the EarliestAllowedDeactivationTime property.
        /// The earliest allowed time at which a license
        /// can be deactivated.
        /// Some licenses have time restrictions on when
        /// they can be activated and reactivated.
        /// </summary>
        [XmlElementAttribute(ElementName = "EarliestAllowedDeactivationTime")]
        public string EarliestAllowedDeactivationTime
        {
            get { return this.earliestAllowedDeactivationTimeField; }
            set { this.earliestAllowedDeactivationTimeField = value; }
        }

        /// <summary>
        /// Sets the EarliestAllowedDeactivationTime property
        /// </summary>
        /// <param name="earliestAllowedDeactivationTime">The earliest allowed time at which a license
        /// can be deactivated.
        /// Some licenses have time restrictions on when
        /// they can be activated and reactivated.</param>
        /// <returns>this instance</returns>
        public LicenseCapacity WithEarliestAllowedDeactivationTime(string earliestAllowedDeactivationTime)
        {
            this.earliestAllowedDeactivationTimeField = earliestAllowedDeactivationTime;
            return this;
        }

        /// <summary>
        /// Checks if EarliestAllowedDeactivationTime property is set
        /// </summary>
        /// <returns>true if EarliestAllowedDeactivationTime property is set</returns>
        public bool IsSetEarliestAllowedDeactivationTime()
        {
            return this.earliestAllowedDeactivationTimeField != null;
        }

    }
}
