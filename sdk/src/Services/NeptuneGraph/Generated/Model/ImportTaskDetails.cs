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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Contains details about an import task.
    /// </summary>
    public partial class ImportTaskDetails
    {
        private long? _dictionaryEntryCount;
        private int? _errorCount;
        private string _errorDetails;
        private int? _progressPercentage;
        private DateTime? _startTime;
        private long? _statementCount;
        private string _status;
        private long? _timeElapsedSeconds;

        /// <summary>
        /// Gets and sets the property DictionaryEntryCount. 
        /// <para>
        /// The number of dictionary entries in the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? DictionaryEntryCount
        {
            get { return this._dictionaryEntryCount; }
            set { this._dictionaryEntryCount = value; }
        }

        // Check to see if DictionaryEntryCount property is set
        internal bool IsSetDictionaryEntryCount()
        {
            return this._dictionaryEntryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of errors encountered so far.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ErrorCount
        {
            get { return this._errorCount; }
            set { this._errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this._errorCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about the errors that have been encountered.
        /// </para>
        /// </summary>
        public string ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The percentage progress so far.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ProgressPercentage
        {
            get { return this._progressPercentage; }
            set { this._progressPercentage = value; }
        }

        // Check to see if ProgressPercentage property is set
        internal bool IsSetProgressPercentage()
        {
            return this._progressPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time at which the import task started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatementCount. 
        /// <para>
        /// The number of statements in the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? StatementCount
        {
            get { return this._statementCount; }
            set { this._statementCount = value; }
        }

        // Check to see if StatementCount property is set
        internal bool IsSetStatementCount()
        {
            return this._statementCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TimeElapsedSeconds. 
        /// <para>
        /// Seconds elapsed since the import task started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TimeElapsedSeconds
        {
            get { return this._timeElapsedSeconds; }
            set { this._timeElapsedSeconds = value; }
        }

        // Check to see if TimeElapsedSeconds property is set
        internal bool IsSetTimeElapsedSeconds()
        {
            return this._timeElapsedSeconds.HasValue; 
        }

    }
}