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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
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
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetInterpolatedAssetPropertyValues Request Marshaller
    /// </summary>       
    public class GetInterpolatedAssetPropertyValuesRequestMarshaller : IMarshaller<IRequest, GetInterpolatedAssetPropertyValuesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInterpolatedAssetPropertyValuesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInterpolatedAssetPropertyValuesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAssetId())
                request.Parameters.Add("assetId", StringUtils.FromString(publicRequest.AssetId));
            
            if (publicRequest.IsSetEndTimeInSeconds())
                request.Parameters.Add("endTimeInSeconds", StringUtils.FromLong(publicRequest.EndTimeInSeconds));
            
            if (publicRequest.IsSetEndTimeOffsetInNanos())
                request.Parameters.Add("endTimeOffsetInNanos", StringUtils.FromInt(publicRequest.EndTimeOffsetInNanos));
            
            if (publicRequest.IsSetIntervalInSeconds())
                request.Parameters.Add("intervalInSeconds", StringUtils.FromLong(publicRequest.IntervalInSeconds));
            
            if (publicRequest.IsSetIntervalWindowInSeconds())
                request.Parameters.Add("intervalWindowInSeconds", StringUtils.FromLong(publicRequest.IntervalWindowInSeconds));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPropertyAlias())
                request.Parameters.Add("propertyAlias", StringUtils.FromString(publicRequest.PropertyAlias));
            
            if (publicRequest.IsSetPropertyId())
                request.Parameters.Add("propertyId", StringUtils.FromString(publicRequest.PropertyId));
            
            if (publicRequest.IsSetQuality())
                request.Parameters.Add("quality", StringUtils.FromString(publicRequest.Quality));
            
            if (publicRequest.IsSetStartTimeInSeconds())
                request.Parameters.Add("startTimeInSeconds", StringUtils.FromLong(publicRequest.StartTimeInSeconds));
            
            if (publicRequest.IsSetStartTimeOffsetInNanos())
                request.Parameters.Add("startTimeOffsetInNanos", StringUtils.FromInt(publicRequest.StartTimeOffsetInNanos));
            
            if (publicRequest.IsSetType())
                request.Parameters.Add("type", StringUtils.FromString(publicRequest.Type));
            request.ResourcePath = "/properties/interpolated";
            request.UseQueryString = true;
            
            request.HostPrefix = $"data.";

            return request;
        }
        private static GetInterpolatedAssetPropertyValuesRequestMarshaller _instance = new GetInterpolatedAssetPropertyValuesRequestMarshaller();        

        internal static GetInterpolatedAssetPropertyValuesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInterpolatedAssetPropertyValuesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}