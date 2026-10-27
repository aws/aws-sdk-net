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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation. Updates the cluster.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name of the cluster to modify the settings for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The execute command configuration for the cluster.
        /// </para>
        /// </summary>
        public ClusterConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ServiceConnectDefaults. 
        /// <para>
        /// Use this parameter to set a default Service Connect namespace. After you set a default
        /// Service Connect namespace, any new services with Service Connect turned on that are
        /// created in the cluster are added as client services in the namespace. This setting
        /// only applies to new services that set the <c>enabled</c> parameter to <c>true</c>
        /// in the <c>ServiceConnectConfiguration</c>. You can set the namespace of each service
        /// individually in the <c>ServiceConnectConfiguration</c> to override this default parameter.
        /// </para>
        ///  
        /// <para>
        /// Tasks that run in a namespace can use short names to connect to services in the namespace.
        /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
        /// through a managed proxy container that collects logs and metrics for increased visibility.
        /// Only the tasks that Amazon ECS services create are supported with Service Connect.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ClusterServiceConnectDefaultsRequest ServiceConnectDefaults { get; set; }

        /// <summary>
        /// Checks to see if the ServiceConnectDefaults property is set.
        /// </summary>
        internal bool IsSetServiceConnectDefaults() => this.ServiceConnectDefaults != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The cluster settings for your cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterSetting> Settings { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterSetting>() : null;

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null && (this.Settings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
