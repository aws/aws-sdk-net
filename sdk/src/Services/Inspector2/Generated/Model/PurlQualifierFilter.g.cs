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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that describes the details of a package URL (purl) qualifier filter.
    /// </summary>
    public partial class PurlQualifierFilter
    {
        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The operator to use when comparing values in the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MapComparison Comparison { get; set; }

        /// <summary>
        /// Checks to see if the Comparison property is set.
        /// </summary>
        internal bool IsSetComparison() => this.Comparison != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The package URL (purl) qualifier key to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PurlQualifierKey Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The package URL (purl) qualifier value to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
