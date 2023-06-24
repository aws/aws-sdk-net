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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportResourcesToDraftAppVersion Request Marshaller
    /// </summary>       
    public class ImportResourcesToDraftAppVersionRequestMarshaller : IMarshaller<IRequest, ImportResourcesToDraftAppVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportResourcesToDraftAppVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportResourcesToDraftAppVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/import-resources-to-draft-app-version";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppArn())
                {
                    context.Writer.WritePropertyName("appArn");
                    context.Writer.Write(publicRequest.AppArn);
                }

                if(publicRequest.IsSetEksSources())
                {
                    context.Writer.WritePropertyName("eksSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEksSourcesListValue in publicRequest.EksSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EksSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestEksSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetImportStrategy())
                {
                    context.Writer.WritePropertyName("importStrategy");
                    context.Writer.Write(publicRequest.ImportStrategy);
                }

                if(publicRequest.IsSetSourceArns())
                {
                    context.Writer.WritePropertyName("sourceArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceArnsListValue in publicRequest.SourceArns)
                    {
                            context.Writer.Write(publicRequestSourceArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTerraformSources())
                {
                    context.Writer.WritePropertyName("terraformSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTerraformSourcesListValue in publicRequest.TerraformSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TerraformSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestTerraformSourcesListValue, context);

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
        private static ImportResourcesToDraftAppVersionRequestMarshaller _instance = new ImportResourcesToDraftAppVersionRequestMarshaller();        

        internal static ImportResourcesToDraftAppVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportResourcesToDraftAppVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}