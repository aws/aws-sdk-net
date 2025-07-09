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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private BatchUpdateFindingsV2UnprocessedFindingErrorCode _errorCode;
        private string _errorMessage;
        private OcsfFindingIdentifier _findingIdentifier;
        private string _metadataUid;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Indicates the specific type of error preventing successful processing of a finding
        /// during a batch update operation.
        /// </para>
        /// </summary>
        public BatchUpdateFindingsV2UnprocessedFindingErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A detailed description of why a finding could not be processed during a batch update
        /// operation.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FindingIdentifier. 
        /// <para>
        /// The finding identifier of an unprocessed finding.
        /// </para>
        /// </summary>
        public OcsfFindingIdentifier FindingIdentifier
        {
            get { return this._findingIdentifier; }
            set { this._findingIdentifier = value; }
        }

        // Check to see if FindingIdentifier property is set
        internal bool IsSetFindingIdentifier()
        {
            return this._findingIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataUid. 
        /// <para>
        /// The metadata.uid of an unprocessed finding.
        /// </para>
        /// </summary>
        public string MetadataUid
        {
            get { return this._metadataUid; }
            set { this._metadataUid = value; }
        }

        // Check to see if MetadataUid property is set
        internal bool IsSetMetadataUid()
        {
            return this._metadataUid != null;
        }

    }
}