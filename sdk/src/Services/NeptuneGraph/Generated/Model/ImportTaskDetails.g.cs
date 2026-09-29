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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Contains details about an import task.
    /// </summary>
    public partial class ImportTaskDetails
    {
        /// <summary>
        /// Gets and sets the property DictionaryEntryCount. 
        /// <para>
        /// The number of dictionary entries in the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DictionaryEntryCount { get; set; }

        /// <summary>
        /// Checks to see if the DictionaryEntryCount property is set.
        /// </summary>
        internal bool IsSetDictionaryEntryCount() => this.DictionaryEntryCount.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of errors encountered so far.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCount property is set.
        /// </summary>
        internal bool IsSetErrorCount() => this.ErrorCount.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about the errors that have been encountered.
        /// </para>
        /// </summary>
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The percentage progress so far.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercentage property is set.
        /// </summary>
        internal bool IsSetProgressPercentage() => this.ProgressPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time at which the import task started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatementCount. 
        /// <para>
        /// The number of statements in the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StatementCount { get; set; }

        /// <summary>
        /// Checks to see if the StatementCount property is set.
        /// </summary>
        internal bool IsSetStatementCount() => this.StatementCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeElapsedSeconds. 
        /// <para>
        /// Seconds elapsed since the import task started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TimeElapsedSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeElapsedSeconds property is set.
        /// </summary>
        internal bool IsSetTimeElapsedSeconds() => this.TimeElapsedSeconds.HasValue;
    }
}
