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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateService operation.
    /// Update an App Runner service. You can update the source configuration and instance
    /// configuration of the service. You can also update the ARN of the auto scaling configuration
    /// resource that's associated with the service. However, you can't change the name or
    /// the encryption configuration of the service. These can be set only when you create
    /// the service.
    /// 
    ///  
    /// <para>
    /// To update the tags applied to your service, use the separate actions <a>TagResource</a>
    /// and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous operation. On a successful call, you can use the returned
    /// <c>OperationId</c> and the <a>ListOperations</a> call to track the operation's progress.
    /// </para>
    /// </summary>
    public partial class UpdateServiceRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationArn;
        private HealthCheckConfiguration _healthCheckConfiguration;
        private InstanceConfiguration _instanceConfiguration;
        private NetworkConfiguration _networkConfiguration;
        private ServiceObservabilityConfiguration _observabilityConfiguration;
        private string _serviceArn;
        private SourceConfiguration _sourceConfiguration;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an App Runner automatic scaling configuration resource
        /// that you want to associate with the App Runner service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string AutoScalingConfigurationArn
        {
            get { return this._autoScalingConfigurationArn; }
            set { this._autoScalingConfigurationArn = value; }
        }

        // Check to see if AutoScalingConfigurationArn property is set
        internal bool IsSetAutoScalingConfigurationArn()
        {
            return this._autoScalingConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckConfiguration. 
        /// <para>
        /// The settings for the health check that App Runner performs to monitor the health of
        /// the App Runner service.
        /// </para>
        /// </summary>
        public HealthCheckConfiguration HealthCheckConfiguration
        {
            get { return this._healthCheckConfiguration; }
            set { this._healthCheckConfiguration = value; }
        }

        // Check to see if HealthCheckConfiguration property is set
        internal bool IsSetHealthCheckConfiguration()
        {
            return this._healthCheckConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConfiguration. 
        /// <para>
        /// The runtime configuration to apply to instances (scaling units) of your service.
        /// </para>
        /// </summary>
        public InstanceConfiguration InstanceConfiguration
        {
            get { return this._instanceConfiguration; }
            set { this._instanceConfiguration = value; }
        }

        // Check to see if InstanceConfiguration property is set
        internal bool IsSetInstanceConfiguration()
        {
            return this._instanceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Configuration settings related to network traffic of the web application that the
        /// App Runner service runs.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ObservabilityConfiguration. 
        /// <para>
        /// The observability configuration of your service.
        /// </para>
        /// </summary>
        public ServiceObservabilityConfiguration ObservabilityConfiguration
        {
            get { return this._observabilityConfiguration; }
            set { this._observabilityConfiguration = value; }
        }

        // Check to see if ObservabilityConfiguration property is set
        internal bool IsSetObservabilityConfiguration()
        {
            return this._observabilityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source configuration to apply to the App Runner service.
        /// </para>
        ///  
        /// <para>
        /// You can change the configuration of the code or image repository that the service
        /// uses. However, you can't switch from code to image or the other way around. This means
        /// that you must provide the same structure member of <c>SourceConfiguration</c> that
        /// you originally included when you created the service. Specifically, you can include
        /// either <c>CodeRepository</c> or <c>ImageRepository</c>. To update the source configuration,
        /// set the values to members of the structure that you include.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

    }
}