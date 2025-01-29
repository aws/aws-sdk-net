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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AlarmAction Marshaller
    /// </summary>
    public class AlarmActionMarshaller : IRequestMarshaller<AlarmAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AlarmAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDynamoDB())
            {
                context.Writer.WritePropertyName("dynamoDB");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDBv2())
            {
                context.Writer.WritePropertyName("dynamoDBv2");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBv2ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBv2, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirehose())
            {
                context.Writer.WritePropertyName("firehose");
                context.Writer.WriteStartObject();

                var marshaller = FirehoseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Firehose, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotEvents())
            {
                context.Writer.WritePropertyName("iotEvents");
                context.Writer.WriteStartObject();

                var marshaller = IotEventsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotEvents, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotSiteWise())
            {
                context.Writer.WritePropertyName("iotSiteWise");
                context.Writer.WriteStartObject();

                var marshaller = IotSiteWiseActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotSiteWise, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIotTopicPublish())
            {
                context.Writer.WritePropertyName("iotTopicPublish");
                context.Writer.WriteStartObject();

                var marshaller = IotTopicPublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.IotTopicPublish, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteStartObject();

                var marshaller = LambdaActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Lambda, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSns())
            {
                context.Writer.WritePropertyName("sns");
                context.Writer.WriteStartObject();

                var marshaller = SNSTopicPublishActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sns, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqs())
            {
                context.Writer.WritePropertyName("sqs");
                context.Writer.WriteStartObject();

                var marshaller = SqsActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Sqs, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AlarmActionMarshaller Instance = new AlarmActionMarshaller();

    }
}