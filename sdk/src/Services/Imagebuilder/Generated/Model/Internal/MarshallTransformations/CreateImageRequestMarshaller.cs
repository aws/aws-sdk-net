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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImage Request Marshaller
    /// </summary>       
    public class CreateImageRequestMarshaller : IMarshaller<IRequest, CreateImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/CreateImage";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetContainerRecipeArn())
                {
                    context.Writer.WritePropertyName("containerRecipeArn");
                    context.Writer.Write(publicRequest.ContainerRecipeArn);
                }

                if(publicRequest.IsSetDistributionConfigurationArn())
                {
                    context.Writer.WritePropertyName("distributionConfigurationArn");
                    context.Writer.Write(publicRequest.DistributionConfigurationArn);
                }

                if(publicRequest.IsSetEnhancedImageMetadataEnabled())
                {
                    context.Writer.WritePropertyName("enhancedImageMetadataEnabled");
                    context.Writer.Write(publicRequest.EnhancedImageMetadataEnabled);
                }

                if(publicRequest.IsSetImageRecipeArn())
                {
                    context.Writer.WritePropertyName("imageRecipeArn");
                    context.Writer.Write(publicRequest.ImageRecipeArn);
                }

                if(publicRequest.IsSetImageScanningConfiguration())
                {
                    context.Writer.WritePropertyName("imageScanningConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageScanningConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageScanningConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetImageTestsConfiguration())
                {
                    context.Writer.WritePropertyName("imageTestsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageTestsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageTestsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInfrastructureConfigurationArn())
                {
                    context.Writer.WritePropertyName("infrastructureConfigurationArn");
                    context.Writer.Write(publicRequest.InfrastructureConfigurationArn);
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
        private static CreateImageRequestMarshaller _instance = new CreateImageRequestMarshaller();        

        internal static CreateImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}