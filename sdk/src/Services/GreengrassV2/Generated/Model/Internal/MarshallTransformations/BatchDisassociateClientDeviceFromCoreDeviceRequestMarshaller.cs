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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDisassociateClientDeviceFromCoreDevice Request Marshaller
    /// </summary>       
    public class BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller : IMarshaller<IRequest, BatchDisassociateClientDeviceFromCoreDeviceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDisassociateClientDeviceFromCoreDeviceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDisassociateClientDeviceFromCoreDeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GreengrassV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-30";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCoreDeviceThingName())
                throw new AmazonGreengrassV2Exception("Request object does not have required field CoreDeviceThingName set");
            request.AddPathResource("{coreDeviceThingName}", StringUtils.FromString(publicRequest.CoreDeviceThingName));
            request.ResourcePath = "/greengrass/v2/coreDevices/{coreDeviceThingName}/disassociateClientDevices";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEntries())
                {
                    context.Writer.WritePropertyName("entries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEntriesListValue in publicRequest.Entries)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DisassociateClientDeviceFromCoreDeviceEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestEntriesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller _instance = new BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller();        

        internal static BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}