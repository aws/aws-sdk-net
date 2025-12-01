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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSolution Request Marshaller
    /// </summary>       
    public class CreateSolutionRequestMarshaller : IMarshaller<IRequest, CreateSolutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSolutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSolutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Personalize");
            string target = "AmazonPersonalize.CreateSolution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDatasetGroupArn())
                {
                    context.Writer.WritePropertyName("datasetGroupArn");
                    context.Writer.Write(publicRequest.DatasetGroupArn);
                }

                if(publicRequest.IsSetEventType())
                {
                    context.Writer.WritePropertyName("eventType");
                    context.Writer.Write(publicRequest.EventType);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPerformAutoML())
                {
                    context.Writer.WritePropertyName("performAutoML");
                    context.Writer.Write(publicRequest.PerformAutoML);
                }

                if(publicRequest.IsSetPerformAutoTraining())
                {
                    context.Writer.WritePropertyName("performAutoTraining");
                    context.Writer.Write(publicRequest.PerformAutoTraining);
                }

                if(publicRequest.IsSetPerformHPO())
                {
                    context.Writer.WritePropertyName("performHPO");
                    context.Writer.Write(publicRequest.PerformHPO);
                }

                if(publicRequest.IsSetPerformIncrementalUpdate())
                {
                    context.Writer.WritePropertyName("performIncrementalUpdate");
                    context.Writer.Write(publicRequest.PerformIncrementalUpdate);
                }

                if(publicRequest.IsSetRecipeArn())
                {
                    context.Writer.WritePropertyName("recipeArn");
                    context.Writer.Write(publicRequest.RecipeArn);
                }

                if(publicRequest.IsSetSolutionConfig())
                {
                    context.Writer.WritePropertyName("solutionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SolutionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SolutionConfig, context);

                    context.Writer.WriteObjectEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSolutionRequestMarshaller _instance = new CreateSolutionRequestMarshaller();        

        internal static CreateSolutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSolutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}