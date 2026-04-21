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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMatchmakingConfiguration Request Marshaller
    /// </summary>       
    public class CreateMatchmakingConfigurationRequestMarshaller : IMarshaller<IRequest, CreateMatchmakingConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMatchmakingConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMatchmakingConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/CreateMatchmakingConfiguration";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAcceptanceRequired())
                {
                    context.Writer.WriteTextString("AcceptanceRequired");
                    context.Writer.WriteBoolean(publicRequest.AcceptanceRequired.Value);
                }
                if (publicRequest.IsSetAcceptanceTimeoutSeconds())
                {
                    context.Writer.WriteTextString("AcceptanceTimeoutSeconds");
                    context.Writer.WriteInt32(publicRequest.AcceptanceTimeoutSeconds.Value);
                }
                if (publicRequest.IsSetAdditionalPlayerCount())
                {
                    context.Writer.WriteTextString("AdditionalPlayerCount");
                    context.Writer.WriteInt32(publicRequest.AdditionalPlayerCount.Value);
                }
                if (publicRequest.IsSetBackfillMode())
                {
                    context.Writer.WriteTextString("BackfillMode");
                    context.Writer.WriteTextString(publicRequest.BackfillMode);
                }
                if (publicRequest.IsSetCustomEventData())
                {
                    context.Writer.WriteTextString("CustomEventData");
                    context.Writer.WriteTextString(publicRequest.CustomEventData);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetFlexMatchMode())
                {
                    context.Writer.WriteTextString("FlexMatchMode");
                    context.Writer.WriteTextString(publicRequest.FlexMatchMode);
                }
                if (publicRequest.IsSetGameProperties())
                {
                    context.Writer.WriteTextString("GameProperties");
                    context.Writer.WriteStartArray(publicRequest.GameProperties.Count);
                    foreach(var publicRequestGamePropertiesListValue in publicRequest.GameProperties)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = GamePropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestGamePropertiesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetGameSessionData())
                {
                    context.Writer.WriteTextString("GameSessionData");
                    context.Writer.WriteTextString(publicRequest.GameSessionData);
                }
                if (publicRequest.IsSetGameSessionQueueArns())
                {
                    context.Writer.WriteTextString("GameSessionQueueArns");
                    context.Writer.WriteStartArray(publicRequest.GameSessionQueueArns.Count);
                    foreach(var publicRequestGameSessionQueueArnsListValue in publicRequest.GameSessionQueueArns)
                    {
                            context.Writer.WriteTextString(publicRequestGameSessionQueueArnsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetNotificationTarget())
                {
                    context.Writer.WriteTextString("NotificationTarget");
                    context.Writer.WriteTextString(publicRequest.NotificationTarget);
                }
                if (publicRequest.IsSetRequestTimeoutSeconds())
                {
                    context.Writer.WriteTextString("RequestTimeoutSeconds");
                    context.Writer.WriteInt32(publicRequest.RequestTimeoutSeconds.Value);
                }
                if (publicRequest.IsSetRuleSetName())
                {
                    context.Writer.WriteTextString("RuleSetName");
                    context.Writer.WriteTextString(publicRequest.RuleSetName);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateMatchmakingConfigurationRequestMarshaller _instance = new CreateMatchmakingConfigurationRequestMarshaller();        

        internal static CreateMatchmakingConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMatchmakingConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}