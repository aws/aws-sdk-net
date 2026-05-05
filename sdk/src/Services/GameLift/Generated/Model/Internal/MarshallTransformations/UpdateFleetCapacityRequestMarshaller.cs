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
    /// UpdateFleetCapacity Request Marshaller
    /// </summary>       
    public class UpdateFleetCapacityRequestMarshaller : IMarshaller<IRequest, UpdateFleetCapacityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetCapacityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetCapacityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/UpdateFleetCapacity";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDesiredInstances())
                {
                    context.Writer.WriteTextString("DesiredInstances");
                    context.Writer.WriteInt32(publicRequest.DesiredInstances.Value);
                }
                if (publicRequest.IsSetFleetId())
                {
                    context.Writer.WriteTextString("FleetId");
                    context.Writer.WriteTextString(publicRequest.FleetId);
                }
                if (publicRequest.IsSetLocation())
                {
                    context.Writer.WriteTextString("Location");
                    context.Writer.WriteTextString(publicRequest.Location);
                }
                if (publicRequest.IsSetManagedCapacityConfiguration())
                {
                    context.Writer.WriteTextString("ManagedCapacityConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ManagedCapacityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ManagedCapacityConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMaxSize())
                {
                    context.Writer.WriteTextString("MaxSize");
                    context.Writer.WriteInt32(publicRequest.MaxSize.Value);
                }
                if (publicRequest.IsSetMinSize())
                {
                    context.Writer.WriteTextString("MinSize");
                    context.Writer.WriteInt32(publicRequest.MinSize.Value);
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
        private static UpdateFleetCapacityRequestMarshaller _instance = new UpdateFleetCapacityRequestMarshaller();        

        internal static UpdateFleetCapacityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetCapacityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}