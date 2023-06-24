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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configuration setting for monitoring.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        private ManagedPersistenceMonitoringConfiguration _managedPersistenceMonitoringConfiguration;
        private S3MonitoringConfiguration _s3MonitoringConfiguration;

        /// <summary>
        /// Gets and sets the property ManagedPersistenceMonitoringConfiguration. 
        /// <para>
        /// The managed log persistence configuration for a job run.
        /// </para>
        /// </summary>
        public ManagedPersistenceMonitoringConfiguration ManagedPersistenceMonitoringConfiguration
        {
            get { return this._managedPersistenceMonitoringConfiguration; }
            set { this._managedPersistenceMonitoringConfiguration = value; }
        }

        // Check to see if ManagedPersistenceMonitoringConfiguration property is set
        internal bool IsSetManagedPersistenceMonitoringConfiguration()
        {
            return this._managedPersistenceMonitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3MonitoringConfiguration. 
        /// <para>
        /// The Amazon S3 configuration for monitoring log publishing.
        /// </para>
        /// </summary>
        public S3MonitoringConfiguration S3MonitoringConfiguration
        {
            get { return this._s3MonitoringConfiguration; }
            set { this._s3MonitoringConfiguration = value; }
        }

        // Check to see if S3MonitoringConfiguration property is set
        internal bool IsSetS3MonitoringConfiguration()
        {
            return this._s3MonitoringConfiguration != null;
        }

    }
}