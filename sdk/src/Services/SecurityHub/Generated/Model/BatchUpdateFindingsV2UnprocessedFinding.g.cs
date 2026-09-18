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
    /// The list of findings that were not updated.
    /// </summary>
    public partial class BatchUpdateFindingsV2UnprocessedFinding
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Indicates the specific type of error preventing successful processing of a finding
        /// during a batch update operation.
        /// </para>
        /// </summary>
        public BatchUpdateFindingsV2UnprocessedFindingErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A detailed description of why a finding could not be processed during a batch update
        /// operation.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FindingIdentifier. 
        /// <para>
        /// The finding identifier of an unprocessed finding.
        /// </para>
        /// </summary>
        public OcsfFindingIdentifier FindingIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FindingIdentifier property is set.
        /// </summary>
        internal bool IsSetFindingIdentifier() => this.FindingIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetadataUid. 
        /// <para>
        /// The metadata.uid of an unprocessed finding.
        /// </para>
        /// </summary>
        public string MetadataUid { get; set; }

        /// <summary>
        /// Checks to see if the MetadataUid property is set.
        /// </summary>
        internal bool IsSetMetadataUid() => this.MetadataUid != null;
    }
}
