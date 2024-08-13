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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the HttpRequestWithLabels operation.
    /// The example tests how requests are serialized when there's no input payload but there
    /// are HTTP labels.
    /// </summary>
    public partial class HttpRequestWithLabelsRequest : AmazonRestJsonProtocolRequest
    {
        private bool? _boolean;
        private double? _double;
        private float? _float;
        private int? _integer;
        private long? _long;
        private int? _short;
        private string _string;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        /// Serialized in the path as true or false.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Boolean
        {
            get { return this._boolean; }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Double.
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Double
        {
            get { return this._double; }
            set { this._double = value; }
        }

        // Check to see if Double property is set
        internal bool IsSetDouble()
        {
            return this._double.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Float.
        /// </summary>
        [AWSProperty(Required=true)]
        public float? Float
        {
            get { return this._float; }
            set { this._float = value; }
        }

        // Check to see if Float property is set
        internal bool IsSetFloat()
        {
            return this._float.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Integer.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Integer
        {
            get { return this._integer; }
            set { this._integer = value; }
        }

        // Check to see if Integer property is set
        internal bool IsSetInteger()
        {
            return this._integer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Long.
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Long
        {
            get { return this._long; }
            set { this._long = value; }
        }

        // Check to see if Long property is set
        internal bool IsSetLong()
        {
            return this._long.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Short.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Short
        {
            get { return this._short; }
            set { this._short = value; }
        }

        // Check to see if Short property is set
        internal bool IsSetShort()
        {
            return this._short.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property String.
        /// </summary>
        [AWSProperty(Required=true)]
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Note that this member has no format, so it's serialized as an RFC 3399 date-time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}