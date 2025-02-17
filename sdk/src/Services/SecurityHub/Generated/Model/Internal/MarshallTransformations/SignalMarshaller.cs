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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Signal Marshaller
    /// </summary>
    public class SignalMarshaller : IRequestMarshaller<Signal, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Signal requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActorIds())
            {
                context.Writer.WritePropertyName("ActorIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActorIdsListValue in requestObject.ActorIds)
                {
                        context.Writer.Write(requestObjectActorIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.Write(requestObject.Count);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.Write(requestObject.CreatedAt);
            }

            if(requestObject.IsSetEndpointIds())
            {
                context.Writer.WritePropertyName("EndpointIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndpointIdsListValue in requestObject.EndpointIds)
                {
                        context.Writer.Write(requestObjectEndpointIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFirstSeenAt())
            {
                context.Writer.WritePropertyName("FirstSeenAt");
                context.Writer.Write(requestObject.FirstSeenAt);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetLastSeenAt())
            {
                context.Writer.WritePropertyName("LastSeenAt");
                context.Writer.Write(requestObject.LastSeenAt);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.Write(requestObject.ProductArn);
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("ResourceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                        context.Writer.Write(requestObjectResourceIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Severity))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Severity));
                }
                else
                {
                    context.Writer.Write(requestObject.Severity);
                }
            }

            if(requestObject.IsSetSignalIndicators())
            {
                context.Writer.WritePropertyName("SignalIndicators");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSignalIndicatorsListValue in requestObject.SignalIndicators)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IndicatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectSignalIndicatorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.Write(requestObject.UpdatedAt);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SignalMarshaller Instance = new SignalMarshaller();

    }
}