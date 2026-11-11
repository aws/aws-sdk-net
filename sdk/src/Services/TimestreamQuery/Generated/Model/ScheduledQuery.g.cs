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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Scheduled Query
    /// </summary>
    public partial class ScheduledQuery
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the scheduled query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Configuration for scheduled query error reporting.
        /// </para>
        /// </summary>
        public ErrorReportConfiguration ErrorReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportConfiguration property is set.
        /// </summary>
        internal bool IsSetErrorReportConfiguration() => this.ErrorReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// Status of the last scheduled query run.
        /// </para>
        /// </summary>
        public ScheduledQueryRunStatus LastRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastRunStatus property is set.
        /// </summary>
        internal bool IsSetLastRunStatus() => this.LastRunStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextInvocationTime. 
        /// <para>
        /// The next time the scheduled query is to be run.
        /// </para>
        /// </summary>
        public DateTime? NextInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the NextInvocationTime property is set.
        /// </summary>
        internal bool IsSetNextInvocationTime() => this.NextInvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property PreviousInvocationTime. 
        /// <para>
        /// The last time the scheduled query was run.
        /// </para>
        /// </summary>
        public DateTime? PreviousInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the PreviousInvocationTime property is set.
        /// </summary>
        internal bool IsSetPreviousInvocationTime() => this.PreviousInvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduledQueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetDestination. 
        /// <para>
        /// Target data source where final scheduled query result will be written.
        /// </para>
        /// </summary>
        public TargetDestination TargetDestination { get; set; }

        /// <summary>
        /// Checks to see if the TargetDestination property is set.
        /// </summary>
        internal bool IsSetTargetDestination() => this.TargetDestination != null;
    }
}
