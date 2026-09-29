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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDashboardEmbedUrl Request Marshaller
    /// </summary>
    public partial class GetDashboardEmbedUrlRequestMarshaller : IMarshaller<IRequest, GetDashboardEmbedUrlRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDashboardEmbedUrlRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDashboardEmbedUrlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAdditionalDashboardIds())
            {
                request.ParameterCollection.Add("additional-dashboard-ids", publicRequest.AdditionalDashboardIds);
            }

            if (string.IsNullOrEmpty(publicRequest.IdentityType))
            {
                throw new AmazonQuickSightException("Request object does not have required field IdentityType set");
            }

            if (publicRequest.IsSetIdentityType())
            {
                request.Parameters.Add("creds-type", StringUtils.FromString(publicRequest.IdentityType));
            }

            if (publicRequest.IsSetNamespace())
            {
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            }

            if (publicRequest.IsSetResetDisabled())
            {
                request.Parameters.Add("reset-disabled", StringUtils.FromBool(publicRequest.ResetDisabled.Value));
            }

            if (publicRequest.IsSetSessionLifetimeInMinutes())
            {
                request.Parameters.Add("session-lifetime", StringUtils.FromLong(publicRequest.SessionLifetimeInMinutes.Value));
            }

            if (publicRequest.IsSetStatePersistenceEnabled())
            {
                request.Parameters.Add("state-persistence-enabled", StringUtils.FromBool(publicRequest.StatePersistenceEnabled.Value));
            }

            if (publicRequest.IsSetUndoRedoDisabled())
            {
                request.Parameters.Add("undo-redo-disabled", StringUtils.FromBool(publicRequest.UndoRedoDisabled.Value));
            }

            if (publicRequest.IsSetUserArn())
            {
                request.Parameters.Add("user-arn", StringUtils.FromString(publicRequest.UserArn));
            }

            if (!publicRequest.IsSetAwsAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            }
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));

            if (!publicRequest.IsSetDashboardId())
            {
                throw new AmazonQuickSightException("Request object does not have required field DashboardId set");
            }
            request.AddPathResource("{DashboardId}", StringUtils.FromString(publicRequest.DashboardId));

            request.ResourcePath = "/accounts/{AwsAccountId}/dashboards/{DashboardId}/embed-url";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetDashboardEmbedUrlRequestMarshaller _instance = new();

        internal static GetDashboardEmbedUrlRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDashboardEmbedUrlRequestMarshaller Instance => _instance;
    }
}
