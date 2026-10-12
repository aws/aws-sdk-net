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
    /// Container for the parameters to the CreateService operation. Create an App Runner
    /// service. After the service is created, the action also automatically starts a deployment.
    /// <para> This is an asynchronous operation. On a successful call, you can use the returned
    /// <c>OperationId</c> and the <a href="https://docs.aws.amazon.com/apprunner/latest/api/API_ListOperations.html">ListOperations</a>
    /// call to track the operation's progress. </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonAppRunnerRequest
    {
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
        [AWSProperty(Min = 1, Max = 1011)]
        public string AutoScalingConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfigurationArn property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfigurationArn() => this.AutoScalingConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// An optional custom encryption key that App Runner uses to encrypt the copy of your
        /// source repository that it maintains and your service logs. By default, App Runner
        /// uses an Amazon Web Services managed key.
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
        /// the App Runner service.
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
        /// The runtime configuration of instances (scaling units) of your service.
        /// </para>
        /// </summary>
        public InstanceConfiguration InstanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConfiguration property is set.
        /// </summary>
        internal bool IsSetInstanceConfiguration() => this.InstanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Configuration settings related to network traffic of the web application that the
        /// App Runner service runs.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ObservabilityConfiguration. 
        /// <para>
        /// The observability configuration of your service.
        /// </para>
        /// </summary>
        public ServiceObservabilityConfiguration ObservabilityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ObservabilityConfiguration property is set.
        /// </summary>
        internal bool IsSetObservabilityConfiguration() => this.ObservabilityConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// A name for the App Runner service. It must be unique across all the running App Runner
        /// services in your Amazon Web Services account in the Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 40)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source to deploy to the App Runner service. It can be a code or an image repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the App Runner service
        /// resource. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
