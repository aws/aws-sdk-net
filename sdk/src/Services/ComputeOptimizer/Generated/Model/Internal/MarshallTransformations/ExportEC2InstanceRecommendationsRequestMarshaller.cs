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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportEC2InstanceRecommendations Request Marshaller
    /// </summary>       
    public class ExportEC2InstanceRecommendationsRequestMarshaller : IMarshaller<IRequest, ExportEC2InstanceRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportEC2InstanceRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportEC2InstanceRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/ComputeOptimizerService/operation/ExportEC2InstanceRecommendations";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAccountIds())
                {
                    context.Writer.WriteTextString("accountIds");
                    context.Writer.WriteStartArray(publicRequest.AccountIds.Count);
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.WriteTextString(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetFieldsToExport())
                {
                    context.Writer.WriteTextString("fieldsToExport");
                    context.Writer.WriteStartArray(publicRequest.FieldsToExport.Count);
                    foreach(var publicRequestFieldsToExportListValue in publicRequest.FieldsToExport)
                    {
                            context.Writer.WriteTextString(publicRequestFieldsToExportListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetFileFormat())
                {
                    context.Writer.WriteTextString("fileFormat");
                    context.Writer.WriteTextString(publicRequest.FileFormat);
                }
                if (publicRequest.IsSetFilters())
                {
                    context.Writer.WriteTextString("filters");
                    context.Writer.WriteStartArray(publicRequest.Filters.Count);
                    foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = FilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestFiltersListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIncludeMemberAccounts())
                {
                    context.Writer.WriteTextString("includeMemberAccounts");
                    context.Writer.WriteBoolean(publicRequest.IncludeMemberAccounts.Value);
                }
                if (publicRequest.IsSetRecommendationPreferences())
                {
                    context.Writer.WriteTextString("recommendationPreferences");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RecommendationPreferencesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RecommendationPreferences, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetS3DestinationConfig())
                {
                    context.Writer.WriteTextString("s3DestinationConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3DestinationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3DestinationConfig, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static ExportEC2InstanceRecommendationsRequestMarshaller _instance = new ExportEC2InstanceRecommendationsRequestMarshaller();        

        internal static ExportEC2InstanceRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportEC2InstanceRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}