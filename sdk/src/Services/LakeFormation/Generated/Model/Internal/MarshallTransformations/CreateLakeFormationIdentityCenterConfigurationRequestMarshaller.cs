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
    /// CreateLakeFormationIdentityCenterConfiguration Request Marshaller
    /// </summary>       
    public class CreateLakeFormationIdentityCenterConfigurationRequestMarshaller : IMarshaller<IRequest, CreateLakeFormationIdentityCenterConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLakeFormationIdentityCenterConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLakeFormationIdentityCenterConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateLakeFormationIdentityCenterConfiguration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalogId())
                {
                    context.Writer.WritePropertyName("CatalogId");
                    context.Writer.Write(publicRequest.CatalogId);
                }

                if(publicRequest.IsSetExternalFiltering())
                {
                    context.Writer.WritePropertyName("ExternalFiltering");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExternalFilteringConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExternalFiltering, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInstanceArn())
                {
                    context.Writer.WritePropertyName("InstanceArn");
                    context.Writer.Write(publicRequest.InstanceArn);
                }

                if(publicRequest.IsSetShareRecipients())
                {
                    context.Writer.WritePropertyName("ShareRecipients");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestShareRecipientsListValue in publicRequest.ShareRecipients)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataLakePrincipalMarshaller.Instance;
                        marshaller.Marshall(publicRequestShareRecipientsListValue, context);

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
        private static CreateLakeFormationIdentityCenterConfigurationRequestMarshaller _instance = new CreateLakeFormationIdentityCenterConfigurationRequestMarshaller();        

        internal static CreateLakeFormationIdentityCenterConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLakeFormationIdentityCenterConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}