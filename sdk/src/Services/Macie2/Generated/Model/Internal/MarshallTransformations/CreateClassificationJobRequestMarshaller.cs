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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateClassificationJob Request Marshaller
    /// </summary>       
    public class CreateClassificationJobRequestMarshaller : IMarshaller<IRequest, CreateClassificationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClassificationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClassificationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowListIds())
                {
                    context.Writer.WritePropertyName("allowListIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAllowListIdsListValue in publicRequest.AllowListIds)
                    {
                            context.Writer.Write(publicRequestAllowListIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCustomDataIdentifierIds())
                {
                    context.Writer.WritePropertyName("customDataIdentifierIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomDataIdentifierIdsListValue in publicRequest.CustomDataIdentifierIds)
                    {
                            context.Writer.Write(publicRequestCustomDataIdentifierIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetInitialRun())
                {
                    context.Writer.WritePropertyName("initialRun");
                    context.Writer.Write(publicRequest.InitialRun);
                }

                if(publicRequest.IsSetJobType())
                {
                    context.Writer.WritePropertyName("jobType");
                    context.Writer.Write(publicRequest.JobType);
                }

                if(publicRequest.IsSetManagedDataIdentifierIds())
                {
                    context.Writer.WritePropertyName("managedDataIdentifierIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestManagedDataIdentifierIdsListValue in publicRequest.ManagedDataIdentifierIds)
                    {
                            context.Writer.Write(publicRequestManagedDataIdentifierIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetManagedDataIdentifierSelector())
                {
                    context.Writer.WritePropertyName("managedDataIdentifierSelector");
                    context.Writer.Write(publicRequest.ManagedDataIdentifierSelector);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetS3JobDefinition())
                {
                    context.Writer.WritePropertyName("s3JobDefinition");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3JobDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3JobDefinition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSamplingPercentage())
                {
                    context.Writer.WritePropertyName("samplingPercentage");
                    context.Writer.Write(publicRequest.SamplingPercentage);
                }

                if(publicRequest.IsSetScheduleFrequency())
                {
                    context.Writer.WritePropertyName("scheduleFrequency");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobScheduleFrequencyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduleFrequency, context);

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
        private static CreateClassificationJobRequestMarshaller _instance = new CreateClassificationJobRequestMarshaller();        

        internal static CreateClassificationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClassificationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}