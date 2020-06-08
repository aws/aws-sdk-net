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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Action Marshaller
    /// </summary>       
    public class ActionMarshaller : IRequestMarshaller<Action, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Action requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClearTimer())
            {
                context.Writer.WritePropertyName("clearTimer");
                context.Writer.WriteObjectStart();

                var marshaller = ClearTimerActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ClearTimer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamoDB())
            {
                context.Writer.WritePropertyName("dynamoDB");
                context.Writer.WriteObjectStart();

                var marshaller = DynamoDBActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamoDBv2())
            {
                context.Writer.WritePropertyName("dynamoDBv2");
                context.Writer.WriteObjectStart();

                var marshaller = DynamoDBv2ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBv2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFirehose())
            {
                context.Writer.WritePropertyName("firehose");
                context.Writer.WriteObjectStart();

                var marshaller = FirehoseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Firehose, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotEvents())
            {
                context.Writer.WritePropertyName("iotEvents");
                context.Writer.WriteObjectStart();

                var marshaller = IotEventsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotEvents, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotSiteWise())
            {
                context.Writer.WritePropertyName("iotSiteWise");
                context.Writer.WriteObjectStart();

                var marshaller = IotSiteWiseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotSiteWise, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIotTopicPublish())
            {
                context.Writer.WritePropertyName("iotTopicPublish");
                context.Writer.WriteObjectStart();

                var marshaller = IotTopicPublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotTopicPublish, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteObjectStart();

                var marshaller = LambdaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResetTimer())
            {
                context.Writer.WritePropertyName("resetTimer");
                context.Writer.WriteObjectStart();

                var marshaller = ResetTimerActionMarshaller.Instance;
                marshaller.Marshall(requestObject.ResetTimer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSetTimer())
            {
                context.Writer.WritePropertyName("setTimer");
                context.Writer.WriteObjectStart();

                var marshaller = SetTimerActionMarshaller.Instance;
                marshaller.Marshall(requestObject.SetTimer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSetVariable())
            {
                context.Writer.WritePropertyName("setVariable");
                context.Writer.WriteObjectStart();

                var marshaller = SetVariableActionMarshaller.Instance;
                marshaller.Marshall(requestObject.SetVariable, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSns())
            {
                context.Writer.WritePropertyName("sns");
                context.Writer.WriteObjectStart();

                var marshaller = SNSTopicPublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sns, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqs())
            {
                context.Writer.WritePropertyName("sqs");
                context.Writer.WriteObjectStart();

                var marshaller = SqsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sqs, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ActionMarshaller Instance = new ActionMarshaller();

    }
}