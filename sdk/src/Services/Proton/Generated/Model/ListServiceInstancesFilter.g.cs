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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// A filtering criterion to scope down the result list of the <a>ListServiceInstances</a>
    /// action.
    /// </summary>
    public partial class ListServiceInstancesFilter
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of a filtering criterion.
        /// </para>
        /// </summary>
        public ListServiceInstancesFilterBy Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value to filter by.
        /// </para>
        ///  
        /// <para>
        /// With the date/time keys (<c>*At{Before,After}</c>), the value is a valid <a href="https://datatracker.ietf.org/doc/html/rfc3339.html">RFC
        /// 3339</a> string with no UTC offset and with an optional fractional precision (for
        /// example, <c>1985-04-12T23:20:50.52Z</c>).
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
