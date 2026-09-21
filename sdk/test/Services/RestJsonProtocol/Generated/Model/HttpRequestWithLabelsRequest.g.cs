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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the HttpRequestWithLabels operation. The example tests
    /// how requests are serialized when there's no input payload but there are HTTP labels.
    /// </summary>
    public partial class HttpRequestWithLabelsRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property Boolean. Serialized in the path as true or false.
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Boolean { get; set; }

        /// <summary>
        /// Checks to see if the Boolean property is set.
        /// </summary>
        internal bool IsSetBoolean() => this.Boolean.HasValue;

        /// <summary>
        /// Gets and sets the property Double.
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Double { get; set; }

        /// <summary>
        /// Checks to see if the Double property is set.
        /// </summary>
        internal bool IsSetDouble() => this.Double.HasValue;

        /// <summary>
        /// Gets and sets the property Float.
        /// </summary>
        [AWSProperty(Required = true)]
        public float? Float { get; set; }

        /// <summary>
        /// Checks to see if the Float property is set.
        /// </summary>
        internal bool IsSetFloat() => this.Float.HasValue;

        /// <summary>
        /// Gets and sets the property Integer.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Integer { get; set; }

        /// <summary>
        /// Checks to see if the Integer property is set.
        /// </summary>
        internal bool IsSetInteger() => this.Integer.HasValue;

        /// <summary>
        /// Gets and sets the property Long.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Long { get; set; }

        /// <summary>
        /// Checks to see if the Long property is set.
        /// </summary>
        internal bool IsSetLong() => this.Long.HasValue;

        /// <summary>
        /// Gets and sets the property Short.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Short { get; set; }

        /// <summary>
        /// Checks to see if the Short property is set.
        /// </summary>
        internal bool IsSetShort() => this.Short.HasValue;

        /// <summary>
        /// Gets and sets the property String.
        /// </summary>
        [AWSProperty(Required = true)]
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property Timestamp. Note that this member has no format, so it's
        /// serialized as an RFC 3399 date-time.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
