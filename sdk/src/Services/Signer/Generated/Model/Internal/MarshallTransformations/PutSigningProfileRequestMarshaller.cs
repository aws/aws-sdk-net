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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSigningProfile Request Marshaller
    /// </summary>       
    public class PutSigningProfileRequestMarshaller : IMarshaller<IRequest, PutSigningProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSigningProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSigningProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signer");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-25";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetProfileName())
                throw new AmazonSignerException("Request object does not have required field ProfileName set");
            request.AddPathResource("{profileName}", StringUtils.FromString(publicRequest.ProfileName));
            request.ResourcePath = "/signing-profiles/{profileName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetOverrides())
                {
                    context.Writer.WritePropertyName("overrides");
                    context.Writer.WriteObjectStart();

                    var marshaller = SigningPlatformOverridesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Overrides, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPlatformId())
                {
                    context.Writer.WritePropertyName("platformId");
                    context.Writer.Write(publicRequest.PlatformId);
                }

                if(publicRequest.IsSetSignatureValidityPeriod())
                {
                    context.Writer.WritePropertyName("signatureValidityPeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = SignatureValidityPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SignatureValidityPeriod, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSigningMaterial())
                {
                    context.Writer.WritePropertyName("signingMaterial");
                    context.Writer.WriteObjectStart();

                    var marshaller = SigningMaterialMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SigningMaterial, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSigningParameters())
                {
                    context.Writer.WritePropertyName("signingParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestSigningParametersKvp in publicRequest.SigningParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestSigningParametersKvp.Key);
                        var publicRequestSigningParametersValue = publicRequestSigningParametersKvp.Value;

                            context.Writer.Write(publicRequestSigningParametersValue);
                    }
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
        private static PutSigningProfileRequestMarshaller _instance = new PutSigningProfileRequestMarshaller();        

        internal static PutSigningProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSigningProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}