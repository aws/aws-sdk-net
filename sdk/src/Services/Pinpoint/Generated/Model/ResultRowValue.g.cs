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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides a single value and metadata about that value as part of an array of query
    /// results for a standard metric that applies to an application, campaign, or journey.
    /// </summary>
    public partial class ResultRowValue
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The friendly name of the metric whose value is specified by the Value property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the value specified by the Value property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// In a Values object, the value for the metric that the query retrieved data for. In
        /// a GroupedBys object, the value for the field that was used to group data in a result
        /// set that contains multiple results (Values objects).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
