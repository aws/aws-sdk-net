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
    /// Container for the parameters to the BatchUpdateFindingsV2 operation.
    /// Used by customers to update information about their investigation into a finding.
    /// Requested by delegated administrator accounts or member accounts. Delegated administrator
    /// accounts can update findings for their account and their member accounts. Member accounts
    /// can update findings for their account. <c>BatchUpdateFindings</c> and <c>BatchUpdateFindingV2</c>
    /// both use <c>securityhub:BatchUpdateFindings</c> in the <c>Action</c> element of an
    /// IAM policy statement. You must have permission to perform the <c>securityhub:BatchUpdateFindings</c>
    /// action. Updates from <c>BatchUpdateFindingsV2</c> don't affect the value of f<c>inding_info.modified_time</c>,
    /// <c>finding_info.modified_time_dt</c>, <c>time</c>, <c>time_dt for a finding</c>. This
    /// API is in private preview and subject to change.
    /// </summary>
    public partial class BatchUpdateFindingsV2Request : AmazonSecurityHubRequest
    {
        private string _comment;
        private List<OcsfFindingIdentifier> _findingIdentifiers = AWSConfigs.InitializeCollections ? new List<OcsfFindingIdentifier>() : null;
        private List<string> _metadataUids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _severityId;
        private int? _statusId;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The updated value for a user provided comment about the finding. Minimum character
        /// length 1. Maximum character length 512.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property FindingIdentifiers. 
        /// <para>
        /// Provides information to identify a specific V2 finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<OcsfFindingIdentifier> FindingIdentifiers
        {
            get { return this._findingIdentifiers; }
            set { this._findingIdentifiers = value; }
        }

        // Check to see if FindingIdentifiers property is set
        internal bool IsSetFindingIdentifiers()
        {
            return this._findingIdentifiers != null && (this._findingIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetadataUids. 
        /// <para>
        /// The list of finding <c>metadata.uid</c> to indicate findings to update. Finding <c>metadata.uid</c>
        /// is a globally unique identifier associated with the finding. Customers cannot use
        /// <c>MetadataUids</c> together with <c>FindingIdentifiers</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> MetadataUids
        {
            get { return this._metadataUids; }
            set { this._metadataUids = value; }
        }

        // Check to see if MetadataUids property is set
        internal bool IsSetMetadataUids()
        {
            return this._metadataUids != null && (this._metadataUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SeverityId. 
        /// <para>
        /// The updated value for the normalized severity identifier. The severity ID is an integer
        /// with the allowed enum values [0, 1, 2, 3, 4, 5, 99]. When customer provides the updated
        /// severity ID, the string sibling severity will automatically be updated in the finding.
        /// </para>
        /// </summary>
        public int? SeverityId
        {
            get { return this._severityId; }
            set { this._severityId = value; }
        }

        // Check to see if SeverityId property is set
        internal bool IsSetSeverityId()
        {
            return this._severityId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusId. 
        /// <para>
        /// The updated value for the normalized status identifier. The status ID is an integer
        /// with the allowed enum values [0, 1, 2, 3, 4, 5, 6, 99]. When customer provides the
        /// updated status ID, the string sibling status will automatically be updated in the
        /// finding.
        /// </para>
        /// </summary>
        public int? StatusId
        {
            get { return this._statusId; }
            set { this._statusId = value; }
        }

        // Check to see if StatusId property is set
        internal bool IsSetStatusId()
        {
            return this._statusId.HasValue; 
        }

    }
}