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
    /// Represents finding statistics grouped by <c>GroupedByField</c>.
    /// </summary>
    public partial class GroupByResult
    {
        /// <summary>
        /// Gets and sets the property GroupByField. 
        /// <para>
        /// The attribute by which filtered security findings should be grouped.
        /// </para>
        /// </summary>
        public string GroupByField { get; set; }

        /// <summary>
        /// Checks to see if the GroupByField property is set.
        /// </summary>
        internal bool IsSetGroupByField() => this.GroupByField != null;

        /// <summary>
        /// Gets and sets the property GroupByValues. 
        /// <para>
        /// An array of grouped values and their respective counts for each <c>GroupByField</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GroupByValue> GroupByValues { get; set; } = AWSConfigs.InitializeCollections ? new List<GroupByValue>() : null;

        /// <summary>
        /// Checks to see if the GroupByValues property is set.
        /// </summary>
        internal bool IsSetGroupByValues() => this.GroupByValues != null && (this.GroupByValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
