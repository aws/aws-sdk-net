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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies the configuration information needed to customize how collapsed search result
    /// groups expand.
    /// </summary>
    public partial class ExpandConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxExpandedResultsPerItem. 
        /// <para>
        /// The number of expanded results to show per collapsed primary document. For instance,
        /// if you set this value to 3, then at most 3 results per collapsed group will be displayed.
        /// </para>
        /// </summary>
        public int? MaxExpandedResultsPerItem { get; set; }

        /// <summary>
        /// Checks to see if the MaxExpandedResultsPerItem property is set.
        /// </summary>
        internal bool IsSetMaxExpandedResultsPerItem() => this.MaxExpandedResultsPerItem.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResultItemsToExpand. 
        /// <para>
        /// The number of collapsed search result groups to expand. If you set this value to 10,
        /// for example, only the first 10 out of 100 result groups will have expand functionality.
        /// 
        /// </para>
        /// </summary>
        public int? MaxResultItemsToExpand { get; set; }

        /// <summary>
        /// Checks to see if the MaxResultItemsToExpand property is set.
        /// </summary>
        internal bool IsSetMaxResultItemsToExpand() => this.MaxResultItemsToExpand.HasValue;
    }
}
