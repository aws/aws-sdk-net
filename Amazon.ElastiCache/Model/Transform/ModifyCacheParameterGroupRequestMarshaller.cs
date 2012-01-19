/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElastiCache.Model.Transform
{
    /// <summary>
    /// Modify Cache Parameter Group Request Marshaller
    /// </summary>       
    public class ModifyCacheParameterGroupRequestMarshaller : IMarshaller<IRequest<ModifyCacheParameterGroupRequest>, ModifyCacheParameterGroupRequest> 
    {

        public IRequest<ModifyCacheParameterGroupRequest> Marshall(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest) 
        {
            IRequest<ModifyCacheParameterGroupRequest> request = new DefaultRequest<ModifyCacheParameterGroupRequest>(modifyCacheParameterGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "ModifyCacheParameterGroup");
            request.Parameters.Add("Version", "2011-07-15");
            if (modifyCacheParameterGroupRequest != null && modifyCacheParameterGroupRequest.IsSetCacheParameterGroupName()) 
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(modifyCacheParameterGroupRequest.CacheParameterGroupName));
            }

            if (modifyCacheParameterGroupRequest != null) 
            {
                List<ParameterNameValue> parameterNameValuesList = modifyCacheParameterGroupRequest.ParameterNameValues;
                int parameterNameValuesListIndex = 1;
                foreach (ParameterNameValue parameterNameValuesListValue in parameterNameValuesList) 
                { 
                    if (parameterNameValuesListValue != null && parameterNameValuesListValue.IsSetParameterName()) 
                    {
                        request.Parameters.Add("ParameterNameValues.member." + parameterNameValuesListIndex + ".ParameterName", StringUtils.FromString(parameterNameValuesListValue.ParameterName));
                    }
                    if (parameterNameValuesListValue != null && parameterNameValuesListValue.IsSetParameterValue()) 
                    {
                        request.Parameters.Add("ParameterNameValues.member." + parameterNameValuesListIndex + ".ParameterValue", StringUtils.FromString(parameterNameValuesListValue.ParameterValue));
                    }

                    parameterNameValuesListIndex++;
                }
            }


            return request;
        }
    }
}
