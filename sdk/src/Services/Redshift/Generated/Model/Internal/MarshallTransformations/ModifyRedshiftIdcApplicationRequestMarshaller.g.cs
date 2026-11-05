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
    /// ModifyRedshiftIdcApplication Request Marshaller
    /// </summary>
    public partial class ModifyRedshiftIdcApplicationRequestMarshaller : IMarshaller<IRequest, ModifyRedshiftIdcApplicationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyRedshiftIdcApplicationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyRedshiftIdcApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyRedshiftIdcApplication");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAuthorizedTokenIssuerList())
            {
                if (publicRequest.AuthorizedTokenIssuerList.Count == 0)
                {
                    request.Parameters.Add("AuthorizedTokenIssuerList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AuthorizedTokenIssuerList)
                    {
                        if (item0.IsSetAuthorizedAudiencesList())
                        {
                            if (item0.AuthorizedAudiencesList.Count == 0)
                            {
                                request.Parameters.Add("AuthorizedTokenIssuerList" + ".member" + "." + index0 + ".AuthorizedAudiencesList", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.AuthorizedAudiencesList)
                                {
                                    request.Parameters.Add("AuthorizedTokenIssuerList" + ".member" + "." + index0 + ".AuthorizedAudiencesList" + ".member" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetTrustedTokenIssuerArn())
                        {
                            request.Parameters.Add("AuthorizedTokenIssuerList" + ".member" + "." + index0 + ".TrustedTokenIssuerArn", StringUtils.FromString(item0.TrustedTokenIssuerArn));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetIamRoleArn())
            {
                request.Parameters.Add("IamRoleArn", StringUtils.FromString(publicRequest.IamRoleArn));
            }
            if (publicRequest.IsSetIdcDisplayName())
            {
                request.Parameters.Add("IdcDisplayName", StringUtils.FromString(publicRequest.IdcDisplayName));
            }
            if (publicRequest.IsSetIdentityNamespace())
            {
                request.Parameters.Add("IdentityNamespace", StringUtils.FromString(publicRequest.IdentityNamespace));
            }
            if (publicRequest.IsSetRedshiftIdcApplicationArn())
            {
                request.Parameters.Add("RedshiftIdcApplicationArn", StringUtils.FromString(publicRequest.RedshiftIdcApplicationArn));
            }
            if (publicRequest.IsSetServiceIntegrations())
            {
                if (publicRequest.ServiceIntegrations.Count == 0)
                {
                    request.Parameters.Add("ServiceIntegrations", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ServiceIntegrations)
                    {
                        if (item0.IsSetLakeFormation())
                        {
                            if (item0.LakeFormation.Count == 0)
                            {
                                request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".LakeFormation", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.LakeFormation)
                                {
                                    if (item1.IsSetLakeFormationQuery())
                                    {
                                        if (item1.LakeFormationQuery.IsSetAuthorization())
                                        {
                                            request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".LakeFormation" + ".member" + "." + index1 + ".LakeFormationQuery" + ".Authorization", StringUtils.FromString(item1.LakeFormationQuery.Authorization));
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetRedshift())
                        {
                            if (item0.Redshift.Count == 0)
                            {
                                request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".Redshift", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Redshift)
                                {
                                    if (item1.IsSetConnect())
                                    {
                                        if (item1.Connect.IsSetAuthorization())
                                        {
                                            request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".Redshift" + ".member" + "." + index1 + ".Connect" + ".Authorization", StringUtils.FromString(item1.Connect.Authorization));
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetS3AccessGrants())
                        {
                            if (item0.S3AccessGrants.Count == 0)
                            {
                                request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".S3AccessGrants", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.S3AccessGrants)
                                {
                                    if (item1.IsSetReadWriteAccess())
                                    {
                                        if (item1.ReadWriteAccess.IsSetAuthorization())
                                        {
                                            request.Parameters.Add("ServiceIntegrations" + ".member" + "." + index0 + ".S3AccessGrants" + ".member" + "." + index1 + ".ReadWriteAccess" + ".Authorization", StringUtils.FromString(item1.ReadWriteAccess.Authorization));
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
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

        private static readonly ModifyRedshiftIdcApplicationRequestMarshaller _instance = new();

        internal static ModifyRedshiftIdcApplicationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyRedshiftIdcApplicationRequestMarshaller Instance => _instance;
    }
}
