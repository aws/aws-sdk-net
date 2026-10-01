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

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Container for the values required to configure logging for the pipeline. If you don't
    /// specify these values, OpenSearch Ingestion will not publish logs from your application
    /// to CloudWatch Logs.
    /// </summary>
    public partial class LogPublishingOptions
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogDestination. 
        /// <para>
        /// The destination for OpenSearch Ingestion logs sent to Amazon CloudWatch Logs. This
        /// parameter is required if <c>IsLoggingEnabled</c> is set to <c>true</c>.
        /// </para>
        /// </summary>
        public CloudWatchLogDestination CloudWatchLogDestination { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogDestination property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogDestination() => this.CloudWatchLogDestination != null;

        /// <summary>
        /// Gets and sets the property IsLoggingEnabled. 
        /// <para>
        /// Whether logs should be published.
        /// </para>
        /// </summary>
        public bool? IsLoggingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsLoggingEnabled property is set.
        /// </summary>
        internal bool IsSetIsLoggingEnabled() => this.IsLoggingEnabled.HasValue;
    }
}
