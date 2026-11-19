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
    /// Container for the parameters to the UpdateClusterExtension operation. Updates the
    /// configuration or the version of an extension installed on a SageMaker HyperPod cluster.
    /// SageMaker HyperPod applies the change to every node in the cluster. You can change
    /// the configuration, the version, or both in one request. <ul> <li> <para> <b>Configuration:</b>
    /// You can change settings by sending <c>ConfigurationValues</c>. Settings that you include
    /// are changed. Settings that you omit keep their current values. A setting with the
    /// value <c>null</c> is removed and returns to its default value. </para> </li> <li>
    /// <para> <b>Version:</b> You can update to a later version. You can't update to an earlier
    /// version. To use an earlier version, delete the extension and create it again with
    /// that version. </para> </li> </ul> <para> To retry the operation on nodes where it
    /// failed, fix the cause that <c>DescribeClusterExtension</c> reports in <c>Health</c>,
    /// and then send an <c>UpdateClusterExtension</c> request that doesn't change the version
    /// or the configuration. </para> <para> You can't update an extension while it is being
    /// deleted. </para>
    /// </summary>
    public partial class UpdateClusterExtensionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide so that the request is idempotent.
        /// If you send the same update more than once, SageMaker HyperPod applies it once and
        /// doesn't return an error.
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
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster on which the extension
        /// is installed.
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
        /// The configuration changes to apply, as a JSON object serialized as a string. Settings
        /// that you include are changed, settings that you omit are unchanged, and a setting
        /// with the value <c>null</c> returns to its default value. The resulting configuration
        /// must be valid for the target extension version. If you omit <c>ConfigurationValues</c>,
        /// the configuration is unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtensionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionArn property is set.
        /// </summary>
        internal bool IsSetExtensionArn() => this.ExtensionArn != null;

        /// <summary>
        /// Gets and sets the property ExtensionVersion. 
        /// <para>
        /// The version to update the extension to, in <c>MAJOR.MINOR.PATCH</c> format. The version
        /// must be later than the extension's current version. If you omit this parameter, the
        /// extension keeps its current version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ExtensionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionVersion property is set.
        /// </summary>
        internal bool IsSetExtensionVersion() => this.ExtensionVersion != null;
    }
}
