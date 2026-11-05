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

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyClusterIamRoles Request Marshaller
    /// </summary>
    public partial class ModifyClusterIamRolesRequestMarshaller : IMarshaller<IRequest, ModifyClusterIamRolesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyClusterIamRolesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyClusterIamRolesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyClusterIamRoles");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAddIamRoles())
            {
                if (publicRequest.AddIamRoles.Count == 0)
                {
                    request.Parameters.Add("AddIamRoles", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AddIamRoles)
                    {
                        request.Parameters.Add("AddIamRoles" + ".IamRoleArn" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetDefaultIamRoleArn())
            {
                request.Parameters.Add("DefaultIamRoleArn", StringUtils.FromString(publicRequest.DefaultIamRoleArn));
            }
            if (publicRequest.IsSetRemoveIamRoles())
            {
                if (publicRequest.RemoveIamRoles.Count == 0)
                {
                    request.Parameters.Add("RemoveIamRoles", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RemoveIamRoles)
                    {
                        request.Parameters.Add("RemoveIamRoles" + ".IamRoleArn" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly ModifyClusterIamRolesRequestMarshaller _instance = new();

        internal static ModifyClusterIamRolesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyClusterIamRolesRequestMarshaller Instance => _instance;
    }
}
