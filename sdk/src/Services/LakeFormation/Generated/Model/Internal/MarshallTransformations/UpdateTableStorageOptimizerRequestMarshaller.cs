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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTableStorageOptimizer Request Marshaller
    /// </summary>       
    public class UpdateTableStorageOptimizerRequestMarshaller : IMarshaller<IRequest, UpdateTableStorageOptimizerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTableStorageOptimizerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTableStorageOptimizerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateTableStorageOptimizer";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalogId())
                {
                    context.Writer.WritePropertyName("CatalogId");
                    context.Writer.Write(publicRequest.CatalogId);
                }

                if(publicRequest.IsSetDatabaseName())
                {
                    context.Writer.WritePropertyName("DatabaseName");
                    context.Writer.Write(publicRequest.DatabaseName);
                }

                if(publicRequest.IsSetStorageOptimizerConfig())
                {
                    context.Writer.WritePropertyName("StorageOptimizerConfig");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestStorageOptimizerConfigKvp in publicRequest.StorageOptimizerConfig)
                    {
                        context.Writer.WritePropertyName(publicRequestStorageOptimizerConfigKvp.Key);
                        var publicRequestStorageOptimizerConfigValue = publicRequestStorageOptimizerConfigKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestStorageOptimizerConfigValueKvp in publicRequestStorageOptimizerConfigValue)
                        {
                            context.Writer.WritePropertyName(publicRequestStorageOptimizerConfigValueKvp.Key);
                            var publicRequestStorageOptimizerConfigValueValue = publicRequestStorageOptimizerConfigValueKvp.Value;

                                context.Writer.Write(publicRequestStorageOptimizerConfigValueValue);
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTableName())
                {
                    context.Writer.WritePropertyName("TableName");
                    context.Writer.Write(publicRequest.TableName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateTableStorageOptimizerRequestMarshaller _instance = new UpdateTableStorageOptimizerRequestMarshaller();        

        internal static UpdateTableStorageOptimizerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTableStorageOptimizerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}