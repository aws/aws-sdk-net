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
    /// Defines a condition under which a trigger fires.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property CrawlState. 
        /// <para>
        /// The state of the crawler to which this condition applies.
        /// </para>
        /// </summary>
        public CrawlState CrawlState { get; set; }

        /// <summary>
        /// Checks to see if the CrawlState property is set.
        /// </summary>
        internal bool IsSetCrawlState() => this.CrawlState != null;

        /// <summary>
        /// Gets and sets the property CrawlerName. 
        /// <para>
        /// The name of the crawler to which this condition applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CrawlerName { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerName property is set.
        /// </summary>
        internal bool IsSetCrawlerName() => this.CrawlerName != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job whose <c>JobRuns</c> this condition applies to, and on which this
        /// trigger waits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LogicalOperator. 
        /// <para>
        /// A logical operator.
        /// </para>
        /// </summary>
        public LogicalOperator LogicalOperator { get; set; }

        /// <summary>
        /// Checks to see if the LogicalOperator property is set.
        /// </summary>
        internal bool IsSetLogicalOperator() => this.LogicalOperator != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition state. Currently, the only job states that a trigger can listen for
        /// are <c>SUCCEEDED</c>, <c>STOPPED</c>, <c>FAILED</c>, and <c>TIMEOUT</c>. The only
        /// crawler states that a trigger can listen for are <c>SUCCEEDED</c>, <c>FAILED</c>,
        /// and <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public JobRunState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
