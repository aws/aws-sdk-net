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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEc2DeepInspectionConfiguration Request Marshaller
    /// </summary>       
    public class UpdateEc2DeepInspectionConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateEc2DeepInspectionConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEc2DeepInspectionConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEc2DeepInspectionConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ec2deepinspectionconfiguration/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActivateDeepInspection())
                {
                    context.Writer.WritePropertyName("activateDeepInspection");
                    context.Writer.Write(publicRequest.ActivateDeepInspection);
                }

                if(publicRequest.IsSetPackagePaths())
                {
                    context.Writer.WritePropertyName("packagePaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPackagePathsListValue in publicRequest.PackagePaths)
                    {
                            context.Writer.Write(publicRequestPackagePathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEc2DeepInspectionConfigurationRequestMarshaller _instance = new UpdateEc2DeepInspectionConfigurationRequestMarshaller();        

        internal static UpdateEc2DeepInspectionConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEc2DeepInspectionConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}