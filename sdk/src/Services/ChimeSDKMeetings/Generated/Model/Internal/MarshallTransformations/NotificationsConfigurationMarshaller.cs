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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotificationsConfiguration Marshaller
    /// </summary>
    public class NotificationsConfigurationMarshaller : IRequestMarshaller<NotificationsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NotificationsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLambdaFunctionArn())
            {
                context.Writer.WritePropertyName("LambdaFunctionArn");
                context.Writer.WriteStringValue(requestObject.LambdaFunctionArn);
            }

            if(requestObject.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(requestObject.SnsTopicArn);
            }

            if(requestObject.IsSetSqsQueueArn())
            {
                context.Writer.WritePropertyName("SqsQueueArn");
                context.Writer.WriteStringValue(requestObject.SqsQueueArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NotificationsConfigurationMarshaller Instance = new NotificationsConfigurationMarshaller();

    }
}