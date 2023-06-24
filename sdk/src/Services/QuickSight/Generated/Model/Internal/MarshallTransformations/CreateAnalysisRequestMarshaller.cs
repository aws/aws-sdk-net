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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAnalysis Request Marshaller
    /// </summary>       
    public class CreateAnalysisRequestMarshaller : IMarshaller<IRequest, CreateAnalysisRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAnalysisRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAnalysisRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAnalysisId())
                throw new AmazonQuickSightException("Request object does not have required field AnalysisId set");
            request.AddPathResource("{AnalysisId}", StringUtils.FromString(publicRequest.AnalysisId));
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/analyses/{AnalysisId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("Definition");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalysisDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Definition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("Parameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = ParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Parameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPermissions())
                {
                    context.Writer.WritePropertyName("Permissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourcePermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestPermissionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSourceEntity())
                {
                    context.Writer.WritePropertyName("SourceEntity");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnalysisSourceEntityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SourceEntity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetThemeArn())
                {
                    context.Writer.WritePropertyName("ThemeArn");
                    context.Writer.Write(publicRequest.ThemeArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAnalysisRequestMarshaller _instance = new CreateAnalysisRequestMarshaller();        

        internal static CreateAnalysisRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAnalysisRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}