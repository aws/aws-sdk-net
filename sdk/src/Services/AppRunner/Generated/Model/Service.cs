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
    /// Describes an App Runner service. It can describe a service in any state, including
    /// deleted services.
    /// 
    ///  
    /// <para>
    /// This type contains the full information about a service, including configuration details.
    /// It's returned by the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_CreateService.html">CreateService</a>,
    /// <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_DescribeService.html">DescribeService</a>,
    /// and <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_DeleteService.html">DeleteService</a>
    /// actions. A subset of this information is returned by the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListServices.html">ListServices</a>
    /// action using the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ServiceSummary.html">ServiceSummary</a>
    /// type.
    /// </para>
    /// </summary>
    public partial class Service
    {
        private AutoScalingConfigurationSummary _autoScalingConfigurationSummary;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private EncryptionConfiguration _encryptionConfiguration;
        private HealthCheckConfiguration _healthCheckConfiguration;
        private InstanceConfiguration _instanceConfiguration;
        private NetworkConfiguration _networkConfiguration;
        private ServiceObservabilityConfiguration _observabilityConfiguration;
        private string _serviceArn;
        private string _serviceId;
        private string _serviceName;
        private string _serviceUrl;
        private SourceConfiguration _sourceConfiguration;
        private ServiceStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationSummary. 
        /// <para>
        /// Summary information for the App Runner automatic scaling configuration resource that's
        /// associated with this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoScalingConfigurationSummary AutoScalingConfigurationSummary
        {
            get { return this._autoScalingConfigurationSummary; }
            set { this._autoScalingConfigurationSummary = value; }
        }

        // Check to see if AutoScalingConfigurationSummary property is set
        internal bool IsSetAutoScalingConfigurationSummary()
        {
            return this._autoScalingConfigurationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the App Runner service was created. It's in the Unix time stamp format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the App Runner service was deleted. It's in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption key that App Runner uses to encrypt the service logs and the copy of
        /// the source repository that App Runner maintains for the service. It can be either
        /// a customer-provided encryption key or an Amazon Web Services managed key.
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
        /// this service.
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
        /// The runtime configuration of instances (scaling units) of this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Configuration settings related to network traffic of the web application that this
        /// service runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The observability configuration of this service.
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
        /// The Amazon Resource Name (ARN) of this service.
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
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// An ID that App Runner generated for this service. It's unique within the Amazon Web
        /// Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The customer-provided service name.
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
        /// Gets and sets the property ServiceUrl. 
        /// <para>
        /// A subdomain URL that App Runner generated for this service. You can use this URL to
        /// access your service web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
        public string ServiceUrl
        {
            get { return this._serviceUrl; }
            set { this._serviceUrl = value; }
        }

        // Check to see if ServiceUrl property is set
        internal bool IsSetServiceUrl()
        {
            return this._serviceUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source deployed to the App Runner service. It can be a code or an image repository.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the App Runner service. These particular values mean the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_FAILED</c> – The service failed to create. The failed service isn't usable,
        /// and still counts towards your service quota. To troubleshoot this failure, read the
        /// failure events and logs, change any parameters that need to be fixed, and rebuild
        /// your service using <c>UpdateService</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> – The service failed to delete and can't be successfully recovered.
        /// Retry the service deletion call to ensure that all related resources are removed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the App Runner service was last updated at. It's in the Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}