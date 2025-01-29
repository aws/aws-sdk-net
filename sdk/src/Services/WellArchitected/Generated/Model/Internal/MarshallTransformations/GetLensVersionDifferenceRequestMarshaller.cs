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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetLensVersionDifference Request Marshaller
    /// </summary>       
    public class GetLensVersionDifferenceRequestMarshaller : IMarshaller<IRequest, GetLensVersionDifferenceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLensVersionDifferenceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetLensVersionDifferenceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetLensAlias())
                throw new AmazonWellArchitectedException("Request object does not have required field LensAlias set");
            request.AddPathResource("{LensAlias}", StringUtils.FromString(publicRequest.LensAlias));
            
            if (publicRequest.IsSetBaseLensVersion())
                request.Parameters.Add("BaseLensVersion", StringUtils.FromString(publicRequest.BaseLensVersion));
            
            if (publicRequest.IsSetTargetLensVersion())
                request.Parameters.Add("TargetLensVersion", StringUtils.FromString(publicRequest.TargetLensVersion));
            request.ResourcePath = "/lenses/{LensAlias}/versionDifference";
            request.UseQueryString = true;

            return request;
        }
        private static GetLensVersionDifferenceRequestMarshaller _instance = new GetLensVersionDifferenceRequestMarshaller();        

        internal static GetLensVersionDifferenceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLensVersionDifferenceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}