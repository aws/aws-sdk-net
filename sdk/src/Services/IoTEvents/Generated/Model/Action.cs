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
    /// An action to be performed when the <c>condition</c> is TRUE.
    /// </summary>
    public partial class Action
    {
        private ClearTimerAction _clearTimer;
        private DynamoDBAction _dynamodb;
        private DynamoDBv2Action _dynamodBv2;
        private FirehoseAction _firehose;
        private IotEventsAction _iotEvents;
        private IotSiteWiseAction _iotSiteWise;
        private IotTopicPublishAction _iotTopicPublish;
        private LambdaAction _lambda;
        private ResetTimerAction _resetTimer;
        private SetTimerAction _setTimer;
        private SetVariableAction _setVariable;
        private SNSTopicPublishAction _sns;
        private SqsAction _sqs;

        /// <summary>
        /// Gets and sets the property ClearTimer. 
        /// <para>
        /// Information needed to clear the timer.
        /// </para>
        /// </summary>
        public ClearTimerAction ClearTimer
        {
            get { return this._clearTimer; }
            set { this._clearTimer = value; }
        }

        // Check to see if ClearTimer property is set
        internal bool IsSetClearTimer()
        {
            return this._clearTimer != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDB. 
        /// <para>
        /// Writes to the DynamoDB table that you created. The default action payload contains
        /// all attribute-value pairs that have the information about the detector model instance
        /// and the event that triggered the action. You can customize the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Payload.html">payload</a>.
        /// One column of the DynamoDB table receives all attribute-value pairs in the payload
        /// that you specify. For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-event-actions.html">Actions</a>
        /// in <i>AWS IoT Events Developer Guide</i>.
        /// </para>
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
        /// <para>
        /// Writes to the DynamoDB table that you created. The default action payload contains
        /// all attribute-value pairs that have the information about the detector model instance
        /// and the event that triggered the action. You can customize the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Payload.html">payload</a>.
        /// A separate column of the DynamoDB table receives one attribute-value pair in the payload
        /// that you specify. For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-event-actions.html">Actions</a>
        /// in <i>AWS IoT Events Developer Guide</i>.
        /// </para>
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
        /// <para>
        /// Sends information about the detector model instance and the event that triggered the
        /// action to an Amazon Kinesis Data Firehose delivery stream.
        /// </para>
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
        /// <para>
        /// Sends AWS IoT Events input, which passes information about the detector model instance
        /// and the event that triggered the action.
        /// </para>
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
        /// <para>
        /// Sends information about the detector model instance and the event that triggered the
        /// action to an asset property in AWS IoT SiteWise .
        /// </para>
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
        /// <para>
        /// Publishes an MQTT message with the given topic to the AWS IoT message broker.
        /// </para>
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
        /// <para>
        /// Calls a Lambda function, passing in information about the detector model instance
        /// and the event that triggered the action.
        /// </para>
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
        /// Gets and sets the property ResetTimer. 
        /// <para>
        /// Information needed to reset the timer.
        /// </para>
        /// </summary>
        public ResetTimerAction ResetTimer
        {
            get { return this._resetTimer; }
            set { this._resetTimer = value; }
        }

        // Check to see if ResetTimer property is set
        internal bool IsSetResetTimer()
        {
            return this._resetTimer != null;
        }

        /// <summary>
        /// Gets and sets the property SetTimer. 
        /// <para>
        /// Information needed to set the timer.
        /// </para>
        /// </summary>
        public SetTimerAction SetTimer
        {
            get { return this._setTimer; }
            set { this._setTimer = value; }
        }

        // Check to see if SetTimer property is set
        internal bool IsSetSetTimer()
        {
            return this._setTimer != null;
        }

        /// <summary>
        /// Gets and sets the property SetVariable. 
        /// <para>
        /// Sets a variable to a specified value.
        /// </para>
        /// </summary>
        public SetVariableAction SetVariable
        {
            get { return this._setVariable; }
            set { this._setVariable = value; }
        }

        // Check to see if SetVariable property is set
        internal bool IsSetSetVariable()
        {
            return this._setVariable != null;
        }

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        /// Sends an Amazon SNS message.
        /// </para>
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
        /// <para>
        /// Sends information about the detector model instance and the event that triggered the
        /// action to an Amazon SQS queue.
        /// </para>
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