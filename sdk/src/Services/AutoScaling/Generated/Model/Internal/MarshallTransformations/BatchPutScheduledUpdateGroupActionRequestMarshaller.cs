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
    /// BatchPutScheduledUpdateGroupAction Request Marshaller
    /// </summary>       
    public class BatchPutScheduledUpdateGroupActionRequestMarshaller : IMarshaller<IRequest, BatchPutScheduledUpdateGroupActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutScheduledUpdateGroupActionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchPutScheduledUpdateGroupActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "BatchPutScheduledUpdateGroupAction");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetScheduledUpdateGroupActions())
                {
                    if (publicRequest.ScheduledUpdateGroupActions.Count == 0)
                        request.Parameters.Add("ScheduledUpdateGroupActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ScheduledUpdateGroupActions)
                         {
                            if(publicRequestlistValue.IsSetDesiredCapacity())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DesiredCapacity", StringUtils.FromInt(publicRequestlistValue.DesiredCapacity));
                            }
                            if(publicRequestlistValue.IsSetEndTime())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestlistValue.EndTime));
                            }
                            if(publicRequestlistValue.IsSetMaxSize())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MaxSize", StringUtils.FromInt(publicRequestlistValue.MaxSize));
                            }
                            if(publicRequestlistValue.IsSetMinSize())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MinSize", StringUtils.FromInt(publicRequestlistValue.MinSize));
                            }
                            if(publicRequestlistValue.IsSetRecurrence())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Recurrence", StringUtils.FromString(publicRequestlistValue.Recurrence));
                            }
                            if(publicRequestlistValue.IsSetScheduledActionName())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ScheduledActionName", StringUtils.FromString(publicRequestlistValue.ScheduledActionName));
                            }
                            if(publicRequestlistValue.IsSetStartTime())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestlistValue.StartTime));
                            }
                            if(publicRequestlistValue.IsSetTimeZone())
                            {
                                request.Parameters.Add("ScheduledUpdateGroupActions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TimeZone", StringUtils.FromString(publicRequestlistValue.TimeZone));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static BatchPutScheduledUpdateGroupActionRequestMarshaller _instance = new BatchPutScheduledUpdateGroupActionRequestMarshaller();        

        internal static BatchPutScheduledUpdateGroupActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchPutScheduledUpdateGroupActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}