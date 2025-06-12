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
    /// Container for the parameters to the CreateService operation.
    /// Create an App Runner service. After the service is created, the action also automatically
    /// starts a deployment.
    /// 
    ///  
    /// <para>
    /// This is an asynchronous operation. On a successful call, you can use the returned
    /// <c>OperationId</c> and the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListOperations.html">ListOperations</a>
    /// call to track the operation's progress.
    /// </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationArn;
        private EncryptionConfiguration _encryptionConfiguration;
        private HealthCheckConfiguration _healthCheckConfiguration;
        private InstanceConfiguration _instanceConfiguration;
        private NetworkConfiguration _networkConfiguration;
        private ServiceObservabilityConfiguration _observabilityConfiguration;
        private string _serviceName;
        private SourceConfiguration _sourceConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an App Runner automatic scaling configuration resource
        /// that you want to associate with your service. If not provided, App Runner associates
        /// the latest revision of a default auto scaling configuration.
        /// </para>
        ///  
        /// <para>
        /// Specify an ARN with a name and a revision number to associate that revision. For example:
        /// <c>arn:aws:apprunner:us-east-1:123456789012:autoscalingconfiguration/high-availability/3</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify just the name to associate the latest revision. For example: <c>arn:aws:apprunner:us-east-1:123456789012:autoscalingconfiguration/high-availability</c>
        /// 
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
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// An optional custom encryption key that App Runner uses to encrypt the copy of your
        /// source repository that it maintains and your service logs. By default, App Runner
        /// uses an Amazon Web Services managed key.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
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
        /// The runtime configuration of instances (scaling units) of your service.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// A name for the App Runner service. It must be unique across all the running App Runner
        /// services in your Amazon Web Services account in the Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=40)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source to deploy to the App Runner service. It can be a code or an image repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the App Runner service
        /// resource. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}