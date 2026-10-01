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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains information about one competitor in a fixture. It is used in the FixtureSummary
    /// that is in the SearchFixtures response.
    /// </summary>
    public partial class Competitor
    {
        /// <summary>
        /// Gets and sets the property IsHome. 
        /// <para>
        /// Specifies whether this competitor is the home side in the fixture. If true, this competitor
        /// is the home side. If false, this competitor is the away side. 
        /// </para>
        /// </summary>
        public bool? IsHome { get; set; }

        /// <summary>
        /// Checks to see if the IsHome property is set.
        /// </summary>
        internal bool IsSetIsHome() => this.IsHome.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the competitor, as provided by the data source.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
