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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Specifies one of the following actions to receive notifications when the alarm state
    /// changes.
    /// </summary>
    public partial class AlarmAction
    {
        private DynamoDBAction _dynamodb;
        private DynamoDBv2Action _dynamodBv2;
        private FirehoseAction _firehose;
        private IotEventsAction _iotEvents;
        private IotSiteWiseAction _iotSiteWise;
        private IotTopicPublishAction _iotTopicPublish;
        private LambdaAction _lambda;
        private SNSTopicPublishAction _sns;
        private SqsAction _sqs;

        /// <summary>
        /// Gets and sets the property DynamoDB.
        /// </summary>
        public DynamoDBAction DynamoDB
        {
            get { return this._dynamodb; }
            set { this._dynamodb = value; }
        }

        // Check to see if DynamoDB property is set
        internal bool IsSetDynamoDB()
        {
            return this._dynamodb != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDBv2.
        /// </summary>
        public DynamoDBv2Action DynamoDBv2
        {
            get { return this._dynamodBv2; }
            set { this._dynamodBv2 = value; }
        }

        // Check to see if DynamoDBv2 property is set
        internal bool IsSetDynamoDBv2()
        {
            return this._dynamodBv2 != null;
        }

        /// <summary>
        /// Gets and sets the property Firehose.
        /// </summary>
        public FirehoseAction Firehose
        {
            get { return this._firehose; }
            set { this._firehose = value; }
        }

        // Check to see if Firehose property is set
        internal bool IsSetFirehose()
        {
            return this._firehose != null;
        }

        /// <summary>
        /// Gets and sets the property IotEvents.
        /// </summary>
        public IotEventsAction IotEvents
        {
            get { return this._iotEvents; }
            set { this._iotEvents = value; }
        }

        // Check to see if IotEvents property is set
        internal bool IsSetIotEvents()
        {
            return this._iotEvents != null;
        }

        /// <summary>
        /// Gets and sets the property IotSiteWise.
        /// </summary>
        public IotSiteWiseAction IotSiteWise
        {
            get { return this._iotSiteWise; }
            set { this._iotSiteWise = value; }
        }

        // Check to see if IotSiteWise property is set
        internal bool IsSetIotSiteWise()
        {
            return this._iotSiteWise != null;
        }

        /// <summary>
        /// Gets and sets the property IotTopicPublish.
        /// </summary>
        public IotTopicPublishAction IotTopicPublish
        {
            get { return this._iotTopicPublish; }
            set { this._iotTopicPublish = value; }
        }

        // Check to see if IotTopicPublish property is set
        internal bool IsSetIotTopicPublish()
        {
            return this._iotTopicPublish != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda.
        /// </summary>
        public LambdaAction Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property Sns.
        /// </summary>
        public SNSTopicPublishAction Sns
        {
            get { return this._sns; }
            set { this._sns = value; }
        }

        // Check to see if Sns property is set
        internal bool IsSetSns()
        {
            return this._sns != null;
        }

        /// <summary>
        /// Gets and sets the property Sqs.
        /// </summary>
        public SqsAction Sqs
        {
            get { return this._sqs; }
            set { this._sqs = value; }
        }

        // Check to see if Sqs property is set
        internal bool IsSetSqs()
        {
            return this._sqs != null;
        }

    }
}