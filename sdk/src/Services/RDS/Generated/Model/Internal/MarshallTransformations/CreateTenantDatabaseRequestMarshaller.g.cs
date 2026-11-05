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
    /// CreateTenantDatabase Request Marshaller
    /// </summary>
    public partial class CreateTenantDatabaseRequestMarshaller : IMarshaller<IRequest, CreateTenantDatabaseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTenantDatabaseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTenantDatabaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateTenantDatabase");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetCharacterSetName())
            {
                request.Parameters.Add("CharacterSetName", StringUtils.FromString(publicRequest.CharacterSetName));
            }
            if (publicRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
            }
            if (publicRequest.IsSetManageMasterUserPassword())
            {
                request.Parameters.Add("ManageMasterUserPassword", StringUtils.FromBool(publicRequest.ManageMasterUserPassword.Value));
            }
            if (publicRequest.IsSetMasterUserPassword())
            {
                request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
            }
            if (publicRequest.IsSetMasterUserSecretKmsKeyId())
            {
                request.Parameters.Add("MasterUserSecretKmsKeyId", StringUtils.FromString(publicRequest.MasterUserSecretKmsKeyId));
            }
            if (publicRequest.IsSetMasterUsername())
            {
                request.Parameters.Add("MasterUsername", StringUtils.FromString(publicRequest.MasterUsername));
            }
            if (publicRequest.IsSetNcharCharacterSetName())
            {
                request.Parameters.Add("NcharCharacterSetName", StringUtils.FromString(publicRequest.NcharCharacterSetName));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTenantDBName())
            {
                request.Parameters.Add("TenantDBName", StringUtils.FromString(publicRequest.TenantDBName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateTenantDatabaseRequestMarshaller _instance = new();

        internal static CreateTenantDatabaseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTenantDatabaseRequestMarshaller Instance => _instance;
    }
}
