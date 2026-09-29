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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains asset property value information.
    /// </summary>
    public partial class AssetPropertyValue
    {
        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// The quality of the asset property value.
        /// </para>
        /// </summary>
        public Quality Quality { get; set; }

        /// <summary>
        /// Checks to see if the Quality property is set.
        /// </summary>
        internal bool IsSetQuality() => this.Quality != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the asset property value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeInNanos Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the asset property (see <c>Variant</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Variant Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
