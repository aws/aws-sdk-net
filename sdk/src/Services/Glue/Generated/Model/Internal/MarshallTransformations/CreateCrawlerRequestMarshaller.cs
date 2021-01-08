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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCrawler Request Marshaller
    /// </summary>       
    public class CreateCrawlerRequestMarshaller : IMarshaller<IRequest, CreateCrawlerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCrawlerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCrawlerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateCrawler";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClassifiers())
                {
                    context.Writer.WritePropertyName("Classifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestClassifiersListValue in publicRequest.Classifiers)
                    {
                            context.Writer.Write(publicRequestClassifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("Configuration");
                    context.Writer.Write(publicRequest.Configuration);
                }

                if(publicRequest.IsSetCrawlerSecurityConfiguration())
                {
                    context.Writer.WritePropertyName("CrawlerSecurityConfiguration");
                    context.Writer.Write(publicRequest.CrawlerSecurityConfiguration);
                }

                if(publicRequest.IsSetDatabaseName())
                {
                    context.Writer.WritePropertyName("DatabaseName");
                    context.Writer.Write(publicRequest.DatabaseName);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLineageConfiguration())
                {
                    context.Writer.WritePropertyName("LineageConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LineageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LineageConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRecrawlPolicy())
                {
                    context.Writer.WritePropertyName("RecrawlPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = RecrawlPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RecrawlPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("Schedule");
                    context.Writer.Write(publicRequest.Schedule);
                }

                if(publicRequest.IsSetSchemaChangePolicy())
                {
                    context.Writer.WritePropertyName("SchemaChangePolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = SchemaChangePolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchemaChangePolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTablePrefix())
                {
                    context.Writer.WritePropertyName("TablePrefix");
                    context.Writer.Write(publicRequest.TablePrefix);
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

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("Targets");
                    context.Writer.WriteObjectStart();

                    var marshaller = CrawlerTargetsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Targets, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCrawlerRequestMarshaller _instance = new CreateCrawlerRequestMarshaller();        

        internal static CreateCrawlerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCrawlerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}