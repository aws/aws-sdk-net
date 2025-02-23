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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeNetworkInsightsAnalyses Request Marshaller
    /// </summary>       
    public class DescribeNetworkInsightsAnalysesRequestMarshaller : IMarshaller<IRequest, DescribeNetworkInsightsAnalysesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeNetworkInsightsAnalysesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeNetworkInsightsAnalysesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "DescribeNetworkInsightsAnalyses");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAnalysisEndTime())
                {
                    request.Parameters.Add("AnalysisEndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.AnalysisEndTime));
                }
                if(publicRequest.IsSetAnalysisStartTime())
                {
                    request.Parameters.Add("AnalysisStartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.AnalysisStartTime));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFilters())
                {
                    if (publicRequest.Filters.Count == 0)
                        request.Parameters.Add("Filter", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Filters)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("Filter" + "." + publicRequestlistValueIndex + "." + "Value" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNetworkInsightsAnalysisIds())
                {
                    if (publicRequest.NetworkInsightsAnalysisIds.Count == 0)
                        request.Parameters.Add("NetworkInsightsAnalysisId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NetworkInsightsAnalysisIds)
                         {
                             request.Parameters.Add("NetworkInsightsAnalysisId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNetworkInsightsPathId())
                {
                    request.Parameters.Add("NetworkInsightsPathId", StringUtils.FromString(publicRequest.NetworkInsightsPathId));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
            }
            return request;
        }
                    private static DescribeNetworkInsightsAnalysesRequestMarshaller _instance = new DescribeNetworkInsightsAnalysesRequestMarshaller();        

        internal static DescribeNetworkInsightsAnalysesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeNetworkInsightsAnalysesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}