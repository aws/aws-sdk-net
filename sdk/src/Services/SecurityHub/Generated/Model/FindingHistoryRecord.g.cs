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
    /// A list of events that changed the specified finding during the specified time period.
    /// Each record represents a single finding change event.
    /// </summary>
    public partial class FindingHistoryRecord
    {
        /// <summary>
        /// Gets and sets the property FindingCreated. 
        /// <para>
        ///  Identifies whether the event marks the creation of a new finding. A value of <c>True</c>
        /// means that the finding is newly created. A value of <c>False</c> means that the finding
        /// isn’t newly created. 
        /// </para>
        /// </summary>
        public bool? FindingCreated { get; set; }

        /// <summary>
        /// Checks to see if the FindingCreated property is set.
        /// </summary>
        internal bool IsSetFindingCreated() => this.FindingCreated.HasValue;

        /// <summary>
        /// Gets and sets the property FindingIdentifier.
        /// </summary>
        public AwsSecurityFindingIdentifier FindingIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FindingIdentifier property is set.
        /// </summary>
        internal bool IsSetFindingIdentifier() => this.FindingIdentifier != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token for pagination purposes. Provide this token in the subsequent request to
        /// <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_GetFindingsHistory.html">
        /// <c>GetFindingsHistory</c> </a> to get up to an additional 100 results of history for
        /// the same finding that you specified in your initial request. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UpdateSource. 
        /// <para>
        ///  Identifies the source of the event that changed the finding. For example, an integrated
        /// Amazon Web Services service or third-party partner integration may call <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchImportFindings.html">
        /// <c>BatchImportFindings</c> </a>, or an Security Hub CSPM customer may call <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateFindings.html">
        /// <c>BatchUpdateFindings</c> </a>. 
        /// </para>
        /// </summary>
        public FindingHistoryUpdateSource UpdateSource { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSource property is set.
        /// </summary>
        internal bool IsSetUpdateSource() => this.UpdateSource != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  A timestamp that indicates when Security Hub CSPM processed the updated finding record.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        ///  An array of objects that provides details about the finding change event, including
        /// the Amazon Web Services Security Finding Format (ASFF) field that changed, the value
        /// of the field before the change, and the value of the field after the change. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingHistoryUpdate> Updates { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingHistoryUpdate>() : null;

        /// <summary>
        /// Checks to see if the Updates property is set.
        /// </summary>
        internal bool IsSetUpdates() => this.Updates != null && (this.Updates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
