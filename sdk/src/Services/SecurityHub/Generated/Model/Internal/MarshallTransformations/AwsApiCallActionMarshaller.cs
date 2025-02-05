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
    /// AwsApiCallAction Marshaller
    /// </summary>
    public class AwsApiCallActionMarshaller : IRequestMarshaller<AwsApiCallAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiCallAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAffectedResources())
            {
                context.Writer.WritePropertyName("AffectedResources");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAffectedResourcesKvp in requestObject.AffectedResources)
                {
                    context.Writer.WritePropertyName(requestObjectAffectedResourcesKvp.Key);
                    var requestObjectAffectedResourcesValue = requestObjectAffectedResourcesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAffectedResourcesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApi())
            {
                context.Writer.WritePropertyName("Api");
                context.Writer.WriteStringValue(requestObject.Api);
            }

            if(requestObject.IsSetCallerType())
            {
                context.Writer.WritePropertyName("CallerType");
                context.Writer.WriteStringValue(requestObject.CallerType);
            }

            if(requestObject.IsSetDomainDetails())
            {
                context.Writer.WritePropertyName("DomainDetails");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiCallActionDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirstSeen())
            {
                context.Writer.WritePropertyName("FirstSeen");
                context.Writer.WriteStringValue(requestObject.FirstSeen);
            }

            if(requestObject.IsSetLastSeen())
            {
                context.Writer.WritePropertyName("LastSeen");
                context.Writer.WriteStringValue(requestObject.LastSeen);
            }

            if(requestObject.IsSetRemoteIpDetails())
            {
                context.Writer.WritePropertyName("RemoteIpDetails");
                context.Writer.WriteStartObject();

                var marshaller = ActionRemoteIpDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RemoteIpDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.WriteStringValue(requestObject.ServiceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsApiCallActionMarshaller Instance = new AwsApiCallActionMarshaller();

    }
}