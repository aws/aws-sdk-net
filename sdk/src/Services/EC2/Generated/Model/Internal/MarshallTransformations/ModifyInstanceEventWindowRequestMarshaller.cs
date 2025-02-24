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
    /// ModifyInstanceEventWindow Request Marshaller
    /// </summary>       
    public class ModifyInstanceEventWindowRequestMarshaller : IMarshaller<IRequest, ModifyInstanceEventWindowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceEventWindowRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyInstanceEventWindowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyInstanceEventWindow");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCronExpression())
                {
                    request.Parameters.Add("CronExpression", StringUtils.FromString(publicRequest.CronExpression));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceEventWindowId())
                {
                    request.Parameters.Add("InstanceEventWindowId", StringUtils.FromString(publicRequest.InstanceEventWindowId));
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetTimeRanges())
                {
                    if (publicRequest.TimeRanges.Count == 0)
                        request.Parameters.Add("TimeRange", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TimeRanges)
                         {
                            if(publicRequestlistValue.IsSetEndHour())
                            {
                                request.Parameters.Add("TimeRange" + "." + publicRequestlistValueIndex + "." + "EndHour", StringUtils.FromInt(publicRequestlistValue.EndHour));
                            }
                            if(publicRequestlistValue.IsSetEndWeekDay())
                            {
                                request.Parameters.Add("TimeRange" + "." + publicRequestlistValueIndex + "." + "EndWeekDay", StringUtils.FromString(publicRequestlistValue.EndWeekDay));
                            }
                            if(publicRequestlistValue.IsSetStartHour())
                            {
                                request.Parameters.Add("TimeRange" + "." + publicRequestlistValueIndex + "." + "StartHour", StringUtils.FromInt(publicRequestlistValue.StartHour));
                            }
                            if(publicRequestlistValue.IsSetStartWeekDay())
                            {
                                request.Parameters.Add("TimeRange" + "." + publicRequestlistValueIndex + "." + "StartWeekDay", StringUtils.FromString(publicRequestlistValue.StartWeekDay));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyInstanceEventWindowRequestMarshaller _instance = new ModifyInstanceEventWindowRequestMarshaller();        

        internal static ModifyInstanceEventWindowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyInstanceEventWindowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}