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
    /// PutRecommendationPreferences Request Marshaller
    /// </summary>       
    public class PutRecommendationPreferencesRequestMarshaller : IMarshaller<IRequest, PutRecommendationPreferencesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRecommendationPreferencesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRecommendationPreferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/ComputeOptimizerService/operation/PutRecommendationPreferences";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetEnhancedInfrastructureMetrics())
                {
                    context.Writer.WriteTextString("enhancedInfrastructureMetrics");
                    context.Writer.WriteTextString(publicRequest.EnhancedInfrastructureMetrics);
                }
                if (publicRequest.IsSetExternalMetricsPreference())
                {
                    context.Writer.WriteTextString("externalMetricsPreference");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ExternalMetricsPreferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExternalMetricsPreference, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInferredWorkloadTypes())
                {
                    context.Writer.WriteTextString("inferredWorkloadTypes");
                    context.Writer.WriteTextString(publicRequest.InferredWorkloadTypes);
                }
                if (publicRequest.IsSetLookBackPeriod())
                {
                    context.Writer.WriteTextString("lookBackPeriod");
                    context.Writer.WriteTextString(publicRequest.LookBackPeriod);
                }
                if (publicRequest.IsSetPreferredResources())
                {
                    context.Writer.WriteTextString("preferredResources");
                    context.Writer.WriteStartArray(publicRequest.PreferredResources.Count);
                    foreach(var publicRequestPreferredResourcesListValue in publicRequest.PreferredResources)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = PreferredResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestPreferredResourcesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetResourceType())
                {
                    context.Writer.WriteTextString("resourceType");
                    context.Writer.WriteTextString(publicRequest.ResourceType);
                }
                if (publicRequest.IsSetSavingsEstimationMode())
                {
                    context.Writer.WriteTextString("savingsEstimationMode");
                    context.Writer.WriteTextString(publicRequest.SavingsEstimationMode);
                }
                if (publicRequest.IsSetScope())
                {
                    context.Writer.WriteTextString("scope");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ScopeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Scope, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetUtilizationPreferences())
                {
                    context.Writer.WriteTextString("utilizationPreferences");
                    context.Writer.WriteStartArray(publicRequest.UtilizationPreferences.Count);
                    foreach(var publicRequestUtilizationPreferencesListValue in publicRequest.UtilizationPreferences)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = UtilizationPreferenceMarshaller.Instance;
                        marshaller.Marshall(publicRequestUtilizationPreferencesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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
        private static PutRecommendationPreferencesRequestMarshaller _instance = new PutRecommendationPreferencesRequestMarshaller();        

        internal static PutRecommendationPreferencesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRecommendationPreferencesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}