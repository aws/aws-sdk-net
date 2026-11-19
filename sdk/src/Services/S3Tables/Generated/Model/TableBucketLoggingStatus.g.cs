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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The server access logging status of a table bucket. To enable logging, specify <c>loggingEnabled</c>.
    /// To disable logging, specify an empty <c>TableBucketLoggingStatus</c>.
    /// </summary>
    public partial class TableBucketLoggingStatus
    {
        /// <summary>
        /// Gets and sets the property LoggingEnabled. 
        /// <para>
        /// Where logs for the table bucket are delivered and how the log objects are named. Must
        /// be populated to enable logging.
        /// </para>
        /// </summary>
        public LoggingEnabled LoggingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LoggingEnabled property is set.
        /// </summary>
        internal bool IsSetLoggingEnabled() => this.LoggingEnabled != null;
    }
}
