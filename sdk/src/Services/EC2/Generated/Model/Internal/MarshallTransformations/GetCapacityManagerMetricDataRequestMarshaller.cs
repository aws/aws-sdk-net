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
    /// GetCapacityManagerMetricData Request Marshaller
    /// </summary>       
    public class GetCapacityManagerMetricDataRequestMarshaller : IMarshaller<IRequest, GetCapacityManagerMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCapacityManagerMetricDataRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCapacityManagerMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetCapacityManagerMetricData");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }
                if(publicRequest.IsSetFilterBy())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.FilterBy)
                    {
                        if(publicRequestlistValue.IsSetDimensionCondition())
                        {
                            if(publicRequestlistValue.DimensionCondition.IsSetComparison())
                            {
                                request.Parameters.Add("FilterBy" + "." + publicRequestlistValueIndex + "." + "DimensionCondition" + "." + "Comparison", StringUtils.FromString(publicRequestlistValue.DimensionCondition.Comparison));
                            }
                            if(publicRequestlistValue.DimensionCondition.IsSetDimension())
                            {
                                request.Parameters.Add("FilterBy" + "." + publicRequestlistValueIndex + "." + "DimensionCondition" + "." + "Dimension", StringUtils.FromString(publicRequestlistValue.DimensionCondition.Dimension));
                            }
                            if(publicRequestlistValue.DimensionCondition.IsSetValues())
                            {
                                int publicRequestlistValueDimensionConditionlistValueIndex = 1;
                                foreach(var publicRequestlistValueDimensionConditionlistValue in publicRequestlistValue.DimensionCondition.Values)
                                {
                                    request.Parameters.Add("FilterBy" + "." + publicRequestlistValueIndex + "." + "DimensionCondition" + "." + "Value" + "." + publicRequestlistValueDimensionConditionlistValueIndex, StringUtils.FromString(publicRequestlistValueDimensionConditionlistValue));
                                    publicRequestlistValueDimensionConditionlistValueIndex++;
                                }
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetGroupBy())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.GroupBy)
                    {
                        request.Parameters.Add("GroupBy" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetMetricNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.MetricNames)
                    {
                        request.Parameters.Add("MetricName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetPeriod())
                {
                    request.Parameters.Add("Period", StringUtils.FromInt(publicRequest.Period));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
            }
            return request;
        }
                    private static GetCapacityManagerMetricDataRequestMarshaller _instance = new GetCapacityManagerMetricDataRequestMarshaller();        

        internal static GetCapacityManagerMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCapacityManagerMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}