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
    /// Contains information about one step in the reasoning that GuardDuty followed during
    /// an investigation.
    /// </summary>
    public partial class InvestigationRecord
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which GuardDuty created the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Narrative. 
        /// <para>
        /// A plain-text explanation of the step. A narrative can span several paragraphs. Not
        /// every record includes a narrative.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Narrative { get; set; }

        /// <summary>
        /// Checks to see if the Narrative property is set.
        /// </summary>
        internal bool IsSetNarrative() => this.Narrative != null;

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The unique identifier of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property SupportingData. 
        /// <para>
        /// The structured details for the step. The member that is set matches the record type.
        /// <c>UPDATE</c> records never include supporting data, and records of other types don't
        /// always include it.
        /// </para>
        /// </summary>
        public SupportingData SupportingData { get; set; }

        /// <summary>
        /// Checks to see if the SupportingData property is set.
        /// </summary>
        internal bool IsSetSupportingData() => this.SupportingData != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title that describes the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the record. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UPDATE</c> – A progress milestone, such as the request that started the investigation
        /// or a response from GuardDuty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FETCH</c> – Data that GuardDuty retrieved for the investigation, such as a finding,
        /// a detector configuration, or a list of your member accounts. The record includes what
        /// GuardDuty requested and what it received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OBSERVATION</c> – A fact that GuardDuty noted about your environment, such as
        /// the affected resource, the activity on that resource, or your detection coverage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANALYSIS</c> – An assessment that GuardDuty derived from the data, such as a threat
        /// assessment, a comparison against normal behavior, or a process lineage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>METADATA</c> – Operational details about the investigation itself, such as how
        /// long the investigation took.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
