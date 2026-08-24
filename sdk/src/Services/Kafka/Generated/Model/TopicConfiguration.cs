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
    /// Configuration of an Apache Kafka topic that feeds a channel.
    /// </summary>
    public partial class TopicConfiguration
    {
        private RecordConverter _recordConverter;
        private RecordSchema _recordSchema;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property RecordConverter. 
        /// <para>
        /// Configuration that controls how Apache Kafka record values are deserialized for the
        /// destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordConverter RecordConverter
        {
            get { return this._recordConverter; }
            set { this._recordConverter = value; }
        }

        // Check to see if RecordConverter property is set
        internal bool IsSetRecordConverter()
        {
            return this._recordConverter != null;
        }

        /// <summary>
        /// Gets and sets the property RecordSchema. 
        /// <para>
        /// The schema used to validate records when the value converter requires one (for example,
        /// JSON_SCHEMA_GSR).
        /// </para>
        /// </summary>
        public RecordSchema RecordSchema
        {
            get { return this._recordSchema; }
            set { this._recordSchema = value; }
        }

        // Check to see if RecordSchema property is set
        internal bool IsSetRecordSchema()
        {
            return this._recordSchema != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}