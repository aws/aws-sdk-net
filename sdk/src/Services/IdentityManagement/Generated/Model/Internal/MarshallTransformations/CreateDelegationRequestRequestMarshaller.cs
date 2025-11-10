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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDelegationRequest Request Marshaller
    /// </summary>       
    public class CreateDelegationRequestRequestMarshaller : IMarshaller<IRequest, CreateDelegationRequestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDelegationRequestRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDelegationRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "CreateDelegationRequest");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetNotificationChannel())
                {
                    request.Parameters.Add("NotificationChannel", StringUtils.FromString(publicRequest.NotificationChannel));
                }
                if(publicRequest.IsSetOnlySendByOwner())
                {
                    request.Parameters.Add("OnlySendByOwner", StringUtils.FromBool(publicRequest.OnlySendByOwner));
                }
                if(publicRequest.IsSetOwnerAccountId())
                {
                    request.Parameters.Add("OwnerAccountId", StringUtils.FromString(publicRequest.OwnerAccountId));
                }
                if(publicRequest.IsSetPermissions())
                {
                    if(publicRequest.Permissions.IsSetParameters())
                    {
                        int publicRequestPermissionslistValueIndex = 1;
                        foreach(var publicRequestPermissionslistValue in publicRequest.Permissions.Parameters)
                        {
                            if(publicRequestPermissionslistValue.IsSetName())
                            {
                                request.Parameters.Add("Permissions" + "." + "Parameters" + "." + "member" + "." + publicRequestPermissionslistValueIndex + "." + "Name", StringUtils.FromString(publicRequestPermissionslistValue.Name));
                            }
                            if(publicRequestPermissionslistValue.IsSetType())
                            {
                                request.Parameters.Add("Permissions" + "." + "Parameters" + "." + "member" + "." + publicRequestPermissionslistValueIndex + "." + "Type", StringUtils.FromString(publicRequestPermissionslistValue.Type));
                            }
                            if(publicRequestPermissionslistValue.IsSetValues())
                            {
                                int publicRequestPermissionslistValuelistValueIndex = 1;
                                foreach(var publicRequestPermissionslistValuelistValue in publicRequestPermissionslistValue.Values)
                                {
                                    request.Parameters.Add("Permissions" + "." + "Parameters" + "." + "member" + "." + publicRequestPermissionslistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestPermissionslistValuelistValueIndex, StringUtils.FromString(publicRequestPermissionslistValuelistValue));
                                    publicRequestPermissionslistValuelistValueIndex++;
                                }
                            }
                            publicRequestPermissionslistValueIndex++;
                        }
                    }
                    if(publicRequest.Permissions.IsSetPolicyTemplateArn())
                    {
                        request.Parameters.Add("Permissions" + "." + "PolicyTemplateArn", StringUtils.FromString(publicRequest.Permissions.PolicyTemplateArn));
                    }
                }
                if(publicRequest.IsSetRedirectUrl())
                {
                    request.Parameters.Add("RedirectUrl", StringUtils.FromString(publicRequest.RedirectUrl));
                }
                if(publicRequest.IsSetRequestMessage())
                {
                    request.Parameters.Add("RequestMessage", StringUtils.FromString(publicRequest.RequestMessage));
                }
                if(publicRequest.IsSetRequestorWorkflowId())
                {
                    request.Parameters.Add("RequestorWorkflowId", StringUtils.FromString(publicRequest.RequestorWorkflowId));
                }
                if(publicRequest.IsSetSessionDuration())
                {
                    request.Parameters.Add("SessionDuration", StringUtils.FromInt(publicRequest.SessionDuration));
                }
            }
            return request;
        }
                    private static CreateDelegationRequestRequestMarshaller _instance = new CreateDelegationRequestRequestMarshaller();        

        internal static CreateDelegationRequestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDelegationRequestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}