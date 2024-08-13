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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
        private string _arn;
        private DateTime? _creationTime;
        private ErrorReportConfiguration _errorReportConfiguration;
        private ScheduledQueryRunStatus _lastRunStatus;
        private string _name;
        private DateTime? _nextInvocationTime;
        private DateTime? _previousInvocationTime;
        private ScheduledQueryState _state;
        private TargetDestination _targetDestination;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the scheduled query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Configuration for scheduled query error reporting.
        /// </para>
        /// </summary>
        public ErrorReportConfiguration ErrorReportConfiguration
        {
            get { return this._errorReportConfiguration; }
            set { this._errorReportConfiguration = value; }
        }

        // Check to see if ErrorReportConfiguration property is set
        internal bool IsSetErrorReportConfiguration()
        {
            return this._errorReportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// Status of the last scheduled query run.
        /// </para>
        /// </summary>
        public ScheduledQueryRunStatus LastRunStatus
        {
            get { return this._lastRunStatus; }
            set { this._lastRunStatus = value; }
        }

        // Check to see if LastRunStatus property is set
        internal bool IsSetLastRunStatus()
        {
            return this._lastRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextInvocationTime. 
        /// <para>
        /// The next time the scheduled query is to be run.
        /// </para>
        /// </summary>
        public DateTime? NextInvocationTime
        {
            get { return this._nextInvocationTime; }
            set { this._nextInvocationTime = value; }
        }

        // Check to see if NextInvocationTime property is set
        internal bool IsSetNextInvocationTime()
        {
            return this._nextInvocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousInvocationTime. 
        /// <para>
        /// The last time the scheduled query was run.
        /// </para>
        /// </summary>
        public DateTime? PreviousInvocationTime
        {
            get { return this._previousInvocationTime; }
            set { this._previousInvocationTime = value; }
        }

        // Check to see if PreviousInvocationTime property is set
        internal bool IsSetPreviousInvocationTime()
        {
            return this._previousInvocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledQueryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDestination. 
        /// <para>
        /// Target data source where final scheduled query result will be written.
        /// </para>
        /// </summary>
        public TargetDestination TargetDestination
        {
            get { return this._targetDestination; }
            set { this._targetDestination = value; }
        }

        // Check to see if TargetDestination property is set
        internal bool IsSetTargetDestination()
        {
            return this._targetDestination != null;
        }

    }
}