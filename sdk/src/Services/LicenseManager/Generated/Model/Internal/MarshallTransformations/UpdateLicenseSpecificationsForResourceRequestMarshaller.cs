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
    /// UpdateLicenseSpecificationsForResource Request Marshaller
    /// </summary>       
    public class UpdateLicenseSpecificationsForResourceRequestMarshaller : IMarshaller<IRequest, UpdateLicenseSpecificationsForResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLicenseSpecificationsForResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLicenseSpecificationsForResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManager");
            string target = "AWSLicenseManager.UpdateLicenseSpecificationsForResource";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddLicenseSpecifications())
                {
                    context.Writer.WritePropertyName("AddLicenseSpecifications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddLicenseSpecificationsListValue in publicRequest.AddLicenseSpecifications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LicenseSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddLicenseSpecificationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoveLicenseSpecifications())
                {
                    context.Writer.WritePropertyName("RemoveLicenseSpecifications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveLicenseSpecificationsListValue in publicRequest.RemoveLicenseSpecifications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LicenseSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveLicenseSpecificationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("ResourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLicenseSpecificationsForResourceRequestMarshaller _instance = new UpdateLicenseSpecificationsForResourceRequestMarshaller();        

        internal static UpdateLicenseSpecificationsForResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLicenseSpecificationsForResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}