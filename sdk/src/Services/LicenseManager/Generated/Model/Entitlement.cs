/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes a resource entitled for use with a license.
    /// </summary>
    public partial class Entitlement
    {
        private bool? _allowCheckIn;
        private long? _maxCount;
        private string _name;
        private bool? _overage;
        private EntitlementUnit _unit;
        private string _value;

        /// <summary>
        /// Gets and sets the property AllowCheckIn. 
        /// <para>
        /// Indicates whether check-ins are allowed.
        /// </para>
        /// </summary>
        public bool? AllowCheckIn
        {
            get { return this._allowCheckIn; }
            set { this._allowCheckIn = value; }
        }

        // Check to see if AllowCheckIn property is set
        internal bool IsSetAllowCheckIn()
        {
            return this._allowCheckIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// Maximum entitlement count. Use if the unit is not None.
        /// </para>
        /// </summary>
        public long? MaxCount
        {
            get { return this._maxCount; }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Entitlement name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Overage. 
        /// <para>
        /// Indicates whether overages are allowed.
        /// </para>
        /// </summary>
        public bool? Overage
        {
            get { return this._overage; }
            set { this._overage = value; }
        }

        // Check to see if Overage property is set
        internal bool IsSetOverage()
        {
            return this._overage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Entitlement unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntitlementUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Entitlement resource. Use only if the unit is None.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}