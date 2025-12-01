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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEvaluationForm Request Marshaller
    /// </summary>       
    public class CreateEvaluationFormRequestMarshaller : IMarshaller<IRequest, CreateEvaluationFormRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEvaluationFormRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEvaluationFormRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/evaluation-forms/{InstanceId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAsDraft())
                {
                    context.Writer.WritePropertyName("AsDraft");
                    context.Writer.Write(publicRequest.AsDraft);
                }

                if(publicRequest.IsSetAutoEvaluationConfiguration())
                {
                    context.Writer.WritePropertyName("AutoEvaluationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormAutoEvaluationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoEvaluationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetItems())
                {
                    context.Writer.WritePropertyName("Items");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestItemsListValue in publicRequest.Items)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EvaluationFormItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLanguageConfiguration())
                {
                    context.Writer.WritePropertyName("LanguageConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormLanguageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LanguageConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScoringStrategy())
                {
                    context.Writer.WritePropertyName("ScoringStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormScoringStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScoringStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargetConfiguration())
                {
                    context.Writer.WritePropertyName("TargetConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormTargetConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("Title");
                    context.Writer.Write(publicRequest.Title);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEvaluationFormRequestMarshaller _instance = new CreateEvaluationFormRequestMarshaller();        

        internal static CreateEvaluationFormRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEvaluationFormRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}