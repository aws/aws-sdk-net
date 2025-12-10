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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAlarms Request Marshaller
    /// </summary>       
    public class DescribeAlarmsRequestMarshaller : IMarshaller<IRequest, DescribeAlarmsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAlarmsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAlarmsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            string target = "GraniteServiceVersion20100801.DescribeAlarms";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionPrefix())
                {
                    context.Writer.WritePropertyName("ActionPrefix");
                    context.Writer.Write(publicRequest.ActionPrefix);
                }

                if(publicRequest.IsSetAlarmNamePrefix())
                {
                    context.Writer.WritePropertyName("AlarmNamePrefix");
                    context.Writer.Write(publicRequest.AlarmNamePrefix);
                }

                if(publicRequest.IsSetAlarmNames())
                {
                    context.Writer.WritePropertyName("AlarmNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAlarmNamesListValue in publicRequest.AlarmNames)
                    {
                            context.Writer.Write(publicRequestAlarmNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAlarmTypes())
                {
                    context.Writer.WritePropertyName("AlarmTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAlarmTypesListValue in publicRequest.AlarmTypes)
                    {
                            context.Writer.Write(publicRequestAlarmTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetChildrenOfAlarmName())
                {
                    context.Writer.WritePropertyName("ChildrenOfAlarmName");
                    context.Writer.Write(publicRequest.ChildrenOfAlarmName);
                }

                if(publicRequest.IsSetMaxRecords())
                {
                    context.Writer.WritePropertyName("MaxRecords");
                    context.Writer.Write(publicRequest.MaxRecords);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetParentsOfAlarmName())
                {
                    context.Writer.WritePropertyName("ParentsOfAlarmName");
                    context.Writer.Write(publicRequest.ParentsOfAlarmName);
                }

                if(publicRequest.IsSetStateValue())
                {
                    context.Writer.WritePropertyName("StateValue");
                    context.Writer.Write(publicRequest.StateValue);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeAlarmsRequestMarshaller _instance = new DescribeAlarmsRequestMarshaller();        

        internal static DescribeAlarmsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAlarmsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}