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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutTaxExemption Request Marshaller
    /// </summary>       
    public class PutTaxExemptionRequestMarshaller : IMarshaller<IRequest, PutTaxExemptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutTaxExemptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutTaxExemptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TaxSettings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/PutTaxExemption";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIds())
                {
                    context.Writer.WritePropertyName("accountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.Write(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthority())
                {
                    context.Writer.WritePropertyName("authority");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthorityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Authority, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExemptionCertificate())
                {
                    context.Writer.WritePropertyName("exemptionCertificate");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExemptionCertificateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExemptionCertificate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExemptionType())
                {
                    context.Writer.WritePropertyName("exemptionType");
                    context.Writer.Write(publicRequest.ExemptionType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutTaxExemptionRequestMarshaller _instance = new PutTaxExemptionRequestMarshaller();        

        internal static PutTaxExemptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutTaxExemptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}