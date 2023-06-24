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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FinSpaceData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FinSpaceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataView Request Marshaller
    /// </summary>       
    public class CreateDataViewRequestMarshaller : IMarshaller<IRequest, CreateDataViewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataViewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataViewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FinSpaceData");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-13";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatasetId())
                throw new AmazonFinSpaceDataException("Request object does not have required field DatasetId set");
            request.AddPathResource("{datasetId}", StringUtils.FromString(publicRequest.DatasetId));
            request.ResourcePath = "/datasets/{datasetId}/dataviewsv2";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAsOfTimestamp())
                {
                    context.Writer.WritePropertyName("asOfTimestamp");
                    context.Writer.Write(publicRequest.AsOfTimestamp);
                }

                if(publicRequest.IsSetAutoUpdate())
                {
                    context.Writer.WritePropertyName("autoUpdate");
                    context.Writer.Write(publicRequest.AutoUpdate);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDestinationTypeParams())
                {
                    context.Writer.WritePropertyName("destinationTypeParams");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataViewDestinationTypeParamsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DestinationTypeParams, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPartitionColumns())
                {
                    context.Writer.WritePropertyName("partitionColumns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPartitionColumnsListValue in publicRequest.PartitionColumns)
                    {
                            context.Writer.Write(publicRequestPartitionColumnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSortColumns())
                {
                    context.Writer.WritePropertyName("sortColumns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSortColumnsListValue in publicRequest.SortColumns)
                    {
                            context.Writer.Write(publicRequestSortColumnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDataViewRequestMarshaller _instance = new CreateDataViewRequestMarshaller();        

        internal static CreateDataViewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataViewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}