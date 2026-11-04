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

using Amazon.IdentityManagement.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDelegationRequest Request Marshaller
    /// </summary>
    public partial class CreateDelegationRequestRequestMarshaller : IMarshaller<IRequest, CreateDelegationRequestRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDelegationRequestRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDelegationRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDelegationRequest");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetNotificationChannel())
            {
                request.Parameters.Add("NotificationChannel", StringUtils.FromString(publicRequest.NotificationChannel));
            }
            if (publicRequest.IsSetOnlySendByOwner())
            {
                request.Parameters.Add("OnlySendByOwner", StringUtils.FromBool(publicRequest.OnlySendByOwner.Value));
            }
            if (publicRequest.IsSetOwnerAccountId())
            {
                request.Parameters.Add("OwnerAccountId", StringUtils.FromString(publicRequest.OwnerAccountId));
            }
            if (publicRequest.IsSetPermissions())
            {
                if (publicRequest.Permissions.IsSetParameters())
                {
                    if (publicRequest.Permissions.Parameters.Count == 0)
                    {
                        request.Parameters.Add("Permissions" + ".Parameters", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Permissions.Parameters)
                        {
                            if (item1.IsSetName())
                            {
                                request.Parameters.Add("Permissions" + ".Parameters" + ".member" + "." + index1 + ".Name", StringUtils.FromString(item1.Name));
                            }
                            if (item1.IsSetType())
                            {
                                request.Parameters.Add("Permissions" + ".Parameters" + ".member" + "." + index1 + ".Type", StringUtils.FromString(item1.Type));
                            }
                            if (item1.IsSetValues())
                            {
                                if (item1.Values.Count == 0)
                                {
                                    request.Parameters.Add("Permissions" + ".Parameters" + ".member" + "." + index1 + ".Values", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item1.Values)
                                    {
                                        request.Parameters.Add("Permissions" + ".Parameters" + ".member" + "." + index1 + ".Values" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.Permissions.IsSetPolicyTemplateArn())
                {
                    request.Parameters.Add("Permissions" + ".PolicyTemplateArn", StringUtils.FromString(publicRequest.Permissions.PolicyTemplateArn));
                }
            }
            if (publicRequest.IsSetRedirectUrl())
            {
                request.Parameters.Add("RedirectUrl", StringUtils.FromString(publicRequest.RedirectUrl));
            }
            if (publicRequest.IsSetRequestMessage())
            {
                request.Parameters.Add("RequestMessage", StringUtils.FromString(publicRequest.RequestMessage));
            }
            if (publicRequest.IsSetRequestorWorkflowId())
            {
                request.Parameters.Add("RequestorWorkflowId", StringUtils.FromString(publicRequest.RequestorWorkflowId));
            }
            if (publicRequest.IsSetSessionDuration())
            {
                request.Parameters.Add("SessionDuration", StringUtils.FromInt(publicRequest.SessionDuration.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateDelegationRequestRequestMarshaller _instance = new();

        internal static CreateDelegationRequestRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDelegationRequestRequestMarshaller Instance => _instance;
    }
}
