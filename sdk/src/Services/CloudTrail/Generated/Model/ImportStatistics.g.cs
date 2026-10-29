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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Provides statistics for the specified <c>ImportID</c>. CloudTrail does not update
    /// import statistics in real-time. Returned values for parameters such as <c>EventsCompleted</c>
    /// may be lower than the actual value, because CloudTrail updates statistics incrementally
    /// over the course of the import.
    /// </summary>
    public partial class ImportStatistics
    {
        /// <summary>
        /// Gets and sets the property EventsCompleted. 
        /// <para>
        ///  The number of trail events imported into the event data store. 
        /// </para>
        /// </summary>
        public long? EventsCompleted { get; set; }

        /// <summary>
        /// Checks to see if the EventsCompleted property is set.
        /// </summary>
        internal bool IsSetEventsCompleted() => this.EventsCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property FailedEntries. 
        /// <para>
        ///  The number of failed entries. 
        /// </para>
        /// </summary>
        public long? FailedEntries { get; set; }

        /// <summary>
        /// Checks to see if the FailedEntries property is set.
        /// </summary>
        internal bool IsSetFailedEntries() => this.FailedEntries.HasValue;

        /// <summary>
        /// Gets and sets the property FilesCompleted. 
        /// <para>
        /// The number of log files that completed import.
        /// </para>
        /// </summary>
        public long? FilesCompleted { get; set; }

        /// <summary>
        /// Checks to see if the FilesCompleted property is set.
        /// </summary>
        internal bool IsSetFilesCompleted() => this.FilesCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixesCompleted. 
        /// <para>
        ///  The number of S3 prefixes that completed import. 
        /// </para>
        /// </summary>
        public long? PrefixesCompleted { get; set; }

        /// <summary>
        /// Checks to see if the PrefixesCompleted property is set.
        /// </summary>
        internal bool IsSetPrefixesCompleted() => this.PrefixesCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixesFound. 
        /// <para>
        ///  The number of S3 prefixes found for the import. 
        /// </para>
        /// </summary>
        public long? PrefixesFound { get; set; }

        /// <summary>
        /// Checks to see if the PrefixesFound property is set.
        /// </summary>
        internal bool IsSetPrefixesFound() => this.PrefixesFound.HasValue;
    }
}
