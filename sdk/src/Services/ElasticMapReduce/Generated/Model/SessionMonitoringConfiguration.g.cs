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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The monitoring configuration for a session. Controls where session logs are published.
    /// </summary>
    public partial class SessionMonitoringConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// The CloudWatch Logs configuration for the session.
        /// </para>
        /// </summary>
        public SessionCloudWatchLoggingConfiguration CloudWatchLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingConfiguration() => this.CloudWatchLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManagedLoggingConfiguration. 
        /// <para>
        /// The Amazon EMR-managed logging configuration for the session.
        /// </para>
        /// </summary>
        public SessionManagedLoggingConfiguration ManagedLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedLoggingConfiguration() => this.ManagedLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3LoggingConfiguration. 
        /// <para>
        /// The Amazon S3 logging configuration for the session.
        /// </para>
        /// </summary>
        public SessionS3LoggingConfiguration S3LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetS3LoggingConfiguration() => this.S3LoggingConfiguration != null;
    }
}
