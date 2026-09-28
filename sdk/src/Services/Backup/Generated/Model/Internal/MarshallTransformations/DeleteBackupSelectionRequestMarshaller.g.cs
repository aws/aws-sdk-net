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

using Amazon.Backup.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBackupSelection Request Marshaller
    /// </summary>
    public partial class DeleteBackupSelectionRequestMarshaller : IMarshaller<IRequest, DeleteBackupSelectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBackupSelectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteBackupSelectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetBackupPlanId())
            {
                throw new AmazonBackupException("Request object does not have required field BackupPlanId set");
            }
            request.AddPathResource("{BackupPlanId}", StringUtils.FromString(publicRequest.BackupPlanId));

            if (!publicRequest.IsSetSelectionId())
            {
                throw new AmazonBackupException("Request object does not have required field SelectionId set");
            }
            request.AddPathResource("{SelectionId}", StringUtils.FromString(publicRequest.SelectionId));

            request.ResourcePath = "/backup/plans/{BackupPlanId}/selections/{SelectionId}";

            return request;
        }

        private static readonly DeleteBackupSelectionRequestMarshaller _instance = new();

        internal static DeleteBackupSelectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteBackupSelectionRequestMarshaller Instance => _instance;
    }
}
