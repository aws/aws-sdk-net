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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation.
    /// Updates the cluster.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonECSRequest
    {
        private string _cluster;
        private ClusterConfiguration _configuration;
        private ClusterServiceConnectDefaultsRequest _serviceConnectDefaults;
        private List<ClusterSetting> _settings = new List<ClusterSetting>();

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The name of the cluster to modify the settings for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The execute command configuration for the cluster.
        /// </para>
        /// </summary>
        public ClusterConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceConnectDefaults. 
        /// <para>
        /// Use this parameter to set a default Service Connect namespace. After you set a default
        /// Service Connect namespace, any new services with Service Connect turned on that are
        /// created in the cluster are added as client services in the namespace. This setting
        /// only applies to new services that set the <code>enabled</code> parameter to <code>true</code>
        /// in the <code>ServiceConnectConfiguration</code>. You can set the namespace of each
        /// service individually in the <code>ServiceConnectConfiguration</code> to override this
        /// default parameter.
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
        public ClusterServiceConnectDefaultsRequest ServiceConnectDefaults
        {
            get { return this._serviceConnectDefaults; }
            set { this._serviceConnectDefaults = value; }
        }

        // Check to see if ServiceConnectDefaults property is set
        internal bool IsSetServiceConnectDefaults()
        {
            return this._serviceConnectDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The cluster settings for your cluster.
        /// </para>
        /// </summary>
        public List<ClusterSetting> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && this._settings.Count > 0; 
        }

    }
}