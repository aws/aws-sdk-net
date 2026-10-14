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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The run configuration for a data quality result.
    /// </summary>
    public partial class DataQualityConfigurationV2
    {
        /// <summary>
        /// Gets and sets the property ObservationMode. 
        /// <para>
        /// The observation mode for the run. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SCHEDULED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIXED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ObservationMode ObservationMode { get; set; }

        /// <summary>
        /// Checks to see if the ObservationMode property is set.
        /// </summary>
        internal bool IsSetObservationMode() => this.ObservationMode != null;

        /// <summary>
        /// Gets and sets the property ObservationsEnabled. 
        /// <para>
        /// Whether observations are enabled for the run. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ObservationConfiguration ObservationsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ObservationsEnabled property is set.
        /// </summary>
        internal bool IsSetObservationsEnabled() => this.ObservationsEnabled != null;
    }
}
