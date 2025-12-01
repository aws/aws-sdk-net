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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAnalysisTemplate Request Marshaller
    /// </summary>       
    public class CreateAnalysisTemplateRequestMarshaller : IMarshaller<IRequest, CreateAnalysisTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAnalysisTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAnalysisTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMembershipIdentifier())
                throw new AmazonCleanRoomsException("Request object does not have required field MembershipIdentifier set");
            request.AddPathResource("{membershipIdentifier}", StringUtils.FromString(publicRequest.MembershipIdentifier));
            request.ResourcePath = "/memberships/{membershipIdentifier}/analysistemplates";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnalysisParameters())
                {
                    context.Writer.WritePropertyName("analysisParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAnalysisParametersListValue in publicRequest.AnalysisParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AnalysisParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestAnalysisParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetErrorMessageConfiguration())
                {
                    context.Writer.WritePropertyName("errorMessageConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ErrorMessageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ErrorMessageConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSchema())
                {
                    context.Writer.WritePropertyName("schema");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalysisSchemaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schema, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("source");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalysisSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Source, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSyntheticDataParameters())
                {
                    context.Writer.WritePropertyName("syntheticDataParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = SyntheticDataParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SyntheticDataParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAnalysisTemplateRequestMarshaller _instance = new CreateAnalysisTemplateRequestMarshaller();        

        internal static CreateAnalysisTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAnalysisTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}