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
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssumeRole Request Marshaller
    /// </summary>       
    public class AssumeRoleRequestMarshaller : IMarshaller<IRequest, AssumeRoleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssumeRoleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssumeRoleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.Parameters.Add("Action", "AssumeRole");
            request.Parameters.Add("Version", "2011-06-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDurationSeconds())
                {
                    request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds));
                }
                if(publicRequest.IsSetExternalId())
                {
                    request.Parameters.Add("ExternalId", StringUtils.FromString(publicRequest.ExternalId));
                }
                if(publicRequest.IsSetPolicy())
                {
                    request.Parameters.Add("Policy", StringUtils.FromString(publicRequest.Policy));
                }
                if(publicRequest.IsSetPolicyArns())
                {
                    if (publicRequest.PolicyArns.Count == 0)
                        request.Parameters.Add("PolicyArns", "");
                    else
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
                }
                if(publicRequest.IsSetProvidedContexts())
                {
                    if (publicRequest.ProvidedContexts.Count == 0)
                        request.Parameters.Add("ProvidedContexts", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ProvidedContexts)
                         {
                            if(publicRequestlistValue.IsSetContextAssertion())
                            {
                                request.Parameters.Add("ProvidedContexts" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ContextAssertion", StringUtils.FromString(publicRequestlistValue.ContextAssertion));
                            }
                            if(publicRequestlistValue.IsSetProviderArn())
                            {
                                request.Parameters.Add("ProvidedContexts" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ProviderArn", StringUtils.FromString(publicRequestlistValue.ProviderArn));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRoleArn())
                {
                    request.Parameters.Add("RoleArn", StringUtils.FromString(publicRequest.RoleArn));
                }
                if(publicRequest.IsSetRoleSessionName())
                {
                    request.Parameters.Add("RoleSessionName", StringUtils.FromString(publicRequest.RoleSessionName));
                }
                if(publicRequest.IsSetSerialNumber())
                {
                    request.Parameters.Add("SerialNumber", StringUtils.FromString(publicRequest.SerialNumber));
                }
                if(publicRequest.IsSetSourceIdentity())
                {
                    request.Parameters.Add("SourceIdentity", StringUtils.FromString(publicRequest.SourceIdentity));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTokenCode())
                {
                    request.Parameters.Add("TokenCode", StringUtils.FromString(publicRequest.TokenCode));
                }
                if(publicRequest.IsSetTransitiveTagKeys())
                {
                    if (publicRequest.TransitiveTagKeys.Count == 0)
                        request.Parameters.Add("TransitiveTagKeys", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TransitiveTagKeys)
                         {
                             request.Parameters.Add("TransitiveTagKeys" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static AssumeRoleRequestMarshaller _instance = new AssumeRoleRequestMarshaller();        

        internal static AssumeRoleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssumeRoleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}