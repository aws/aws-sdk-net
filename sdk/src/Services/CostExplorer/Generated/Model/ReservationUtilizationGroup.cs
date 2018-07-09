/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// A group of Reserved Instances (RIs) that share a set of attributes.
    /// </summary>
    public partial class ReservationUtilizationGroup
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _key;
        private ReservationAggregates _utilization;
        private string _value;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes for this group of RIs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for a specific RI attribute.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Utilization. 
        /// <para>
        /// How much you used this group of RIs.
        /// </para>
        /// </summary>
        public ReservationAggregates Utilization
        {
            get { return this._utilization; }
            set { this._utilization = value; }
        }

        // Check to see if Utilization property is set
        internal bool IsSetUtilization()
        {
            return this._utilization != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a specific RI attribute.
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