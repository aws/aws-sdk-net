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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The time zone in which the place is located.
    /// </summary>
    public partial class TimeZone
    {
        private string _name;
        private string _offset;
        private long? _offsetSeconds;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The time zone name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
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
        /// Gets and sets the property Offset. 
        /// <para>
        /// Time zone offset of the timezone from UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6)]
        public string Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        // Check to see if Offset property is set
        internal bool IsSetOffset()
        {
            return this._offset != null;
        }

        /// <summary>
        /// Gets and sets the property OffsetSeconds. 
        /// <para>
        /// The offset of the time zone from UTC, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public long? OffsetSeconds
        {
            get { return this._offsetSeconds; }
            set { this._offsetSeconds = value; }
        }

        // Check to see if OffsetSeconds property is set
        internal bool IsSetOffsetSeconds()
        {
            return this._offsetSeconds.HasValue; 
        }

    }
}