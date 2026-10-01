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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClusterKafkaVersion operation. Updates the
    /// Apache Kafka version for the cluster.
    /// </summary>
    public partial class UpdateClusterKafkaVersionRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationInfo. 
        /// <para>
        /// The custom configuration that should be applied on the new version of cluster.
        /// </para>
        /// </summary>
        public ConfigurationInfo ConfigurationInfo { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationInfo property is set.
        /// </summary>
        internal bool IsSetConfigurationInfo() => this.ConfigurationInfo != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// Current cluster version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property TargetKafkaVersion. 
        /// <para>
        /// Target Kafka version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetKafkaVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetKafkaVersion property is set.
        /// </summary>
        internal bool IsSetTargetKafkaVersion() => this.TargetKafkaVersion != null;
    }
}
