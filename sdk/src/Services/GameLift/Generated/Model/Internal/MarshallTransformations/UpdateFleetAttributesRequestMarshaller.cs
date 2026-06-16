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
    /// UpdateFleetAttributes Request Marshaller
    /// </summary>       
    public class UpdateFleetAttributesRequestMarshaller : IMarshaller<IRequest, UpdateFleetAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/UpdateFleetAttributes";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAnywhereConfiguration())
                {
                    context.Writer.WriteTextString("AnywhereConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AnywhereConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnywhereConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetFleetId())
                {
                    context.Writer.WriteTextString("FleetId");
                    context.Writer.WriteTextString(publicRequest.FleetId);
                }
                if (publicRequest.IsSetMetricGroups())
                {
                    context.Writer.WriteTextString("MetricGroups");
                    context.Writer.WriteStartArray(publicRequest.MetricGroups.Count);
                    foreach(var publicRequestMetricGroupsListValue in publicRequest.MetricGroups)
                    {
                            context.Writer.WriteTextString(publicRequestMetricGroupsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetNewGameSessionProtectionPolicy())
                {
                    context.Writer.WriteTextString("NewGameSessionProtectionPolicy");
                    context.Writer.WriteTextString(publicRequest.NewGameSessionProtectionPolicy);
                }
                if (publicRequest.IsSetResourceCreationLimitPolicy())
                {
                    context.Writer.WriteTextString("ResourceCreationLimitPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResourceCreationLimitPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceCreationLimitPolicy, context);

                    context.Writer.WriteEndMap();
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
        private static UpdateFleetAttributesRequestMarshaller _instance = new UpdateFleetAttributesRequestMarshaller();        

        internal static UpdateFleetAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}