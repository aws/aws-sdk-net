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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLicenseConfiguration Request Marshaller
    /// </summary>       
    public class UpdateLicenseConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateLicenseConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLicenseConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLicenseConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.UpdateLicenseConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLicenseConfigurationArn())
                {
                    context.Writer.WritePropertyName("LicenseConfigurationArn");
                    context.Writer.Write(publicRequest.LicenseConfigurationArn);
                }

                if(publicRequest.IsSetLicenseConfigurationStatus())
                {
                    context.Writer.WritePropertyName("LicenseConfigurationStatus");
                    context.Writer.Write(publicRequest.LicenseConfigurationStatus);
                }

                if(publicRequest.IsSetLicenseCount())
                {
                    context.Writer.WritePropertyName("LicenseCount");
                    context.Writer.Write(publicRequest.LicenseCount);
                }

                if(publicRequest.IsSetLicenseCountHardLimit())
                {
                    context.Writer.WritePropertyName("LicenseCountHardLimit");
                    context.Writer.Write(publicRequest.LicenseCountHardLimit);
                }

                if(publicRequest.IsSetLicenseRules())
                {
                    context.Writer.WritePropertyName("LicenseRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLicenseRulesListValue in publicRequest.LicenseRules)
                    {
                            context.Writer.Write(publicRequestLicenseRulesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLicenseConfigurationRequestMarshaller _instance = new UpdateLicenseConfigurationRequestMarshaller();        

        internal static UpdateLicenseConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLicenseConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}