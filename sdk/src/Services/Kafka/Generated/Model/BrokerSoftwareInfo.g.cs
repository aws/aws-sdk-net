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
    /// Information about the current software installed on the cluster.
    /// </summary>
    public partial class BrokerSoftwareInfo
    {
        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration used for the cluster. This field
        /// isn't visible in this preview release.
        /// </para>
        /// </summary>
        public string ConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationArn property is set.
        /// </summary>
        internal bool IsSetConfigurationArn() => this.ConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationRevision. 
        /// <para>
        /// The revision of the configuration to use. This field isn't visible in this preview
        /// release.
        /// </para>
        /// </summary>
        public long? ConfigurationRevision { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationRevision property is set.
        /// </summary>
        internal bool IsSetConfigurationRevision() => this.ConfigurationRevision.HasValue;

        /// <summary>
        /// Gets and sets the property KafkaVersion. 
        /// <para>
        /// The version of Apache Kafka.
        /// </para>
        /// </summary>
        public string KafkaVersion { get; set; }

        /// <summary>
        /// Checks to see if the KafkaVersion property is set.
        /// </summary>
        internal bool IsSetKafkaVersion() => this.KafkaVersion != null;
    }
}
