/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServerlessApplicationRepository.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServerlessApplicationRepository.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplication Request Marshaller
    /// </summary>       
    public class CreateApplicationRequestMarshaller : IMarshaller<IRequest, CreateApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServerlessApplicationRepository");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/applications";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthor())
                {
                    context.Writer.WritePropertyName("author");
                    context.Writer.Write(publicRequest.Author);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetHomePageUrl())
                {
                    context.Writer.WritePropertyName("homePageUrl");
                    context.Writer.Write(publicRequest.HomePageUrl);
                }

                if(publicRequest.IsSetLabels())
                {
                    context.Writer.WritePropertyName("labels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLabelsListValue in publicRequest.Labels)
                    {
                            context.Writer.Write(publicRequestLabelsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLicenseBody())
                {
                    context.Writer.WritePropertyName("licenseBody");
                    context.Writer.Write(publicRequest.LicenseBody);
                }

                if(publicRequest.IsSetLicenseUrl())
                {
                    context.Writer.WritePropertyName("licenseUrl");
                    context.Writer.Write(publicRequest.LicenseUrl);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetReadmeBody())
                {
                    context.Writer.WritePropertyName("readmeBody");
                    context.Writer.Write(publicRequest.ReadmeBody);
                }

                if(publicRequest.IsSetReadmeUrl())
                {
                    context.Writer.WritePropertyName("readmeUrl");
                    context.Writer.Write(publicRequest.ReadmeUrl);
                }

                if(publicRequest.IsSetSemanticVersion())
                {
                    context.Writer.WritePropertyName("semanticVersion");
                    context.Writer.Write(publicRequest.SemanticVersion);
                }

                if(publicRequest.IsSetSourceCodeUrl())
                {
                    context.Writer.WritePropertyName("sourceCodeUrl");
                    context.Writer.Write(publicRequest.SourceCodeUrl);
                }

                if(publicRequest.IsSetSpdxLicenseId())
                {
                    context.Writer.WritePropertyName("spdxLicenseId");
                    context.Writer.Write(publicRequest.SpdxLicenseId);
                }

                if(publicRequest.IsSetTemplateBody())
                {
                    context.Writer.WritePropertyName("templateBody");
                    context.Writer.Write(publicRequest.TemplateBody);
                }

                if(publicRequest.IsSetTemplateUrl())
                {
                    context.Writer.WritePropertyName("templateUrl");
                    context.Writer.Write(publicRequest.TemplateUrl);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateApplicationRequestMarshaller _instance = new CreateApplicationRequestMarshaller();        

        internal static CreateApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}