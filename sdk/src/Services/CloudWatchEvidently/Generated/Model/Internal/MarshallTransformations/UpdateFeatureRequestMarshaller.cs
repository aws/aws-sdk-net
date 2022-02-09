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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFeature Request Marshaller
    /// </summary>       
    public class UpdateFeatureRequestMarshaller : IMarshaller<IRequest, UpdateFeatureRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFeatureRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFeatureRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetFeature())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Feature set");
            request.AddPathResource("{feature}", StringUtils.FromString(publicRequest.Feature));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/features/{feature}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddOrUpdateVariations())
                {
                    context.Writer.WritePropertyName("addOrUpdateVariations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddOrUpdateVariationsListValue in publicRequest.AddOrUpdateVariations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VariationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddOrUpdateVariationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDefaultVariation())
                {
                    context.Writer.WritePropertyName("defaultVariation");
                    context.Writer.Write(publicRequest.DefaultVariation);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEntityOverrides())
                {
                    context.Writer.WritePropertyName("entityOverrides");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEntityOverridesKvp in publicRequest.EntityOverrides)
                    {
                        context.Writer.WritePropertyName(publicRequestEntityOverridesKvp.Key);
                        var publicRequestEntityOverridesValue = publicRequestEntityOverridesKvp.Value;

                            context.Writer.Write(publicRequestEntityOverridesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvaluationStrategy())
                {
                    context.Writer.WritePropertyName("evaluationStrategy");
                    context.Writer.Write(publicRequest.EvaluationStrategy);
                }

                if(publicRequest.IsSetRemoveVariations())
                {
                    context.Writer.WritePropertyName("removeVariations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveVariationsListValue in publicRequest.RemoveVariations)
                    {
                            context.Writer.Write(publicRequestRemoveVariationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFeatureRequestMarshaller _instance = new UpdateFeatureRequestMarshaller();        

        internal static UpdateFeatureRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFeatureRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}