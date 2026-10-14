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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains the configuration settings for managed log persistence, delivering logs to
    /// Amazon S3 buckets, Amazon CloudWatch log groups etc.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// Configuration settings for delivering logs to Amazon CloudWatch log groups. 
        /// </para>
        /// </summary>
        public CloudWatchLoggingConfiguration CloudWatchLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingConfiguration() => this.CloudWatchLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManagedLoggingConfiguration. 
        /// <para>
        /// Configuration settings for managed log persistence. 
        /// </para>
        /// </summary>
        public ManagedLoggingConfiguration ManagedLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedLoggingConfiguration() => this.ManagedLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3LoggingConfiguration. 
        /// <para>
        /// Configuration settings for delivering logs to Amazon S3 buckets. 
        /// </para>
        /// </summary>
        public S3LoggingConfiguration S3LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetS3LoggingConfiguration() => this.S3LoggingConfiguration != null;
    }
}
