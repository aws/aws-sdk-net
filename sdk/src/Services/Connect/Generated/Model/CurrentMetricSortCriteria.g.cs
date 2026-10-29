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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The way to sort the resulting response based on metrics. By default resources are
    /// sorted based on <c>AGENTS_ONLINE</c>, <c>DESCENDING</c>. The metric collection is
    /// sorted based on the input metrics.
    /// </summary>
    public partial class CurrentMetricSortCriteria
    {
        /// <summary>
        /// Gets and sets the property SortByMetric.
        /// </summary>
        public CurrentMetricName SortByMetric { get; set; }

        /// <summary>
        /// Checks to see if the SortByMetric property is set.
        /// </summary>
        internal bool IsSetSortByMetric() => this.SortByMetric != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The way to sort.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
