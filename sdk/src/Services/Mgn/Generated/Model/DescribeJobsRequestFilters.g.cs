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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request to describe Job log filters.
    /// </summary>
    public partial class DescribeJobsRequestFilters
    {
        /// <summary>
        /// Gets and sets the property FromDate. 
        /// <para>
        /// Request to describe Job log filters by date.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string FromDate { get; set; }

        /// <summary>
        /// Checks to see if the FromDate property is set.
        /// </summary>
        internal bool IsSetFromDate() => this.FromDate != null;

        /// <summary>
        /// Gets and sets the property JobIDs. 
        /// <para>
        /// Request to describe Job log filters by job ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> JobIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JobIDs property is set.
        /// </summary>
        internal bool IsSetJobIDs() => this.JobIDs != null && (this.JobIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToDate. 
        /// <para>
        /// Request to describe job log items by last date.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string ToDate { get; set; }

        /// <summary>
        /// Checks to see if the ToDate property is set.
        /// </summary>
        internal bool IsSetToDate() => this.ToDate != null;
    }
}
