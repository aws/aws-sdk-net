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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Status and error information about the most recent crawl.
    /// </summary>
    public partial class LastCrawlInfo
    {
        private string _errorMessage;
        private string _logGroup;
        private string _logStream;
        private string _messagePrefix;
        private DateTime? _startTime;
        private LastCrawlStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If an error occurred, the error information about the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group for the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The log stream for the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogStream
        {
            get { return this._logStream; }
            set { this._logStream = value; }
        }

        // Check to see if LogStream property is set
        internal bool IsSetLogStream()
        {
            return this._logStream != null;
        }

        /// <summary>
        /// Gets and sets the property MessagePrefix. 
        /// <para>
        /// The prefix for a message about this crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MessagePrefix
        {
            get { return this._messagePrefix; }
            set { this._messagePrefix = value; }
        }

        // Check to see if MessagePrefix property is set
        internal bool IsSetMessagePrefix()
        {
            return this._messagePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the crawl started.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the last crawl.
        /// </para>
        /// </summary>
        public LastCrawlStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}