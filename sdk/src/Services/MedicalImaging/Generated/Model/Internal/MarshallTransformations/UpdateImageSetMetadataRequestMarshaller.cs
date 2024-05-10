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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MedicalImaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateImageSetMetadata Request Marshaller
    /// </summary>       
    public class UpdateImageSetMetadataRequestMarshaller : IMarshaller<IRequest, UpdateImageSetMetadataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateImageSetMetadataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateImageSetMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MedicalImaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatastoreId())
                throw new AmazonMedicalImagingException("Request object does not have required field DatastoreId set");
            request.AddPathResource("{datastoreId}", StringUtils.FromString(publicRequest.DatastoreId));
            if (!publicRequest.IsSetImageSetId())
                throw new AmazonMedicalImagingException("Request object does not have required field ImageSetId set");
            request.AddPathResource("{imageSetId}", StringUtils.FromString(publicRequest.ImageSetId));
            
            if (publicRequest.IsSetLatestVersionId())
                request.Parameters.Add("latestVersion", StringUtils.FromString(publicRequest.LatestVersionId));
            request.ResourcePath = "/datastore/{datastoreId}/imageSet/{imageSetId}/updateImageSetMetadata";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                var context = new JsonMarshallerContext(request, writer);
                context.Writer.WriteObjectStart();

                var marshaller = MetadataUpdatesMarshaller.Instance;
                marshaller.Marshall(publicRequest.UpdateImageSetMetadataUpdates, context);

                context.Writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;
            
            request.HostPrefix = $"runtime-";

            return request;
        }
        private static UpdateImageSetMetadataRequestMarshaller _instance = new UpdateImageSetMetadataRequestMarshaller();        

        internal static UpdateImageSetMetadataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateImageSetMetadataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}