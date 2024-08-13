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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Information about the current software installed on the cluster.
    /// </summary>
    public partial class BrokerSoftwareInfo
    {
        private string _configurationArn;
        private long? _configurationRevision;
        private string _kafkaVersion;

        /// <summary>
        /// Gets and sets the property ConfigurationArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration used for the cluster. This field
        /// isn't visible in this preview release.
        /// </para>
        /// </summary>
        public string ConfigurationArn
        {
            get { return this._configurationArn; }
            set { this._configurationArn = value; }
        }

        // Check to see if ConfigurationArn property is set
        internal bool IsSetConfigurationArn()
        {
            return this._configurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationRevision.             
        /// <para>
        /// The revision of the configuration to use. This field isn't visible in this preview
        /// release.
        /// </para>
        /// </summary>
        public long? ConfigurationRevision
        {
            get { return this._configurationRevision; }
            set { this._configurationRevision = value; }
        }

        // Check to see if ConfigurationRevision property is set
        internal bool IsSetConfigurationRevision()
        {
            return this._configurationRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KafkaVersion.             
        /// <para>
        /// The version of Apache Kafka.
        /// </para>
        /// </summary>
        public string KafkaVersion
        {
            get { return this._kafkaVersion; }
            set { this._kafkaVersion = value; }
        }

        // Check to see if KafkaVersion property is set
        internal bool IsSetKafkaVersion()
        {
            return this._kafkaVersion != null;
        }

    }
}