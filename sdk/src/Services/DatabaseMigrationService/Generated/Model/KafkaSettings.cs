/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes an Apache Kafka endpoint. This information includes
    /// the output format of records applied to the endpoint and details of transaction and
    /// control table data information.
    /// </summary>
    public partial class KafkaSettings
    {
        private string _broker;
        private string _topic;

        /// <summary>
        /// Gets and sets the property Broker. 
        /// <para>
        /// The broker location and port of the Kafka broker that hosts your Kafka instance. Specify
        /// the broker in the form <code> <i>broker-hostname-or-ip</i>:<i>port</i> </code>. For
        /// example, <code>"ec2-12-345-678-901.compute-1.amazonaws.com:2345"</code>.
        /// </para>
        /// </summary>
        public string Broker
        {
            get { return this._broker; }
            set { this._broker = value; }
        }

        // Check to see if Broker property is set
        internal bool IsSetBroker()
        {
            return this._broker != null;
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic to which you migrate the data. If you don't specify a topic, AWS DMS specifies
        /// <code>"kafka-default-topic"</code> as the migration topic.
        /// </para>
        /// </summary>
        public string Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

    }
}