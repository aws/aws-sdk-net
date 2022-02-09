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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAccessPointPolicyForObjectLambda Request Marshaller
    /// </summary>       
    public class DeleteAccessPointPolicyForObjectLambdaRequestMarshaller : IMarshaller<IRequest, DeleteAccessPointPolicyForObjectLambdaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAccessPointPolicyForObjectLambdaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAccessPointPolicyForObjectLambdaRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            request.HttpMethod = "DELETE";
        
            if (publicRequest.IsSetAccountId()) 
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }
            if (!publicRequest.IsSetName())
                throw new AmazonS3ControlException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v20180820/accesspointforobjectlambda/{name}/policy";



            var hostPrefixLabels = new
            {
                AccountId = StringUtils.FromString(publicRequest.AccountId),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.AccountId))
                throw new AmazonS3ControlException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");        
            
            request.HostPrefix = $"{hostPrefixLabels.AccountId}.";
            return request;
        }
        private static DeleteAccessPointPolicyForObjectLambdaRequestMarshaller _instance = new DeleteAccessPointPolicyForObjectLambdaRequestMarshaller();        

        internal static DeleteAccessPointPolicyForObjectLambdaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAccessPointPolicyForObjectLambdaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}