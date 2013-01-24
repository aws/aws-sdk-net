/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Reset Cache Parameter Group Request Marshaller
    /// </summary>       
    public class ResetCacheParameterGroupRequestMarshaller : IMarshaller<IRequest, ResetCacheParameterGroupRequest>
    {
        public IRequest Marshall(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest)
        {
            IRequest request = new DefaultRequest(resetCacheParameterGroupRequest, "AmazonElastiCache");
            request.Parameters.Add("Action", "ResetCacheParameterGroup");
            request.Parameters.Add("Version", "2012-11-15");
            if (resetCacheParameterGroupRequest != null && resetCacheParameterGroupRequest.IsSetCacheParameterGroupName())
            {
                request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(resetCacheParameterGroupRequest.CacheParameterGroupName));
            }
            if (resetCacheParameterGroupRequest != null && resetCacheParameterGroupRequest.IsSetResetAllParameters())
            {
                request.Parameters.Add("ResetAllParameters", StringUtils.FromBool(resetCacheParameterGroupRequest.ResetAllParameters));
            }

            if (resetCacheParameterGroupRequest != null)
            {
                List<ParameterNameValue> parameterNameValuesList = resetCacheParameterGroupRequest.ParameterNameValues;
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
