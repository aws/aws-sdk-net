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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCampaign Request Marshaller
    /// </summary>       
    public class CreateCampaignRequestMarshaller : IMarshaller<IRequest, CreateCampaignRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCampaignRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCampaignRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTFleetWise");
            string target = "IoTAutobahnControlPlane.CreateCampaign";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCollectionScheme())
                {
                    context.Writer.WritePropertyName("collectionScheme");
                    context.Writer.WriteObjectStart();

                    var marshaller = CollectionSchemeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CollectionScheme, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCompression())
                {
                    context.Writer.WritePropertyName("compression");
                    context.Writer.Write(publicRequest.Compression);
                }

                if(publicRequest.IsSetDataExtraDimensions())
                {
                    context.Writer.WritePropertyName("dataExtraDimensions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataExtraDimensionsListValue in publicRequest.DataExtraDimensions)
                    {
                            context.Writer.Write(publicRequestDataExtraDimensionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDiagnosticsMode())
                {
                    context.Writer.WritePropertyName("diagnosticsMode");
                    context.Writer.Write(publicRequest.DiagnosticsMode);
                }

                if(publicRequest.IsSetExpiryTime())
                {
                    context.Writer.WritePropertyName("expiryTime");
                    context.Writer.Write(publicRequest.ExpiryTime);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPostTriggerCollectionDuration())
                {
                    context.Writer.WritePropertyName("postTriggerCollectionDuration");
                    context.Writer.Write(publicRequest.PostTriggerCollectionDuration);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetSignalCatalogArn())
                {
                    context.Writer.WritePropertyName("signalCatalogArn");
                    context.Writer.Write(publicRequest.SignalCatalogArn);
                }

                if(publicRequest.IsSetSignalsToCollect())
                {
                    context.Writer.WritePropertyName("signalsToCollect");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSignalsToCollectListValue in publicRequest.SignalsToCollect)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SignalInformationMarshaller.Instance;
                        marshaller.Marshall(publicRequestSignalsToCollectListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSpoolingMode())
                {
                    context.Writer.WritePropertyName("spoolingMode");
                    context.Writer.Write(publicRequest.SpoolingMode);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("startTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetArn())
                {
                    context.Writer.WritePropertyName("targetArn");
                    context.Writer.Write(publicRequest.TargetArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCampaignRequestMarshaller _instance = new CreateCampaignRequestMarshaller();        

        internal static CreateCampaignRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCampaignRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}