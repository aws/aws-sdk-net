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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MPA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.MPA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteInactiveApprovalTeamVersion Request Marshaller
    /// </summary>       
    public class DeleteInactiveApprovalTeamVersionRequestMarshaller : IMarshaller<IRequest, DeleteInactiveApprovalTeamVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteInactiveApprovalTeamVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteInactiveApprovalTeamVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MPA");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetArn())
                throw new AmazonMPAException("Request object does not have required field Arn set");
            request.AddPathResource("{Arn}", StringUtils.FromString(publicRequest.Arn));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonMPAException("Request object does not have required field VersionId set");
            request.AddPathResource("{VersionId}", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/approval-teams/{Arn}/{VersionId}";

            return request;
        }
        private static DeleteInactiveApprovalTeamVersionRequestMarshaller _instance = new DeleteInactiveApprovalTeamVersionRequestMarshaller();        

        internal static DeleteInactiveApprovalTeamVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteInactiveApprovalTeamVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}