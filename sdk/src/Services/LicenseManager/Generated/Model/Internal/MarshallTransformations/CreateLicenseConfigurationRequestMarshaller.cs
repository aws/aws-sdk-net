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

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLicenseConfiguration Request Marshaller
    /// </summary>       
    public class CreateLicenseConfigurationRequestMarshaller : IMarshaller<IRequest, CreateLicenseConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLicenseConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLicenseConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.CreateLicenseConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisassociateWhenNotFound())
                {
                    context.Writer.WritePropertyName("DisassociateWhenNotFound");
                    context.Writer.Write(publicRequest.DisassociateWhenNotFound);
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

                if(publicRequest.IsSetLicenseCountingType())
                {
                    context.Writer.WritePropertyName("LicenseCountingType");
                    context.Writer.Write(publicRequest.LicenseCountingType);
                }

                if(publicRequest.IsSetLicenseExpiry())
                {
                    context.Writer.WritePropertyName("LicenseExpiry");
                    context.Writer.Write(publicRequest.LicenseExpiry);
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

                if(publicRequest.IsSetProductInformationList())
                {
                    context.Writer.WritePropertyName("ProductInformationList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProductInformationListListValue in publicRequest.ProductInformationList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ProductInformationMarshaller.Instance;
                        marshaller.Marshall(publicRequestProductInformationListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateLicenseConfigurationRequestMarshaller _instance = new CreateLicenseConfigurationRequestMarshaller();        

        internal static CreateLicenseConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLicenseConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}