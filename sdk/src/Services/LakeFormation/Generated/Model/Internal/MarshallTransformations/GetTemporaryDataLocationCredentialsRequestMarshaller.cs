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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTemporaryDataLocationCredentials Request Marshaller
    /// </summary>       
    public class GetTemporaryDataLocationCredentialsRequestMarshaller : IMarshaller<IRequest, GetTemporaryDataLocationCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTemporaryDataLocationCredentialsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTemporaryDataLocationCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/GetTemporaryDataLocationCredentials";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuditContext())
                {
                    context.Writer.WritePropertyName("AuditContext");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuditContextMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuditContext, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCredentialsScope())
                {
                    context.Writer.WritePropertyName("CredentialsScope");
                    context.Writer.Write(publicRequest.CredentialsScope);
                }

                if(publicRequest.IsSetDataLocations())
                {
                    context.Writer.WritePropertyName("DataLocations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataLocationsListValue in publicRequest.DataLocations)
                    {
                            context.Writer.Write(publicRequestDataLocationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDurationSeconds())
                {
                    context.Writer.WritePropertyName("DurationSeconds");
                    context.Writer.Write(publicRequest.DurationSeconds);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetTemporaryDataLocationCredentialsRequestMarshaller _instance = new GetTemporaryDataLocationCredentialsRequestMarshaller();        

        internal static GetTemporaryDataLocationCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTemporaryDataLocationCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}