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
    /// Details of an extension installed on a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ExtensionDetails
    {
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
        /// The configuration of the extension, as a JSON object serialized as a string. The configuration
        /// includes the default value of every setting that you didn't specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string ConfigurationValues { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationValues property is set.
        /// </summary>
        internal bool IsSetConfigurationValues() => this.ConfigurationValues != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the extension was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtensionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionArn property is set.
        /// </summary>
        internal bool IsSetExtensionArn() => this.ExtensionArn != null;

        /// <summary>
        /// Gets and sets the property ExtensionName. 
        /// <para>
        /// The name of the extension.
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
        /// The version of the extension. While SageMaker HyperPod creates or updates the extension,
        /// some nodes might still run a different version. To see how many nodes run this version,
        /// see <c>NodeSummary</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExtensionVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionVersion property is set.
        /// </summary>
        internal bool IsSetExtensionVersion() => this.ExtensionVersion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the extension was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the extension can be one of the following values:
        /// </para>
        ///  <dl> <dt>Creating</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod is installing the extension on the cluster's nodes.
        /// </para>
        ///  </dd> <dt>Active</dt> <dd> 
        /// <para>
        /// The extension runs its current version and configuration on all of the cluster's nodes.
        /// </para>
        ///  </dd> <dt>Updating</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod is applying a configuration change or version update to the cluster's
        /// nodes.
        /// </para>
        ///  </dd> <dt>Degraded</dt> <dd> 
        /// <para>
        /// The extension runs its current version and configuration on some of the cluster's
        /// nodes but not all of them. Or, at least one node recently reported that the extension
        /// is unhealthy.
        /// </para>
        ///  </dd> <dt>CreateFailed</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod couldn't install the extension on any of the cluster's nodes.
        /// </para>
        ///  </dd> <dt>UpdateFailed</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod couldn't apply the update on any of the cluster's nodes.
        /// </para>
        ///  </dd> <dt>Deleting</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod is removing the extension from the cluster's nodes.
        /// </para>
        ///  </dd> <dt>DeleteFailed</dt> <dd> 
        /// <para>
        /// SageMaker HyperPod couldn't remove the extension from any of the cluster's nodes.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtensionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
