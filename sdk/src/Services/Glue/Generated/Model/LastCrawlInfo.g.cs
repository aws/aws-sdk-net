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
    /// Status and error information about the most recent crawl.
    /// </summary>
    public partial class LastCrawlInfo
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If an error occurred, the error information about the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The log group for the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroup { get; set; }

        /// <summary>
        /// Checks to see if the LogGroup property is set.
        /// </summary>
        internal bool IsSetLogGroup() => this.LogGroup != null;

        /// <summary>
        /// Gets and sets the property LogStream. 
        /// <para>
        /// The log stream for the last crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogStream { get; set; }

        /// <summary>
        /// Checks to see if the LogStream property is set.
        /// </summary>
        internal bool IsSetLogStream() => this.LogStream != null;

        /// <summary>
        /// Gets and sets the property MessagePrefix. 
        /// <para>
        /// The prefix for a message about this crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MessagePrefix { get; set; }

        /// <summary>
        /// Checks to see if the MessagePrefix property is set.
        /// </summary>
        internal bool IsSetMessagePrefix() => this.MessagePrefix != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the crawl started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the last crawl.
        /// </para>
        /// </summary>
        public LastCrawlStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
