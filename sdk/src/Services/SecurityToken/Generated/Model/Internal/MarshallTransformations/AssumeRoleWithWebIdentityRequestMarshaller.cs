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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssumeRoleWithWebIdentity Request Marshaller
    /// </summary>       
    public class AssumeRoleWithWebIdentityRequestMarshaller : IMarshaller<IRequest, AssumeRoleWithWebIdentityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssumeRoleWithWebIdentityRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssumeRoleWithWebIdentityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.Parameters.Add("Action", "AssumeRoleWithWebIdentity");
            request.Parameters.Add("Version", "2011-06-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDurationSeconds())
                {
                    request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds));
                }
                if(publicRequest.IsSetPolicy())
                {
                    request.Parameters.Add("Policy", StringUtils.FromString(publicRequest.Policy));
                }
                if(publicRequest.IsSetPolicyArns())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.PolicyArns)
                    {
                        if(publicRequestlistValue.IsSetArn())
                        {
                            request.Parameters.Add("PolicyArns" + "." + "member" + "." + publicRequestlistValueIndex + "." + "arn", StringUtils.FromString(publicRequestlistValue.Arn));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetProviderId())
                {
                    request.Parameters.Add("ProviderId", StringUtils.FromString(publicRequest.ProviderId));
                }
                if(publicRequest.IsSetRoleArn())
                {
                    request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
                }
                if(publicRequest.IsSetRoleSessionName())
                {
                    request.Parameters.Add("RoleSessionName", StringUtils.FromString(publicRequest.RoleSessionName));
                }
                if(publicRequest.IsSetWebIdentityToken())
                {
                    request.Parameters.Add("WebIdentityToken", StringUtils.FromString(publicRequest.WebIdentityToken));
                }
            }
            return request;
        }
                    private static AssumeRoleWithWebIdentityRequestMarshaller _instance = new AssumeRoleWithWebIdentityRequestMarshaller();        

        internal static AssumeRoleWithWebIdentityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssumeRoleWithWebIdentityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}