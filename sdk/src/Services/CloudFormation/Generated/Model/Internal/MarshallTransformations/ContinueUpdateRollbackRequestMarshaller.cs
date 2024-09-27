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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContinueUpdateRollback Request Marshaller
    /// </summary>       
    public class ContinueUpdateRollbackRequestMarshaller : IMarshaller<IRequest, ContinueUpdateRollbackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ContinueUpdateRollbackRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ContinueUpdateRollbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ContinueUpdateRollback");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientRequestToken())
                {
                    request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                if(publicRequest.IsSetResourcesToSkip())
                {
                    if (publicRequest.ResourcesToSkip.Count == 0)
                        request.Parameters.Add("ResourcesToSkip", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ResourcesToSkip)
                         {
                             request.Parameters.Add("ResourcesToSkip" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetRoleARN())
                {
                    request.Parameters.Add("RoleARN", StringUtils.FromString(publicRequest.RoleARN));
                }
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
            }
            return request;
        }
                    private static ContinueUpdateRollbackRequestMarshaller _instance = new ContinueUpdateRollbackRequestMarshaller();        

        internal static ContinueUpdateRollbackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContinueUpdateRollbackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}