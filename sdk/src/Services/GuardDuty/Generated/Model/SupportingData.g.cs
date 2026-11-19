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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the structured details for an investigation record. Only the member that
    /// matches the record type is set.
    /// </summary>
    public partial class SupportingData
    {
        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// Details about an assessment that GuardDuty derived from the data. Set for <c>ANALYSIS</c>
        /// records.
        /// </para>
        /// </summary>
        public AnalysisRecord Analysis { get; set; }

        /// <summary>
        /// Checks to see if the Analysis property is set.
        /// </summary>
        internal bool IsSetAnalysis() => this.Analysis != null;

        /// <summary>
        /// Gets and sets the property Fetch. 
        /// <para>
        /// Details about data that GuardDuty retrieved. Set for <c>FETCH</c> records.
        /// </para>
        /// </summary>
        public FetchRecord Fetch { get; set; }

        /// <summary>
        /// Checks to see if the Fetch property is set.
        /// </summary>
        internal bool IsSetFetch() => this.Fetch != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Operational details about the investigation. Set for <c>METADATA</c> records.
        /// </para>
        /// </summary>
        public MetadataRecord Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Observation. 
        /// <para>
        /// Details about a fact that GuardDuty noted about your environment. Set for <c>OBSERVATION</c>
        /// records.
        /// </para>
        /// </summary>
        public ObservationRecord Observation { get; set; }

        /// <summary>
        /// Checks to see if the Observation property is set.
        /// </summary>
        internal bool IsSetObservation() => this.Observation != null;
    }
}
