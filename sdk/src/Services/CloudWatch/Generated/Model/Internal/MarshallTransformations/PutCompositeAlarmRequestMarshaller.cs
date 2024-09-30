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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutCompositeAlarm Request Marshaller
    /// </summary>       
    public class PutCompositeAlarmRequestMarshaller : IMarshaller<IRequest, PutCompositeAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutCompositeAlarmRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutCompositeAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "PutCompositeAlarm");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActionsEnabled())
                {
                    request.Parameters.Add("ActionsEnabled", StringUtils.FromBool(publicRequest.ActionsEnabled));
                }
                if(publicRequest.IsSetActionsSuppressor())
                {
                    request.Parameters.Add("ActionsSuppressor", StringUtils.FromString(publicRequest.ActionsSuppressor));
                }
                if(publicRequest.IsSetActionsSuppressorExtensionPeriod())
                {
                    request.Parameters.Add("ActionsSuppressorExtensionPeriod", StringUtils.FromInt(publicRequest.ActionsSuppressorExtensionPeriod));
                }
                if(publicRequest.IsSetActionsSuppressorWaitPeriod())
                {
                    request.Parameters.Add("ActionsSuppressorWaitPeriod", StringUtils.FromInt(publicRequest.ActionsSuppressorWaitPeriod));
                }
                if(publicRequest.IsSetAlarmActions())
                {
                    if (publicRequest.AlarmActions.Count == 0)
                        request.Parameters.Add("AlarmActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AlarmActions)
                         {
                             request.Parameters.Add("AlarmActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAlarmDescription())
                {
                    request.Parameters.Add("AlarmDescription", StringUtils.FromString(publicRequest.AlarmDescription));
                }
                if(publicRequest.IsSetAlarmName())
                {
                    request.Parameters.Add("AlarmName", StringUtils.FromString(publicRequest.AlarmName));
                }
                if(publicRequest.IsSetAlarmRule())
                {
                    request.Parameters.Add("AlarmRule", StringUtils.FromString(publicRequest.AlarmRule));
                }
                if(publicRequest.IsSetInsufficientDataActions())
                {
                    if (publicRequest.InsufficientDataActions.Count == 0)
                        request.Parameters.Add("InsufficientDataActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.InsufficientDataActions)
                         {
                             request.Parameters.Add("InsufficientDataActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetOKActions())
                {
                    if (publicRequest.OKActions.Count == 0)
                        request.Parameters.Add("OKActions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.OKActions)
                         {
                             request.Parameters.Add("OKActions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static PutCompositeAlarmRequestMarshaller _instance = new PutCompositeAlarmRequestMarshaller();        

        internal static PutCompositeAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutCompositeAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}