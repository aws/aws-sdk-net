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
    /// Container for the parameters to the CreateConfiguration operation.
    /// Creates a new MSK configuration.
    /// </summary>
    public partial class CreateConfigurationRequest : AmazonKafkaRequest
    {
        private string _description;
        private List<string> _kafkaVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private MemoryStream _serverProperties;

        /// <summary>
        /// Gets and sets the property Description.             
        /// <para>
        /// The description of the configuration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KafkaVersions.             
        /// <para>
        /// The versions of Apache Kafka with which you can use this MSK configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KafkaVersions
        {
            get { return this._kafkaVersions; }
            set { this._kafkaVersions = value; }
        }

        // Check to see if KafkaVersions property is set
        internal bool IsSetKafkaVersions()
        {
            return this._kafkaVersions != null && (this._kafkaVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name.             
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ServerProperties.             
        /// <para>
        /// Contents of the <filename>server.properties</filename> file. When using the API, you
        /// must ensure that the contents of the file are base64 encoded.                When
        /// using the AWS Management Console, the SDK, or the AWS CLI, the contents of <filename>server.properties</filename>
        /// can be in plaintext.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream ServerProperties
        {
            get { return this._serverProperties; }
            set { this._serverProperties = value; }
        }

        // Check to see if ServerProperties property is set
        internal bool IsSetServerProperties()
        {
            return this._serverProperties != null;
        }

    }
}