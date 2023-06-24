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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTile Request Marshaller
    /// </summary>       
    public class GetTileRequestMarshaller : IMarshaller<IRequest, GetTileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerGeospatial");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetX())
                throw new AmazonSageMakerGeospatialException("Request object does not have required field X set");
            request.AddPathResource("{x}", StringUtils.FromInt(publicRequest.X));
            if (!publicRequest.IsSetY())
                throw new AmazonSageMakerGeospatialException("Request object does not have required field Y set");
            request.AddPathResource("{y}", StringUtils.FromInt(publicRequest.Y));
            if (!publicRequest.IsSetZ())
                throw new AmazonSageMakerGeospatialException("Request object does not have required field Z set");
            request.AddPathResource("{z}", StringUtils.FromInt(publicRequest.Z));
            
            if (publicRequest.IsSetArn())
                request.Parameters.Add("Arn", StringUtils.FromString(publicRequest.Arn));
            
            if (publicRequest.IsSetExecutionRoleArn())
                request.Parameters.Add("ExecutionRoleArn", StringUtils.FromString(publicRequest.ExecutionRoleArn));
            
            if (publicRequest.IsSetImageAssets())
                request.ParameterCollection.Add("ImageAssets", publicRequest.ImageAssets);
            
            if (publicRequest.IsSetImageMask())
                request.Parameters.Add("ImageMask", StringUtils.FromBool(publicRequest.ImageMask));
            
            if (publicRequest.IsSetOutputDataType())
                request.Parameters.Add("OutputDataType", StringUtils.FromString(publicRequest.OutputDataType));
            
            if (publicRequest.IsSetOutputFormat())
                request.Parameters.Add("OutputFormat", StringUtils.FromString(publicRequest.OutputFormat));
            
            if (publicRequest.IsSetPropertyFilters())
                request.Parameters.Add("PropertyFilters", StringUtils.FromString(publicRequest.PropertyFilters));
            
            if (publicRequest.IsSetTarget())
                request.Parameters.Add("Target", StringUtils.FromString(publicRequest.Target));
            
            if (publicRequest.IsSetTimeRangeFilter())
                request.Parameters.Add("TimeRangeFilter", StringUtils.FromString(publicRequest.TimeRangeFilter));
            request.ResourcePath = "/tile/{z}/{x}/{y}";
            request.UseQueryString = true;

            return request;
        }
        private static GetTileRequestMarshaller _instance = new GetTileRequestMarshaller();        

        internal static GetTileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}