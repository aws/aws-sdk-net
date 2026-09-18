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
    /// The alpha-2 or alpha-3 character code for the country that the results will be present
    /// in.
    /// </summary>
    public partial class Country
    {
        /// <summary>
        /// Gets and sets the property Code2. 
        /// <para>
        /// Country, represented by its alpha 2-character code. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public string Code2 { get; set; }

        /// <summary>
        /// Checks to see if the Code2 property is set.
        /// </summary>
        internal bool IsSetCode2() => this.Code2 != null;

        /// <summary>
        /// Gets and sets the property Code3. 
        /// <para>
        /// Country, represented by its alpha t-character code. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string Code3 { get; set; }

        /// <summary>
        /// Checks to see if the Code3 property is set.
        /// </summary>
        internal bool IsSetCode3() => this.Code3 != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
