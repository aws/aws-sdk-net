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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyServerlessCache Request Marshaller
    /// </summary>
    public partial class ModifyServerlessCacheRequestMarshaller : IMarshaller<IRequest, ModifyServerlessCacheRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyServerlessCacheRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyServerlessCacheRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyServerlessCache");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetCacheUsageLimits())
            {
                if (publicRequest.CacheUsageLimits.IsSetDataStorage())
                {
                    if (publicRequest.CacheUsageLimits.DataStorage.IsSetMaximum())
                    {
                        request.Parameters.Add("CacheUsageLimits" + ".DataStorage" + ".Maximum", StringUtils.FromInt(publicRequest.CacheUsageLimits.DataStorage.Maximum.Value));
                    }
                    if (publicRequest.CacheUsageLimits.DataStorage.IsSetMinimum())
                    {
                        request.Parameters.Add("CacheUsageLimits" + ".DataStorage" + ".Minimum", StringUtils.FromInt(publicRequest.CacheUsageLimits.DataStorage.Minimum.Value));
                    }
                    if (publicRequest.CacheUsageLimits.DataStorage.IsSetUnit())
                    {
                        request.Parameters.Add("CacheUsageLimits" + ".DataStorage" + ".Unit", StringUtils.FromString(publicRequest.CacheUsageLimits.DataStorage.Unit));
                    }
                }
                if (publicRequest.CacheUsageLimits.IsSetECPUPerSecond())
                {
                    if (publicRequest.CacheUsageLimits.ECPUPerSecond.IsSetMaximum())
                    {
                        request.Parameters.Add("CacheUsageLimits" + ".ECPUPerSecond" + ".Maximum", StringUtils.FromInt(publicRequest.CacheUsageLimits.ECPUPerSecond.Maximum.Value));
                    }
                    if (publicRequest.CacheUsageLimits.ECPUPerSecond.IsSetMinimum())
                    {
                        request.Parameters.Add("CacheUsageLimits" + ".ECPUPerSecond" + ".Minimum", StringUtils.FromInt(publicRequest.CacheUsageLimits.ECPUPerSecond.Minimum.Value));
                    }
                }
            }
            if (publicRequest.IsSetDailySnapshotTime())
            {
                request.Parameters.Add("DailySnapshotTime", StringUtils.FromString(publicRequest.DailySnapshotTime));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetMajorEngineVersion())
            {
                request.Parameters.Add("MajorEngineVersion", StringUtils.FromString(publicRequest.MajorEngineVersion));
            }
            if (publicRequest.IsSetRemoveUserGroup())
            {
                request.Parameters.Add("RemoveUserGroup", StringUtils.FromBool(publicRequest.RemoveUserGroup.Value));
            }
            if (publicRequest.IsSetSecurityGroupIds())
            {
                if (publicRequest.SecurityGroupIds.Count == 0)
                {
                    request.Parameters.Add("SecurityGroupIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupIds" + ".SecurityGroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetServerlessCacheName())
            {
                request.Parameters.Add("ServerlessCacheName", StringUtils.FromString(publicRequest.ServerlessCacheName));
            }
            if (publicRequest.IsSetSnapshotRetentionLimit())
            {
                request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit.Value));
            }
            if (publicRequest.IsSetUserGroupId())
            {
                request.Parameters.Add("UserGroupId", StringUtils.FromString(publicRequest.UserGroupId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyServerlessCacheRequestMarshaller _instance = new();

        internal static ModifyServerlessCacheRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyServerlessCacheRequestMarshaller Instance => _instance;
    }
}
