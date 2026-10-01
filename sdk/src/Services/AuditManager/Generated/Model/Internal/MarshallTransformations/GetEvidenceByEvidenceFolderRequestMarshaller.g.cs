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

using Amazon.AuditManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEvidenceByEvidenceFolder Request Marshaller
    /// </summary>
    public partial class GetEvidenceByEvidenceFolderRequestMarshaller : IMarshaller<IRequest, GetEvidenceByEvidenceFolderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEvidenceByEvidenceFolderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEvidenceByEvidenceFolderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetAssessmentId())
            {
                throw new AmazonAuditManagerException("Request object does not have required field AssessmentId set");
            }
            request.AddPathResource("{assessmentId}", StringUtils.FromString(publicRequest.AssessmentId));

            if (!publicRequest.IsSetControlSetId())
            {
                throw new AmazonAuditManagerException("Request object does not have required field ControlSetId set");
            }
            request.AddPathResource("{controlSetId}", StringUtils.FromString(publicRequest.ControlSetId));

            if (!publicRequest.IsSetEvidenceFolderId())
            {
                throw new AmazonAuditManagerException("Request object does not have required field EvidenceFolderId set");
            }
            request.AddPathResource("{evidenceFolderId}", StringUtils.FromString(publicRequest.EvidenceFolderId));

            request.ResourcePath = "/assessments/{assessmentId}/controlSets/{controlSetId}/evidenceFolders/{evidenceFolderId}/evidence";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetEvidenceByEvidenceFolderRequestMarshaller _instance = new();

        internal static GetEvidenceByEvidenceFolderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEvidenceByEvidenceFolderRequestMarshaller Instance => _instance;
    }
}
