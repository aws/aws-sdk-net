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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private CloudWatchLoggingConfiguration _cloudWatchLoggingConfiguration;
        private ManagedLoggingConfiguration _managedLoggingConfiguration;
        private S3LoggingConfiguration _s3LoggingConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// Configuration settings for delivering logs to Amazon CloudWatch log groups. 
        /// </para>
        /// </summary>
        public CloudWatchLoggingConfiguration CloudWatchLoggingConfiguration
        {
            get { return this._cloudWatchLoggingConfiguration; }
            set { this._cloudWatchLoggingConfiguration = value; }
        }

        // Check to see if CloudWatchLoggingConfiguration property is set
        internal bool IsSetCloudWatchLoggingConfiguration()
        {
            return this._cloudWatchLoggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedLoggingConfiguration. 
        /// <para>
        /// Configuration settings for managed log persistence. 
        /// </para>
        /// </summary>
        public ManagedLoggingConfiguration ManagedLoggingConfiguration
        {
            get { return this._managedLoggingConfiguration; }
            set { this._managedLoggingConfiguration = value; }
        }

        // Check to see if ManagedLoggingConfiguration property is set
        internal bool IsSetManagedLoggingConfiguration()
        {
            return this._managedLoggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3LoggingConfiguration. 
        /// <para>
        /// Configuration settings for delivering logs to Amazon S3 buckets. 
        /// </para>
        /// </summary>
        public S3LoggingConfiguration S3LoggingConfiguration
        {
            get { return this._s3LoggingConfiguration; }
            set { this._s3LoggingConfiguration = value; }
        }

        // Check to see if S3LoggingConfiguration property is set
        internal bool IsSetS3LoggingConfiguration()
        {
            return this._s3LoggingConfiguration != null;
        }

    }
}