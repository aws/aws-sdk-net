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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeScheduledActions Request Marshaller
    /// </summary>       
    public class DescribeScheduledActionsRequestMarshaller : IMarshaller<IRequest, DescribeScheduledActionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeScheduledActionsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeScheduledActionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "DescribeScheduledActions");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActive())
                {
                    request.Parameters.Add("Active", StringUtils.FromBool(publicRequest.Active));
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
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
                                request.Parameters.Add("Filters" + "." + "ScheduledActionFilter" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValues())
                            {
                                if (publicRequestlistValue.Values.Count == 0)
                                    request.Parameters.Add("Filters" + "." + "ScheduledActionFilter" + "." + publicRequestlistValueIndex + "." + "Values", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                                     {
                                         request.Parameters.Add("Filters" + "." + "ScheduledActionFilter" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "item" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetScheduledActionName())
                {
                    request.Parameters.Add("ScheduledActionName", StringUtils.FromString(publicRequest.ScheduledActionName));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
                if(publicRequest.IsSetTargetActionType())
                {
                    request.Parameters.Add("TargetActionType", StringUtils.FromString(publicRequest.TargetActionType));
                }
            }
            return request;
        }
                    private static DescribeScheduledActionsRequestMarshaller _instance = new DescribeScheduledActionsRequestMarshaller();        

        internal static DescribeScheduledActionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeScheduledActionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}