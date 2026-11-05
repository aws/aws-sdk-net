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
    /// ModifyUserGroup Request Marshaller
    /// </summary>
    public partial class ModifyUserGroupRequestMarshaller : IMarshaller<IRequest, ModifyUserGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyUserGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyUserGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyUserGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetUserGroupId())
            {
                request.Parameters.Add("UserGroupId", StringUtils.FromString(publicRequest.UserGroupId));
            }
            if (publicRequest.IsSetUserIdsToAdd())
            {
                if (publicRequest.UserIdsToAdd.Count == 0)
                {
                    request.Parameters.Add("UserIdsToAdd", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.UserIdsToAdd)
                    {
                        request.Parameters.Add("UserIdsToAdd" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetUserIdsToRemove())
            {
                if (publicRequest.UserIdsToRemove.Count == 0)
                {
                    request.Parameters.Add("UserIdsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.UserIdsToRemove)
                    {
                        request.Parameters.Add("UserIdsToRemove" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyUserGroupRequestMarshaller _instance = new();

        internal static ModifyUserGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyUserGroupRequestMarshaller Instance => _instance;
    }
}
