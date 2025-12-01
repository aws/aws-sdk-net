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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataTablePrimaryValues Request Marshaller
    /// </summary>       
    public class UpdateDataTablePrimaryValuesRequestMarshaller : IMarshaller<IRequest, UpdateDataTablePrimaryValuesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataTablePrimaryValuesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataTablePrimaryValuesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDataTableId())
                throw new AmazonConnectException("Request object does not have required field DataTableId set");
            request.AddPathResource("{DataTableId}", StringUtils.FromString(publicRequest.DataTableId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/data-tables/{InstanceId}/{DataTableId}/values/update-primary";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLockVersion())
                {
                    context.Writer.WritePropertyName("LockVersion");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataTableLockVersionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LockVersion, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNewPrimaryValues())
                {
                    context.Writer.WritePropertyName("NewPrimaryValues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNewPrimaryValuesListValue in publicRequest.NewPrimaryValues)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PrimaryValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestNewPrimaryValuesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPrimaryValues())
                {
                    context.Writer.WritePropertyName("PrimaryValues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPrimaryValuesListValue in publicRequest.PrimaryValues)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PrimaryValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestPrimaryValuesListValue, context);

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
        private static UpdateDataTablePrimaryValuesRequestMarshaller _instance = new UpdateDataTablePrimaryValuesRequestMarshaller();        

        internal static UpdateDataTablePrimaryValuesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataTablePrimaryValuesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}