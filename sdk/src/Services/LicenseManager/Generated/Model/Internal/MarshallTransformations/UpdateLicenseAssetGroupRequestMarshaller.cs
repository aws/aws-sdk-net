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
    /// UpdateLicenseAssetGroup Request Marshaller
    /// </summary>       
    public class UpdateLicenseAssetGroupRequestMarshaller : IMarshaller<IRequest, UpdateLicenseAssetGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLicenseAssetGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLicenseAssetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.UpdateLicenseAssetGroup";
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
                if(publicRequest.IsSetAssociatedLicenseAssetRulesetARNs())
                {
                    context.Writer.WritePropertyName("AssociatedLicenseAssetRulesetARNs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssociatedLicenseAssetRulesetARNsListValue in publicRequest.AssociatedLicenseAssetRulesetARNs)
                    {
                            context.Writer.Write(publicRequestAssociatedLicenseAssetRulesetARNsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLicenseAssetGroupArn())
                {
                    context.Writer.WritePropertyName("LicenseAssetGroupArn");
                    context.Writer.Write(publicRequest.LicenseAssetGroupArn);
                }

                if(publicRequest.IsSetLicenseAssetGroupConfigurations())
                {
                    context.Writer.WritePropertyName("LicenseAssetGroupConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLicenseAssetGroupConfigurationsListValue in publicRequest.LicenseAssetGroupConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LicenseAssetGroupConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestLicenseAssetGroupConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProperties())
                {
                    context.Writer.WritePropertyName("Properties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPropertiesListValue in publicRequest.Properties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LicenseAssetGroupPropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestPropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLicenseAssetGroupRequestMarshaller _instance = new UpdateLicenseAssetGroupRequestMarshaller();        

        internal static UpdateLicenseAssetGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLicenseAssetGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}