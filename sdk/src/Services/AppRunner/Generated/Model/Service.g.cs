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
        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationSummary. 
        /// <para>
        /// Summary information for the App Runner automatic scaling configuration resource that's
        /// associated with this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoScalingConfigurationSummary AutoScalingConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfigurationSummary() => this.AutoScalingConfigurationSummary != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the App Runner service was created. It's in the Unix time stamp format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the App Runner service was deleted. It's in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Checks to see if the DeletedAt property is set.
        /// </summary>
        internal bool IsSetDeletedAt() => this.DeletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption key that App Runner uses to encrypt the service logs and the copy of
        /// the source repository that App Runner maintains for the service. It can be either
        /// a customer-provided encryption key or an Amazon Web Services managed key.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property HealthCheckConfiguration. 
        /// <para>
        /// The settings for the health check that App Runner performs to monitor the health of
        /// this service.
        /// </para>
        /// </summary>
        public HealthCheckConfiguration HealthCheckConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckConfiguration property is set.
        /// </summary>
        internal bool IsSetHealthCheckConfiguration() => this.HealthCheckConfiguration != null;

        /// <summary>
        /// Gets and sets the property InstanceConfiguration. 
        /// <para>
        /// The runtime configuration of instances (scaling units) of this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceConfiguration InstanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConfiguration property is set.
        /// </summary>
        internal bool IsSetInstanceConfiguration() => this.InstanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Configuration settings related to network traffic of the web application that this
        /// service runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ObservabilityConfiguration. 
        /// <para>
        /// The observability configuration of this service.
        /// </para>
        /// </summary>
        public ServiceObservabilityConfiguration ObservabilityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityConfiguration property is set.
        /// </summary>
        internal bool IsSetObservabilityConfiguration() => this.ObservabilityConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// An ID that App Runner generated for this service. It's unique within the Amazon Web
        /// Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The customer-provided service name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 40)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceUrl. 
        /// <para>
        /// A subdomain URL that App Runner generated for this service. You can use this URL to
        /// access your service web application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUrl property is set.
        /// </summary>
        internal bool IsSetServiceUrl() => this.ServiceUrl != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source deployed to the App Runner service. It can be a code or an image repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

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
        [AWSProperty(Required = true)]
        public ServiceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the App Runner service was last updated at. It's in the Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
