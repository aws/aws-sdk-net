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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClusterExtension operation. Installs an
    /// extension, such as <c>sagemaker-observability</c>, on a SageMaker HyperPod cluster
    /// orchestrated by Slurm. The cluster must have <c>NodeProvisioningMode</c> set to <c>Continuous</c>
    /// and can have only one extension with a given name. To track the installation, call
    /// <c>DescribeClusterExtension</c>.
    /// </summary>
    public partial class CreateClusterExtensionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide so that the operation completes
        /// no more than one time. This token is valid for 8 hours. If you retry the request with
        /// the same client token and the same parameters within this time, the API returns the
        /// Amazon Resource Name (ARN) of the extension that the original request created, without
        /// creating a duplicate. If you use the same client token with different parameters,
        /// the request fails.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster on which to install
        /// the extension. The cluster must use Slurm as the orchestrator and have <c>NodeProvisioningMode</c>
        /// set to <c>Continuous</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationValues. 
        /// <para>
        /// The configuration settings for the extension, as a JSON object serialized as a string,
        /// for example <c>{"metricsProvider":{"nodeMetrics":{"level":"ADVANCED"}}}</c>. Each
        /// extension version defines which settings it accepts. SageMaker HyperPod validates
        /// the settings against that definition, and rejects the request if a setting is unknown
        /// or has an invalid value. Settings that you omit use the extension's default values.
        /// If you omit <c>ConfigurationValues</c>, all settings use their default values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property ExtensionName. 
        /// <para>
        /// The name of the extension to install, for example <c>sagemaker-observability</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionName property is set.
        /// </summary>
        internal bool IsSetExtensionName() => this.ExtensionName != null;

        /// <summary>
        /// Gets and sets the property ExtensionVersion. 
        /// <para>
        /// The version of the extension to install, in <c>MAJOR.MINOR.PATCH</c> format, for example
        /// <c>1.0.0</c>. If you don't specify a version, SageMaker HyperPod installs the latest
        /// available version of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ExtensionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionVersion property is set.
        /// </summary>
        internal bool IsSetExtensionVersion() => this.ExtensionVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Custom tags for managing the extension as an Amazon Web Services resource. You can
        /// add tags to your extension in the same way you add them in other Amazon Web Services
        /// services that support tagging. To learn more about tagging Amazon Web Services resources
        /// in general, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// Amazon Web Services Resources User Guide</a>. To use this operation to add tags when
        /// you create an extension, you must have the <c>sagemaker:AddTags</c> permission.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
