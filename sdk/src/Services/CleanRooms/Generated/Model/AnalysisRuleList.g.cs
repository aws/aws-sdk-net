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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A type of analysis rule that enables row-level analysis.
    /// </summary>
    public partial class AnalysisRuleList
    {
        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        ///  An indicator as to whether additional analyses (such as Clean Rooms ML) can be applied
        /// to the output of the direct query.
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAnalyses property is set.
        /// </summary>
        internal bool IsSetAdditionalAnalyses() => this.AdditionalAnalyses != null;

        /// <summary>
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        /// The logical operators (if any) that are to be used in an INNER JOIN match condition.
        /// Default is <c>AND</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2)]
        public List<string> AllowedJoinOperators { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedJoinOperators property is set.
        /// </summary>
        internal bool IsSetAllowedJoinOperators() => this.AllowedJoinOperators != null && (this.AllowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// Columns that can be used to join a configured table with the table of the member who
        /// can query and other members' configured tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> JoinColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JoinColumns property is set.
        /// </summary>
        internal bool IsSetJoinColumns() => this.JoinColumns != null && (this.JoinColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListColumns. 
        /// <para>
        /// Columns that can be listed in the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ListColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ListColumns property is set.
        /// </summary>
        internal bool IsSetListColumns() => this.ListColumns != null && (this.ListColumns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
