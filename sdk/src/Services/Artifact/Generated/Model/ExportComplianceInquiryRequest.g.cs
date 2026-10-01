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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the ExportComplianceInquiry operation. Export a compliance
    /// inquiry report.
    /// </summary>
    public partial class ExportComplianceInquiryRequest : AmazonArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property ComplianceInquiryId. 
        /// <para>
        /// Unique resource ID for the compliance inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComplianceInquiryId { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceInquiryId property is set.
        /// </summary>
        internal bool IsSetComplianceInquiryId() => this.ComplianceInquiryId != null;

        /// <summary>
        /// Gets and sets the property IncludeCitations. 
        /// <para>
        /// When true, include citations in the exported document.
        /// </para>
        /// </summary>
        public bool? IncludeCitations { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCitations property is set.
        /// </summary>
        internal bool IsSetIncludeCitations() => this.IncludeCitations.HasValue;

        /// <summary>
        /// Gets and sets the property QueryIdentifiers. 
        /// <para>
        /// List of query identifiers to include in the export.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the QueryIdentifiers property is set.
        /// </summary>
        internal bool IsSetQueryIdentifiers() => this.QueryIdentifiers != null && (this.QueryIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
