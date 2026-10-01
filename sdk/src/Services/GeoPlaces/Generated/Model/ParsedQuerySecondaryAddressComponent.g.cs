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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Information about a secondary address component parsed from the query text.
    /// </summary>
    public partial class ParsedQuerySecondaryAddressComponent
    {
        /// <summary>
        /// Gets and sets the property Designator. 
        /// <para>
        /// Secondary address designator provided in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4)]
        public string Designator { get; set; }

        /// <summary>
        /// Checks to see if the Designator property is set.
        /// </summary>
        internal bool IsSetDesignator() => this.Designator != null;

        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// End index of the parsed secondary address component in the query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Checks to see if the EndIndex property is set.
        /// </summary>
        internal bool IsSetEndIndex() => this.EndIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// Secondary address number provided in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 10)]
        public string Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number != null;

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// Start index of the parsed secondary address component in the query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Checks to see if the StartIndex property is set.
        /// </summary>
        internal bool IsSetStartIndex() => this.StartIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value of the parsed secondary address component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
