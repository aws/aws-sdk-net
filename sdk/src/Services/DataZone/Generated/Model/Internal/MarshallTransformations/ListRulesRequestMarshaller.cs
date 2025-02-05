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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRules Request Marshaller
    /// </summary>       
    public class ListRulesRequestMarshaller : IMarshaller<IRequest, ListRulesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRulesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRulesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            if (!publicRequest.IsSetTargetIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field TargetIdentifier set");
            request.AddPathResource("{targetIdentifier}", StringUtils.FromString(publicRequest.TargetIdentifier));
            if (!publicRequest.IsSetTargetType())
                throw new AmazonDataZoneException("Request object does not have required field TargetType set");
            request.AddPathResource("{targetType}", StringUtils.FromString(publicRequest.TargetType));
            
            if (publicRequest.IsSetAction())
                request.Parameters.Add("ruleAction", StringUtils.FromString(publicRequest.Action));
            
            if (publicRequest.IsSetAssetTypes())
                request.ParameterCollection.Add("assetTypes", publicRequest.AssetTypes);
            
            if (publicRequest.IsSetDataProduct())
                request.Parameters.Add("dataProduct", StringUtils.FromBool(publicRequest.DataProduct));
            
            if (publicRequest.IsSetIncludeCascaded())
                request.Parameters.Add("includeCascaded", StringUtils.FromBool(publicRequest.IncludeCascaded));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetProjectIds())
                request.ParameterCollection.Add("projectIds", publicRequest.ProjectIds);
            
            if (publicRequest.IsSetRuleType())
                request.Parameters.Add("ruleType", StringUtils.FromString(publicRequest.RuleType));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/list-rules/{targetType}/{targetIdentifier}";
            request.UseQueryString = true;

            return request;
        }
        private static ListRulesRequestMarshaller _instance = new ListRulesRequestMarshaller();        

        internal static ListRulesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRulesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}