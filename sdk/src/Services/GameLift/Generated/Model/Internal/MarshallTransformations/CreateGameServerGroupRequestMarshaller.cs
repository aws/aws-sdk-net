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
    /// CreateGameServerGroup Request Marshaller
    /// </summary>       
    public class CreateGameServerGroupRequestMarshaller : IMarshaller<IRequest, CreateGameServerGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGameServerGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGameServerGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/CreateGameServerGroup";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAutoScalingPolicy())
                {
                    context.Writer.WriteTextString("AutoScalingPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = GameServerGroupAutoScalingPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoScalingPolicy, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBalancingStrategy())
                {
                    context.Writer.WriteTextString("BalancingStrategy");
                    context.Writer.WriteTextString(publicRequest.BalancingStrategy);
                }
                if (publicRequest.IsSetGameServerGroupName())
                {
                    context.Writer.WriteTextString("GameServerGroupName");
                    context.Writer.WriteTextString(publicRequest.GameServerGroupName);
                }
                if (publicRequest.IsSetGameServerProtectionPolicy())
                {
                    context.Writer.WriteTextString("GameServerProtectionPolicy");
                    context.Writer.WriteTextString(publicRequest.GameServerProtectionPolicy);
                }
                if (publicRequest.IsSetInstanceDefinitions())
                {
                    context.Writer.WriteTextString("InstanceDefinitions");
                    context.Writer.WriteStartArray(publicRequest.InstanceDefinitions.Count);
                    foreach(var publicRequestInstanceDefinitionsListValue in publicRequest.InstanceDefinitions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = InstanceDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstanceDefinitionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLaunchTemplate())
                {
                    context.Writer.WriteTextString("LaunchTemplate");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LaunchTemplateSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LaunchTemplate, context);

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
                if (publicRequest.IsSetRoleArn())
                {
                    context.Writer.WriteTextString("RoleArn");
                    context.Writer.WriteTextString(publicRequest.RoleArn);
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
                if (publicRequest.IsSetVpcSubnets())
                {
                    context.Writer.WriteTextString("VpcSubnets");
                    context.Writer.WriteStartArray(publicRequest.VpcSubnets.Count);
                    foreach(var publicRequestVpcSubnetsListValue in publicRequest.VpcSubnets)
                    {
                            context.Writer.WriteTextString(publicRequestVpcSubnetsListValue);
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
        private static CreateGameServerGroupRequestMarshaller _instance = new CreateGameServerGroupRequestMarshaller();        

        internal static CreateGameServerGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGameServerGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}