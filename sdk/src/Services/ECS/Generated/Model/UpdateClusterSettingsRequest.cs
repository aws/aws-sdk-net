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
    /// Container for the parameters to the UpdateClusterSettings operation.
    /// Modifies the settings to use for a cluster.
    /// </summary>
    public partial class UpdateClusterSettingsRequest : AmazonECSRequest
    {
        private string _cluster;
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The setting to use by default for a cluster. This parameter is used to turn on CloudWatch
        /// Container Insights for a cluster. If this value is specified, it overrides the <code>containerInsights</code>
        /// value set with <a>PutAccountSetting</a> or <a>PutAccountSettingDefault</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Currently, if you delete an existing cluster that does not have Container Insights
        /// turned on, and then create a new cluster with the same name with Container Insights
        /// tuned on, Container Insights will not actually be turned on. If you want to preserve
        /// the same name for your existing cluster and turn on Container Insights, you must wait
        /// 7 days before you can re-create it.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
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