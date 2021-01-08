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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClusterConfiguration operation.
    /// Updates the cluster with the configuration that is specified in the request body.
    /// </summary>
    public partial class UpdateClusterConfigurationRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private ConfigurationInfo _configurationInfo;
        private string _currentVersion;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationInfo.             
        /// <para>
        /// Represents the configuration that you want MSK to use for the brokers in a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationInfo ConfigurationInfo
        {
            get { return this._configurationInfo; }
            set { this._configurationInfo = value; }
        }

        // Check to see if ConfigurationInfo property is set
        internal bool IsSetConfigurationInfo()
        {
            return this._configurationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The version of the cluster that needs to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

    }
}