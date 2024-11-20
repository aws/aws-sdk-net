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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyRedshiftIdcApplication Request Marshaller
    /// </summary>       
    public class ModifyRedshiftIdcApplicationRequestMarshaller : IMarshaller<IRequest, ModifyRedshiftIdcApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyRedshiftIdcApplicationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyRedshiftIdcApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "ModifyRedshiftIdcApplication");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAuthorizedTokenIssuerList())
                {
                    if (publicRequest.AuthorizedTokenIssuerList.Count == 0)
                        request.Parameters.Add("AuthorizedTokenIssuerList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AuthorizedTokenIssuerList)
                         {
                            if(publicRequestlistValue.IsSetAuthorizedAudiencesList())
                            {
                                if (publicRequestlistValue.AuthorizedAudiencesList.Count == 0)
                                    request.Parameters.Add("AuthorizedTokenIssuerList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthorizedAudiencesList", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.AuthorizedAudiencesList)
                                     {
                                         request.Parameters.Add("AuthorizedTokenIssuerList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AuthorizedAudiencesList" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetTrustedTokenIssuerArn())
                            {
                                request.Parameters.Add("AuthorizedTokenIssuerList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TrustedTokenIssuerArn", StringUtils.FromString(publicRequestlistValue.TrustedTokenIssuerArn));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIamRoleArn())
                {
                    request.Parameters.Add("IamRoleArn", StringUtils.FromString(publicRequest.IamRoleArn));
                }
                if(publicRequest.IsSetIdcDisplayName())
                {
                    request.Parameters.Add("IdcDisplayName", StringUtils.FromString(publicRequest.IdcDisplayName));
                }
                if(publicRequest.IsSetIdentityNamespace())
                {
                    request.Parameters.Add("IdentityNamespace", StringUtils.FromString(publicRequest.IdentityNamespace));
                }
                if(publicRequest.IsSetRedshiftIdcApplicationArn())
                {
                    request.Parameters.Add("RedshiftIdcApplicationArn", StringUtils.FromString(publicRequest.RedshiftIdcApplicationArn));
                }
                if(publicRequest.IsSetServiceIntegrations())
                {
                    if (publicRequest.ServiceIntegrations.Count == 0)
                        request.Parameters.Add("ServiceIntegrations", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ServiceIntegrations)
                         {
                            if(publicRequestlistValue.IsSetLakeFormation())
                            {
                                if (publicRequestlistValue.LakeFormation.Count == 0)
                                    request.Parameters.Add("ServiceIntegrations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LakeFormation", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.LakeFormation)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetLakeFormationQuery())
                                        {
                                            if(publicRequestlistValuelistValue.LakeFormationQuery.IsSetAuthorization())
                                            {
                                                request.Parameters.Add("ServiceIntegrations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LakeFormation" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "LakeFormationQuery" + "." + "Authorization", StringUtils.FromString(publicRequestlistValuelistValue.LakeFormationQuery.Authorization));
                                            }
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetS3AccessGrants())
                            {
                                if (publicRequestlistValue.S3AccessGrants.Count == 0)
                                    request.Parameters.Add("ServiceIntegrations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "S3AccessGrants", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.S3AccessGrants)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetReadWriteAccess())
                                        {
                                            if(publicRequestlistValuelistValue.ReadWriteAccess.IsSetAuthorization())
                                            {
                                                request.Parameters.Add("ServiceIntegrations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "S3AccessGrants" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "ReadWriteAccess" + "." + "Authorization", StringUtils.FromString(publicRequestlistValuelistValue.ReadWriteAccess.Authorization));
                                            }
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyRedshiftIdcApplicationRequestMarshaller _instance = new ModifyRedshiftIdcApplicationRequestMarshaller();        

        internal static ModifyRedshiftIdcApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyRedshiftIdcApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}