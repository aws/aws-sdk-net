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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the integration of DevOps Guru with another Amazon Web Services
    /// service, such as Amazon Web Services Systems Manager.
    /// </summary>
    public partial class ServiceIntegrationConfig
    {
        private KMSServerSideEncryptionIntegration _kmsServerSideEncryption;
        private LogsAnomalyDetectionIntegration _logsAnomalyDetection;
        private OpsCenterIntegration _opsCenter;

        /// <summary>
        /// Gets and sets the property KMSServerSideEncryption. 
        /// <para>
        ///  Information about whether DevOps Guru is configured to encrypt server-side data using
        /// KMS. 
        /// </para>
        /// </summary>
        public KMSServerSideEncryptionIntegration KMSServerSideEncryption
        {
            get { return this._kmsServerSideEncryption; }
            set { this._kmsServerSideEncryption = value; }
        }

        // Check to see if KMSServerSideEncryption property is set
        internal bool IsSetKMSServerSideEncryption()
        {
            return this._kmsServerSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property LogsAnomalyDetection. 
        /// <para>
        ///  Information about whether DevOps Guru is configured to perform log anomaly detection
        /// on Amazon CloudWatch log groups. 
        /// </para>
        /// </summary>
        public LogsAnomalyDetectionIntegration LogsAnomalyDetection
        {
            get { return this._logsAnomalyDetection; }
            set { this._logsAnomalyDetection = value; }
        }

        // Check to see if LogsAnomalyDetection property is set
        internal bool IsSetLogsAnomalyDetection()
        {
            return this._logsAnomalyDetection != null;
        }

        /// <summary>
        /// Gets and sets the property OpsCenter. 
        /// <para>
        ///  Information about whether DevOps Guru is configured to create an OpsItem in Amazon
        /// Web Services Systems Manager OpsCenter for each created insight. 
        /// </para>
        /// </summary>
        public OpsCenterIntegration OpsCenter
        {
            get { return this._opsCenter; }
            set { this._opsCenter = value; }
        }

        // Check to see if OpsCenter property is set
        internal bool IsSetOpsCenter()
        {
            return this._opsCenter != null;
        }

    }
}