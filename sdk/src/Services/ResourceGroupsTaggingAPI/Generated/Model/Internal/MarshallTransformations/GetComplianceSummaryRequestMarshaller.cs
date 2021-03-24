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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceGroupsTaggingAPI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResourceGroupsTaggingAPI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetComplianceSummary Request Marshaller
    /// </summary>       
    public class GetComplianceSummaryRequestMarshaller : IMarshaller<IRequest, GetComplianceSummaryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetComplianceSummaryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetComplianceSummaryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceGroupsTaggingAPI");
            string target = "ResourceGroupsTaggingAPI_20170126.GetComplianceSummary";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-26";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGroupBy())
                {
                    context.Writer.WritePropertyName("GroupBy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupByListValue in publicRequest.GroupBy)
                    {
                            context.Writer.Write(publicRequestGroupByListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetPaginationToken())
                {
                    context.Writer.WritePropertyName("PaginationToken");
                    context.Writer.Write(publicRequest.PaginationToken);
                }

                if(publicRequest.IsSetRegionFilters())
                {
                    context.Writer.WritePropertyName("RegionFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRegionFiltersListValue in publicRequest.RegionFilters)
                    {
                            context.Writer.Write(publicRequestRegionFiltersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceTypeFilters())
                {
                    context.Writer.WritePropertyName("ResourceTypeFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceTypeFiltersListValue in publicRequest.ResourceTypeFilters)
                    {
                            context.Writer.Write(publicRequestResourceTypeFiltersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTagKeyFilters())
                {
                    context.Writer.WritePropertyName("TagKeyFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagKeyFiltersListValue in publicRequest.TagKeyFilters)
                    {
                            context.Writer.Write(publicRequestTagKeyFiltersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetIdFilters())
                {
                    context.Writer.WritePropertyName("TargetIdFilters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetIdFiltersListValue in publicRequest.TargetIdFilters)
                    {
                            context.Writer.Write(publicRequestTargetIdFiltersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetComplianceSummaryRequestMarshaller _instance = new GetComplianceSummaryRequestMarshaller();        

        internal static GetComplianceSummaryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetComplianceSummaryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}