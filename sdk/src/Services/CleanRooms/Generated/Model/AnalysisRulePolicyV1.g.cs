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
    /// Controls on the query specifications that can be run on configured table.
    /// </summary>
    public partial class AnalysisRulePolicyV1
    {
        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// Analysis rule type that enables only aggregation queries on a configured table.
        /// </para>
        /// </summary>
        public AnalysisRuleAggregation Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// Analysis rule type that enables custom SQL queries on a configured table.
        /// </para>
        /// </summary>
        public AnalysisRuleCustom Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property IdMappingTable. 
        /// <para>
        /// The ID mapping table.
        /// </para>
        /// </summary>
        public AnalysisRuleIdMappingTable IdMappingTable { get; set; }

        /// <summary>
        /// Checks to see if the IdMappingTable property is set.
        /// </summary>
        internal bool IsSetIdMappingTable() => this.IdMappingTable != null;

        /// <summary>
        /// Gets and sets the property List. 
        /// <para>
        /// Analysis rule type that enables only list queries on a configured table.
        /// </para>
        /// </summary>
        public AnalysisRuleList List { get; set; }

        /// <summary>
        /// Checks to see if the List property is set.
        /// </summary>
        internal bool IsSetList() => this.List != null;
    }
}
