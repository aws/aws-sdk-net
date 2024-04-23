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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyServerlessCache Request Marshaller
    /// </summary>       
    public class ModifyServerlessCacheRequestMarshaller : IMarshaller<IRequest, ModifyServerlessCacheRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyServerlessCacheRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyServerlessCacheRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyServerlessCache");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCacheUsageLimits())
                {
                    if(publicRequest.CacheUsageLimits.IsSetDataStorage())
                    {
                        if(publicRequest.CacheUsageLimits.DataStorage.IsSetMaximum())
                        {
                            request.Parameters.Add("CacheUsageLimits" + "." + "DataStorage" + "." + "Maximum", StringUtils.FromInt(publicRequest.CacheUsageLimits.DataStorage.Maximum));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.CacheUsageLimits.DataStorage.IsSetMinimum())
                        {
                            request.Parameters.Add("CacheUsageLimits" + "." + "DataStorage" + "." + "Minimum", StringUtils.FromInt(publicRequest.CacheUsageLimits.DataStorage.Minimum));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.CacheUsageLimits.DataStorage.IsSetUnit())
                        {
                            request.Parameters.Add("CacheUsageLimits" + "." + "DataStorage" + "." + "Unit", StringUtils.FromString(publicRequest.CacheUsageLimits.DataStorage.Unit));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.CacheUsageLimits.IsSetECPUPerSecond())
                    {
                        if(publicRequest.CacheUsageLimits.ECPUPerSecond.IsSetMaximum())
                        {
                            request.Parameters.Add("CacheUsageLimits" + "." + "ECPUPerSecond" + "." + "Maximum", StringUtils.FromInt(publicRequest.CacheUsageLimits.ECPUPerSecond.Maximum));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.CacheUsageLimits.ECPUPerSecond.IsSetMinimum())
                        {
                            request.Parameters.Add("CacheUsageLimits" + "." + "ECPUPerSecond" + "." + "Minimum", StringUtils.FromInt(publicRequest.CacheUsageLimits.ECPUPerSecond.Minimum));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDailySnapshotTime())
                {
                    request.Parameters.Add("DailySnapshotTime", StringUtils.FromString(publicRequest.DailySnapshotTime));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRemoveUserGroup())
                {
                    request.Parameters.Add("RemoveUserGroup", StringUtils.FromBool(publicRequest.RemoveUserGroup));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                    {
                        request.Parameters.Add("SecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetServerlessCacheName())
                {
                    request.Parameters.Add("ServerlessCacheName", StringUtils.FromString(publicRequest.ServerlessCacheName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUserGroupId())
                {
                    request.Parameters.Add("UserGroupId", StringUtils.FromString(publicRequest.UserGroupId));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifyServerlessCacheRequestMarshaller _instance = new ModifyServerlessCacheRequestMarshaller();        

        internal static ModifyServerlessCacheRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyServerlessCacheRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}