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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFlow Request Marshaller
    /// </summary>       
    public class CreateFlowRequestMarshaller : IMarshaller<IRequest, CreateFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/flows";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetEntitlements())
                {
                    context.Writer.WritePropertyName("entitlements");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEntitlementsListValue in publicRequest.Entitlements)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GrantEntitlementRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestEntitlementsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFlowSize())
                {
                    context.Writer.WritePropertyName("flowSize");
                    context.Writer.Write(publicRequest.FlowSize);
                }

                if(publicRequest.IsSetFlowTags())
                {
                    context.Writer.WritePropertyName("flowTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFlowTagsKvp in publicRequest.FlowTags)
                    {
                        context.Writer.WritePropertyName(publicRequestFlowTagsKvp.Key);
                        var publicRequestFlowTagsValue = publicRequestFlowTagsKvp.Value;

                            context.Writer.Write(publicRequestFlowTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaintenance())
                {
                    context.Writer.WritePropertyName("maintenance");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddMaintenanceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Maintenance, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMediaStreams())
                {
                    context.Writer.WritePropertyName("mediaStreams");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMediaStreamsListValue in publicRequest.MediaStreams)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AddMediaStreamRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestMediaStreamsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNdiConfig())
                {
                    context.Writer.WritePropertyName("ndiConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = NdiConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NdiConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputs())
                {
                    context.Writer.WritePropertyName("outputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AddOutputRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("source");
                    context.Writer.WriteObjectStart();

                    var marshaller = SetSourceRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Source, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceFailoverConfig())
                {
                    context.Writer.WritePropertyName("sourceFailoverConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = FailoverConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceFailoverConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceMonitoringConfig())
                {
                    context.Writer.WritePropertyName("sourceMonitoringConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MonitoringConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceMonitoringConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SetSourceRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVpcInterfaces())
                {
                    context.Writer.WritePropertyName("vpcInterfaces");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVpcInterfacesListValue in publicRequest.VpcInterfaces)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VpcInterfaceRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestVpcInterfacesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateFlowRequestMarshaller _instance = new CreateFlowRequestMarshaller();        

        internal static CreateFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}