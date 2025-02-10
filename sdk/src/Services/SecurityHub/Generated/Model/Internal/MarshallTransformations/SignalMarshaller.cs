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
                context.Writer.WriteStartArray();
                foreach(var requestObjectActorIdsListValue in requestObject.ActorIds)
                {
                        context.Writer.WriteStringValue(requestObjectActorIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.WriteNumberValue(requestObject.Count.Value);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteNumberValue(requestObject.CreatedAt.Value);
            }

            if(requestObject.IsSetEndpointIds())
            {
                context.Writer.WritePropertyName("EndpointIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointIdsListValue in requestObject.EndpointIds)
                {
                        context.Writer.WriteStringValue(requestObjectEndpointIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFirstSeenAt())
            {
                context.Writer.WritePropertyName("FirstSeenAt");
                context.Writer.WriteNumberValue(requestObject.FirstSeenAt.Value);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetLastSeenAt())
            {
                context.Writer.WritePropertyName("LastSeenAt");
                context.Writer.WriteNumberValue(requestObject.LastSeenAt.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.WriteStringValue(requestObject.ProductArn);
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("ResourceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                        context.Writer.WriteStringValue(requestObjectResourceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Severity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Severity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Severity.Value);
                }
            }

            if(requestObject.IsSetSignalIndicators())
            {
                context.Writer.WritePropertyName("SignalIndicators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSignalIndicatorsListValue in requestObject.SignalIndicators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IndicatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectSignalIndicatorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.WriteNumberValue(requestObject.UpdatedAt.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SignalMarshaller Instance = new SignalMarshaller();

    }
}