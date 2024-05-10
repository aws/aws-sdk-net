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
    /// GetImageSet Request Marshaller
    /// </summary>       
    public class GetImageSetRequestMarshaller : IMarshaller<IRequest, GetImageSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetImageSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetImageSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MedicalImaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatastoreId())
                throw new AmazonMedicalImagingException("Request object does not have required field DatastoreId set");
            request.AddPathResource("{datastoreId}", StringUtils.FromString(publicRequest.DatastoreId));
            if (!publicRequest.IsSetImageSetId())
                throw new AmazonMedicalImagingException("Request object does not have required field ImageSetId set");
            request.AddPathResource("{imageSetId}", StringUtils.FromString(publicRequest.ImageSetId));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/datastore/{datastoreId}/imageSet/{imageSetId}/getImageSet";
            request.UseQueryString = true;
            
            request.HostPrefix = $"runtime-";

            return request;
        }
        private static GetImageSetRequestMarshaller _instance = new GetImageSetRequestMarshaller();        

        internal static GetImageSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetImageSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}