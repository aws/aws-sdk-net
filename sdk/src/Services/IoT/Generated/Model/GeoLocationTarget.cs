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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A geolocation target that you select to index. Each geolocation target contains a
    /// <c>name</c> and <c>order</c> key-value pair that specifies the geolocation target
    /// fields.
    /// </summary>
    public partial class GeoLocationTarget
    {
        private string _name;
        private TargetFieldOrder _order;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <c>name</c> of the geolocation target field. If the target field is part of a
        /// named shadow, you must select the named shadow using the <c>namedShadow</c> filter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Order. 
        /// <para>
        /// The <c>order</c> of the geolocation target field. This field is optional. The default
        /// value is <c>LatLon</c>.
        /// </para>
        /// </summary>
        public TargetFieldOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

    }
}