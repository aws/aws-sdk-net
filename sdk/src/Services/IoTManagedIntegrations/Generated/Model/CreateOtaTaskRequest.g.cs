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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOtaTask operation. Create an over-the-air
    /// (OTA) task to target a device.
    /// </summary>
    public partial class CreateOtaTaskRequest : AmazonIoTManagedIntegrationsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token. If you retry a request that completed successfully initially
        /// using the same client token and parameters, then the retry attempt will succeed without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property OtaMechanism. 
        /// <para>
        /// The deployment mechanism for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public OtaMechanism OtaMechanism { get; set; }

        /// <summary>
        /// Checks to see if the OtaMechanism property is set.
        /// </summary>
        internal bool IsSetOtaMechanism() => this.OtaMechanism != null;

        /// <summary>
        /// Gets and sets the property OtaSchedulingConfig.
        /// </summary>
        public OtaTaskSchedulingConfig OtaSchedulingConfig { get; set; }

        /// <summary>
        /// Checks to see if the OtaSchedulingConfig property is set.
        /// </summary>
        internal bool IsSetOtaSchedulingConfig() => this.OtaSchedulingConfig != null;

        /// <summary>
        /// Gets and sets the property OtaTargetQueryString. 
        /// <para>
        /// The query string to add things to the thing group.
        /// </para>
        /// </summary>
        public string OtaTargetQueryString { get; set; }

        /// <summary>
        /// Checks to see if the OtaTargetQueryString property is set.
        /// </summary>
        internal bool IsSetOtaTargetQueryString() => this.OtaTargetQueryString != null;

        /// <summary>
        /// Gets and sets the property OtaTaskExecutionRetryConfig.
        /// </summary>
        public OtaTaskExecutionRetryConfig OtaTaskExecutionRetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the OtaTaskExecutionRetryConfig property is set.
        /// </summary>
        internal bool IsSetOtaTaskExecutionRetryConfig() => this.OtaTaskExecutionRetryConfig != null;

        /// <summary>
        /// Gets and sets the property OtaType. 
        /// <para>
        /// The frequency type for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OtaType OtaType { get; set; }

        /// <summary>
        /// Checks to see if the OtaType property is set.
        /// </summary>
        internal bool IsSetOtaType() => this.OtaType != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The connection protocol the over-the-air (OTA) task uses to update the device.
        /// </para>
        /// </summary>
        public OtaProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The URL to the Amazon S3 bucket where the over-the-air (OTA) task is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string S3Url { get; set; }

        /// <summary>
        /// Checks to see if the S3Url property is set.
        /// </summary>
        internal bool IsSetS3Url() => this.S3Url != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key/value pairs that are used to manage the over-the-air (OTA) task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The device targeted for the over-the-air (OTA) task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Target { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null && (this.Target.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskConfigurationId. 
        /// <para>
        /// The identifier for the over-the-air (OTA) task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TaskConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the TaskConfigurationId property is set.
        /// </summary>
        internal bool IsSetTaskConfigurationId() => this.TaskConfigurationId != null;
    }
}
