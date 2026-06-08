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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
        private SessionCloudWatchLoggingConfiguration _cloudWatchLoggingConfiguration;
        private SessionManagedLoggingConfiguration _managedLoggingConfiguration;
        private SessionS3LoggingConfiguration _s3LoggingConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingConfiguration. 
        /// <para>
        /// The CloudWatch Logs configuration for the session.
        /// </para>
        /// </summary>
        public SessionCloudWatchLoggingConfiguration CloudWatchLoggingConfiguration
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
        /// The Amazon EMR-managed logging configuration for the session.
        /// </para>
        /// </summary>
        public SessionManagedLoggingConfiguration ManagedLoggingConfiguration
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
        /// The Amazon S3 logging configuration for the session.
        /// </para>
        /// </summary>
        public SessionS3LoggingConfiguration S3LoggingConfiguration
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