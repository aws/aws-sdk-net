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
    /// Represents an MSK Configuration.
    /// </summary>
    public partial class Configuration
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private List<string> _kafkaVersions = new List<string>();
        private ConfigurationRevision _latestRevision;
        private string _name;
        private ConfigurationState _state;

        /// <summary>
        /// Gets and sets the property Arn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when the configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description.             
        /// <para>
        /// The description of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// An array of the versions of Apache Kafka with which you can use this MSK configuration.
        /// You can use this configuration for an MSK cluster only if the Apache Kafka version
        /// specified for the cluster appears in this array.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> KafkaVersions
        {
            get { return this._kafkaVersions; }
            set { this._kafkaVersions = value; }
        }

        // Check to see if KafkaVersions property is set
        internal bool IsSetKafkaVersions()
        {
            return this._kafkaVersions != null && this._kafkaVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LatestRevision.             
        /// <para>
        /// Latest revision of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationRevision LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
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
        /// Gets and sets the property State.             
        /// <para>
        /// The state of the configuration. The possible states are ACTIVE, DELETING, and DELETE_FAILED.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}