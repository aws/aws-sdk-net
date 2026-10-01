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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains filters applied when performing the Message Insights export.
    /// </summary>
    public partial class MessageInsightsDataSource
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Represents the end date for the export interval as a timestamp. The end date is inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Filters for results to be excluded from the export file.
        /// </para>
        /// </summary>
        public MessageInsightsFilters Exclude { get; set; }

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Filters for results to be included in the export file.
        /// </para>
        /// </summary>
        public MessageInsightsFilters Include { get; set; }

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify <c>MaxResults</c>, the export returns a maximum of 1,000 results.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Represents the start date for the export interval as a timestamp. The start date is
        /// inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
