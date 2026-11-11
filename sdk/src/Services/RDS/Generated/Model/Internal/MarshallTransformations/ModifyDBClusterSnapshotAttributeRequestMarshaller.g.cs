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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDBClusterSnapshotAttribute Request Marshaller
    /// </summary>
    public partial class ModifyDBClusterSnapshotAttributeRequestMarshaller : IMarshaller<IRequest, ModifyDBClusterSnapshotAttributeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBClusterSnapshotAttributeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBClusterSnapshotAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBClusterSnapshotAttribute");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetAttributeName())
            {
                request.Parameters.Add("AttributeName", StringUtils.FromString(publicRequest.AttributeName));
            }
            if (publicRequest.IsSetDBClusterSnapshotIdentifier())
            {
                request.Parameters.Add("DBClusterSnapshotIdentifier", StringUtils.FromString(publicRequest.DBClusterSnapshotIdentifier));
            }
            if (publicRequest.IsSetValuesToAdd())
            {
                if (publicRequest.ValuesToAdd.Count == 0)
                {
                    request.Parameters.Add("ValuesToAdd", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ValuesToAdd)
                    {
                        request.Parameters.Add("ValuesToAdd" + ".AttributeValue" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetValuesToRemove())
            {
                if (publicRequest.ValuesToRemove.Count == 0)
                {
                    request.Parameters.Add("ValuesToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ValuesToRemove)
                    {
                        request.Parameters.Add("ValuesToRemove" + ".AttributeValue" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly ModifyDBClusterSnapshotAttributeRequestMarshaller _instance = new();

        internal static ModifyDBClusterSnapshotAttributeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBClusterSnapshotAttributeRequestMarshaller Instance => _instance;
    }
}
