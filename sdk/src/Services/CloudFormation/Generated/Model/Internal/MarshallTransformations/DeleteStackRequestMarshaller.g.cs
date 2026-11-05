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

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteStack Request Marshaller
    /// </summary>
    public partial class DeleteStackRequestMarshaller : IMarshaller<IRequest, DeleteStackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteStackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DeleteStack");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetClientRequestToken())
            {
                request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
            }
            if (publicRequest.IsSetDeletionMode())
            {
                request.Parameters.Add("DeletionMode", StringUtils.FromString(publicRequest.DeletionMode));
            }
            if (publicRequest.IsSetDeploymentConfig())
            {
                if (publicRequest.DeploymentConfig.IsSetDisableRollback())
                {
                    request.Parameters.Add("DeploymentConfig" + ".DisableRollback", StringUtils.FromBool(publicRequest.DeploymentConfig.DisableRollback.Value));
                }
                if (publicRequest.DeploymentConfig.IsSetMode())
                {
                    request.Parameters.Add("DeploymentConfig" + ".Mode", StringUtils.FromString(publicRequest.DeploymentConfig.Mode));
                }
            }
            if (publicRequest.IsSetRetainResources())
            {
                if (publicRequest.RetainResources.Count == 0)
                {
                    request.Parameters.Add("RetainResources", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RetainResources)
                    {
                        request.Parameters.Add("RetainResources" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetRoleARN())
            {
                request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
            }
            if (publicRequest.IsSetStackName())
            {
                request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DeleteStackRequestMarshaller _instance = new();

        internal static DeleteStackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteStackRequestMarshaller Instance => _instance;
    }
}
