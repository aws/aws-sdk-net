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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApplicationComponentConfig Request Marshaller
    /// </summary>       
    public class UpdateApplicationComponentConfigRequestMarshaller : IMarshaller<IRequest, UpdateApplicationComponentConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationComponentConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationComponentConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubStrategyRecommendations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-applicationcomponent-config/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationComponentId())
                {
                    context.Writer.WritePropertyName("applicationComponentId");
                    context.Writer.Write(publicRequest.ApplicationComponentId);
                }

                if(publicRequest.IsSetAppType())
                {
                    context.Writer.WritePropertyName("appType");
                    context.Writer.Write(publicRequest.AppType);
                }

                if(publicRequest.IsSetConfigureOnly())
                {
                    context.Writer.WritePropertyName("configureOnly");
                    context.Writer.Write(publicRequest.ConfigureOnly);
                }

                if(publicRequest.IsSetInclusionStatus())
                {
                    context.Writer.WritePropertyName("inclusionStatus");
                    context.Writer.Write(publicRequest.InclusionStatus);
                }

                if(publicRequest.IsSetSecretsManagerKey())
                {
                    context.Writer.WritePropertyName("secretsManagerKey");
                    context.Writer.Write(publicRequest.SecretsManagerKey);
                }

                if(publicRequest.IsSetSourceCodeList())
                {
                    context.Writer.WritePropertyName("sourceCodeList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceCodeListListValue in publicRequest.SourceCodeList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceCodeMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourceCodeListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStrategyOption())
                {
                    context.Writer.WritePropertyName("strategyOption");
                    context.Writer.WriteObjectStart();

                    var marshaller = StrategyOptionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StrategyOption, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApplicationComponentConfigRequestMarshaller _instance = new UpdateApplicationComponentConfigRequestMarshaller();        

        internal static UpdateApplicationComponentConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationComponentConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}