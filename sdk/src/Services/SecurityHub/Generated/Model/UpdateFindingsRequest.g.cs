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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFindings operation. <c>UpdateFindings</c>
    /// is a deprecated operation. Instead of <c>UpdateFindings</c>, use the <c>BatchUpdateFindings</c>
    /// operation. <para> The <c>UpdateFindings</c> operation updates the <c>Note</c> and
    /// <c>RecordState</c> of the Security Hub CSPM aggregated findings that the filter attributes
    /// specify. Any member account that can view the finding can also see the update to the
    /// finding. </para> <para> Finding updates made with <c>UpdateFindings</c> aren't persisted
    /// if the same finding is later updated by the finding provider through the <c>BatchImportFindings</c>
    /// operation. In addition, Security Hub CSPM doesn't record updates made with <c>UpdateFindings</c>
    /// in the finding history. </para>
    /// </summary>
    public partial class UpdateFindingsRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A collection of attributes that specify which findings you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AwsSecurityFindingFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// The updated note for the finding.
        /// </para>
        /// </summary>
        public NoteUpdate Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property RecordState. 
        /// <para>
        /// The updated record state for the finding.
        /// </para>
        /// </summary>
        public RecordState RecordState { get; set; }

        /// <summary>
        /// Checks to see if the RecordState property is set.
        /// </summary>
        internal bool IsSetRecordState() => this.RecordState != null;
    }
}
