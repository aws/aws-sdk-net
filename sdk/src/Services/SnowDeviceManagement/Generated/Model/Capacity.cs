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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
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
namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// The physical capacity of the Amazon Web Services Snow Family device.
    /// </summary>
    public partial class Capacity
    {
        private long? _available;
        private string _name;
        private long? _total;
        private string _unit;
        private long? _used;

        /// <summary>
        /// Gets and sets the property Available. 
        /// <para>
        /// The amount of capacity available for use on the device.
        /// </para>
        /// </summary>
        public long? Available
        {
            get { return this._available; }
            set { this._available = value; }
        }

        // Check to see if Available property is set
        internal bool IsSetAvailable()
        {
            return this._available.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the type of capacity, such as memory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property Total. 
        /// <para>
        /// The total capacity on the device.
        /// </para>
        /// </summary>
        public long? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measure for the type of capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public string Unit
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
        /// Gets and sets the property Used. 
        /// <para>
        /// The amount of capacity used on the device.
        /// </para>
        /// </summary>
        public long? Used
        {
            get { return this._used; }
            set { this._used = value; }
        }

        // Check to see if Used property is set
        internal bool IsSetUsed()
        {
            return this._used.HasValue; 
        }

    }
}