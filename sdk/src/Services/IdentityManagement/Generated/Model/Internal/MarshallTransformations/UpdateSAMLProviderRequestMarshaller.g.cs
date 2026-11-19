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
    /// UpdateSAMLProvider Request Marshaller
    /// </summary>
    public partial class UpdateSAMLProviderRequestMarshaller : IMarshaller<IRequest, UpdateSAMLProviderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSAMLProviderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateSAMLProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "UpdateSAMLProvider");
            request.Parameters.Add("Version", "2010-05-08");

            if (publicRequest.IsSetAddPrivateKey())
            {
                request.Parameters.Add("AddPrivateKey", StringUtils.FromString(publicRequest.AddPrivateKey));
            }
            if (publicRequest.IsSetAssertionEncryptionMode())
            {
                request.Parameters.Add("AssertionEncryptionMode", StringUtils.FromString(publicRequest.AssertionEncryptionMode));
            }
            if (publicRequest.IsSetContextProvider())
            {
                if (publicRequest.ContextProvider.IsSetKeyDefinitionList())
                {
                    if (publicRequest.ContextProvider.KeyDefinitionList.Count == 0)
                    {
                        request.Parameters.Add("ContextProvider" + ".KeyDefinitionList", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.ContextProvider.KeyDefinitionList)
                        {
                            if (item1.IsSetSourceKey())
                            {
                                request.Parameters.Add("ContextProvider" + ".KeyDefinitionList" + ".member" + "." + index1 + ".SourceKey", StringUtils.FromString(item1.SourceKey));
                            }
                            if (item1.IsSetTargetKey())
                            {
                                request.Parameters.Add("ContextProvider" + ".KeyDefinitionList" + ".member" + "." + index1 + ".TargetKey", StringUtils.FromString(item1.TargetKey));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.ContextProvider.IsSetSubjectSourceKey())
                {
                    request.Parameters.Add("ContextProvider" + ".SubjectSourceKey", StringUtils.FromString(publicRequest.ContextProvider.SubjectSourceKey));
                }
                if (publicRequest.ContextProvider.IsSetSubjectTypeSourceKey())
                {
                    request.Parameters.Add("ContextProvider" + ".SubjectTypeSourceKey", StringUtils.FromString(publicRequest.ContextProvider.SubjectTypeSourceKey));
                }
                if (publicRequest.ContextProvider.IsSetSubjectTypeValue())
                {
                    request.Parameters.Add("ContextProvider" + ".SubjectTypeValue", StringUtils.FromString(publicRequest.ContextProvider.SubjectTypeValue));
                }
            }
            if (publicRequest.IsSetIdentityCenterInstanceArn())
            {
                request.Parameters.Add("IdentityCenterInstanceArn", StringUtils.FromString(publicRequest.IdentityCenterInstanceArn));
            }
            if (publicRequest.IsSetRemoveContextProvider())
            {
                request.Parameters.Add("RemoveContextProvider", StringUtils.FromBool(publicRequest.RemoveContextProvider.Value));
            }
            if (publicRequest.IsSetRemoveIdentityCenterInstance())
            {
                request.Parameters.Add("RemoveIdentityCenterInstance", StringUtils.FromBool(publicRequest.RemoveIdentityCenterInstance.Value));
            }
            if (publicRequest.IsSetRemovePrivateKey())
            {
                request.Parameters.Add("RemovePrivateKey", StringUtils.FromString(publicRequest.RemovePrivateKey));
            }
            if (publicRequest.IsSetSAMLMetadataDocument())
            {
                request.Parameters.Add("SAMLMetadataDocument", StringUtils.FromString(publicRequest.SAMLMetadataDocument));
            }
            if (publicRequest.IsSetSAMLProviderArn())
            {
                request.Parameters.Add("SAMLProviderArn", StringUtils.FromString(publicRequest.SAMLProviderArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly UpdateSAMLProviderRequestMarshaller _instance = new();

        internal static UpdateSAMLProviderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateSAMLProviderRequestMarshaller Instance => _instance;
    }
}
