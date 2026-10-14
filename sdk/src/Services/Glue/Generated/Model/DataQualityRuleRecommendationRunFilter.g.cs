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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A filter for listing data quality recommendation runs.
    /// </summary>
    public partial class DataQualityRuleRecommendationRunFilter
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Filter based on a specified data source (Glue table).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter based on time for results started after provided time.
        /// </para>
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartedAfter property is set.
        /// </summary>
        internal bool IsSetStartedAfter() => this.StartedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter based on time for results started before provided time.
        /// </para>
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartedBefore property is set.
        /// </summary>
        internal bool IsSetStartedBefore() => this.StartedBefore.HasValue;
    }
}
