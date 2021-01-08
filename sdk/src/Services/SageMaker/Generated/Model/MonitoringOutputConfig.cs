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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The output configuration for monitoring jobs.
    /// </summary>
    public partial class MonitoringOutputConfig
    {
        private string _kmsKeyId;
        private List<MonitoringOutput> _monitoringOutputs = new List<MonitoringOutput>();

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt
        /// the model artifacts at rest using Amazon S3 server-side encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringOutputs. 
        /// <para>
        /// Monitoring outputs for monitoring jobs. This is where the output of the periodic monitoring
        /// jobs is uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<MonitoringOutput> MonitoringOutputs
        {
            get { return this._monitoringOutputs; }
            set { this._monitoringOutputs = value; }
        }

        // Check to see if MonitoringOutputs property is set
        internal bool IsSetMonitoringOutputs()
        {
            return this._monitoringOutputs != null && this._monitoringOutputs.Count > 0; 
        }

    }
}