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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveThingFromBillingGroup Request Marshaller
    /// </summary>       
    public class RemoveThingFromBillingGroupRequestMarshaller : IMarshaller<IRequest, RemoveThingFromBillingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveThingFromBillingGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveThingFromBillingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/billing-groups/removeThingFromBillingGroup";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBillingGroupArn())
                {
                    context.Writer.WritePropertyName("billingGroupArn");
                    context.Writer.Write(publicRequest.BillingGroupArn);
                }

                if(publicRequest.IsSetBillingGroupName())
                {
                    context.Writer.WritePropertyName("billingGroupName");
                    context.Writer.Write(publicRequest.BillingGroupName);
                }

                if(publicRequest.IsSetThingArn())
                {
                    context.Writer.WritePropertyName("thingArn");
                    context.Writer.Write(publicRequest.ThingArn);
                }

                if(publicRequest.IsSetThingName())
                {
                    context.Writer.WritePropertyName("thingName");
                    context.Writer.Write(publicRequest.ThingName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RemoveThingFromBillingGroupRequestMarshaller _instance = new RemoveThingFromBillingGroupRequestMarshaller();        

        internal static RemoveThingFromBillingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveThingFromBillingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}