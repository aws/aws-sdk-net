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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOtaTask operation.
    /// Create an over-the-air (OTA) task to update a device.
    /// </summary>
    public partial class CreateOtaTaskRequest : AmazonIoTManagedIntegrationsRequest
    {
        private string _clientToken;
        private string _description;
        private OtaMechanism _otaMechanism;
        private OtaTaskSchedulingConfig _otaSchedulingConfig;
        private string _otaTargetQueryString;
        private OtaTaskExecutionRetryConfig _otaTaskExecutionRetryConfig;
        private OtaType _otaType;
        private OtaProtocol _protocol;
        private string _s3Url;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _target = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _taskConfigurationId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token. If you retry a request that completed successfully initially
        /// using the same client token and parameters, then the retry attempt will succeed without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property OtaMechanism. 
        /// <para>
        /// The deployment mechanism for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public OtaMechanism OtaMechanism
        {
            get { return this._otaMechanism; }
            set { this._otaMechanism = value; }
        }

        // Check to see if OtaMechanism property is set
        internal bool IsSetOtaMechanism()
        {
            return this._otaMechanism != null;
        }

        /// <summary>
        /// Gets and sets the property OtaSchedulingConfig.
        /// </summary>
        public OtaTaskSchedulingConfig OtaSchedulingConfig
        {
            get { return this._otaSchedulingConfig; }
            set { this._otaSchedulingConfig = value; }
        }

        // Check to see if OtaSchedulingConfig property is set
        internal bool IsSetOtaSchedulingConfig()
        {
            return this._otaSchedulingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OtaTargetQueryString. 
        /// <para>
        /// The query string to add things to the thing group.
        /// </para>
        /// </summary>
        public string OtaTargetQueryString
        {
            get { return this._otaTargetQueryString; }
            set { this._otaTargetQueryString = value; }
        }

        // Check to see if OtaTargetQueryString property is set
        internal bool IsSetOtaTargetQueryString()
        {
            return this._otaTargetQueryString != null;
        }

        /// <summary>
        /// Gets and sets the property OtaTaskExecutionRetryConfig.
        /// </summary>
        public OtaTaskExecutionRetryConfig OtaTaskExecutionRetryConfig
        {
            get { return this._otaTaskExecutionRetryConfig; }
            set { this._otaTaskExecutionRetryConfig = value; }
        }

        // Check to see if OtaTaskExecutionRetryConfig property is set
        internal bool IsSetOtaTaskExecutionRetryConfig()
        {
            return this._otaTaskExecutionRetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OtaType. 
        /// <para>
        /// The frequency type for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OtaType OtaType
        {
            get { return this._otaType; }
            set { this._otaType = value; }
        }

        // Check to see if OtaType property is set
        internal bool IsSetOtaType()
        {
            return this._otaType != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The connection protocol the over-the-air (OTA) task uses to update the device.
        /// </para>
        /// </summary>
        public OtaProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The URL to the Amazon S3 bucket where the over-the-air (OTA) task is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The device targeted for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public List<string> Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null && (this._target.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskConfigurationId. 
        /// <para>
        /// The identifier for the over-the-air (OTA) task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TaskConfigurationId
        {
            get { return this._taskConfigurationId; }
            set { this._taskConfigurationId = value; }
        }

        // Check to see if TaskConfigurationId property is set
        internal bool IsSetTaskConfigurationId()
        {
            return this._taskConfigurationId != null;
        }

    }
}