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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAutoScalingGroups Request Marshaller
    /// </summary>       
    public class DescribeAutoScalingGroupsRequestMarshaller : IMarshaller<IRequest, DescribeAutoScalingGroupsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAutoScalingGroupsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAutoScalingGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "DescribeAutoScalingGroups");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupNames())
                {
                    if (publicRequest.AutoScalingGroupNames.Count == 0)
                        request.Parameters.Add("AutoScalingGroupNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AutoScalingGroupNames)
                         {
                             request.Parameters.Add("AutoScalingGroupNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetFilters())
                {
                    if (publicRequest.Filters.Count == 0)
                        request.Parameters.Add("Filters", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Filters)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Filters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("Filters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("Filters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIncludeInstances())
                {
                    request.Parameters.Add("IncludeInstances", StringUtils.FromBool(publicRequest.IncludeInstances));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
            }
            return request;
        }
                    private static DescribeAutoScalingGroupsRequestMarshaller _instance = new DescribeAutoScalingGroupsRequestMarshaller();        

        internal static DescribeAutoScalingGroupsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAutoScalingGroupsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}