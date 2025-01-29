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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// APNSMessage Marshaller
    /// </summary>
    public class APNSMessageMarshaller : IRequestMarshaller<APNSMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(APNSMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetAPNSPushType())
            {
                context.Writer.WritePropertyName("APNSPushType");
                context.Writer.WriteStringValue(requestObject.APNSPushType);
            }

            if(requestObject.IsSetBadge())
            {
                context.Writer.WritePropertyName("Badge");
                context.Writer.WriteNumberValue(requestObject.Badge.Value);
            }

            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStringValue(requestObject.Body);
            }

            if(requestObject.IsSetCategory())
            {
                context.Writer.WritePropertyName("Category");
                context.Writer.WriteStringValue(requestObject.Category);
            }

            if(requestObject.IsSetCollapseId())
            {
                context.Writer.WritePropertyName("CollapseId");
                context.Writer.WriteStringValue(requestObject.CollapseId);
            }

            if(requestObject.IsSetData())
            {
                context.Writer.WritePropertyName("Data");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDataKvp in requestObject.Data)
                {
                    context.Writer.WritePropertyName(requestObjectDataKvp.Key);
                    var requestObjectDataValue = requestObjectDataKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMediaUrl())
            {
                context.Writer.WritePropertyName("MediaUrl");
                context.Writer.WriteStringValue(requestObject.MediaUrl);
            }

            if(requestObject.IsSetPreferredAuthenticationMethod())
            {
                context.Writer.WritePropertyName("PreferredAuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.PreferredAuthenticationMethod);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteStringValue(requestObject.Priority);
            }

            if(requestObject.IsSetRawContent())
            {
                context.Writer.WritePropertyName("RawContent");
                context.Writer.WriteStringValue(requestObject.RawContent);
            }

            if(requestObject.IsSetSilentPush())
            {
                context.Writer.WritePropertyName("SilentPush");
                context.Writer.WriteBooleanValue(requestObject.SilentPush.Value);
            }

            if(requestObject.IsSetSound())
            {
                context.Writer.WritePropertyName("Sound");
                context.Writer.WriteStringValue(requestObject.Sound);
            }

            if(requestObject.IsSetSubstitutions())
            {
                context.Writer.WritePropertyName("Substitutions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSubstitutionsKvp in requestObject.Substitutions)
                {
                    context.Writer.WritePropertyName(requestObjectSubstitutionsKvp.Key);
                    var requestObjectSubstitutionsValue = requestObjectSubstitutionsKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectSubstitutionsValueListValue in requestObjectSubstitutionsValue)
                    {
                            context.Writer.WriteStringValue(requestObjectSubstitutionsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThreadId())
            {
                context.Writer.WritePropertyName("ThreadId");
                context.Writer.WriteStringValue(requestObject.ThreadId);
            }

            if(requestObject.IsSetTimeToLive())
            {
                context.Writer.WritePropertyName("TimeToLive");
                context.Writer.WriteNumberValue(requestObject.TimeToLive.Value);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static APNSMessageMarshaller Instance = new APNSMessageMarshaller();

    }
}