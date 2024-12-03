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
    /// AssumeRoot Request Marshaller
    /// </summary>       
    public class AssumeRootRequestMarshaller : IMarshaller<IRequest, AssumeRootRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssumeRootRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssumeRootRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityToken");
            request.Parameters.Add("Action", "AssumeRoot");
            request.Parameters.Add("Version", "2011-06-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDurationSeconds())
                {
                    request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds));
                }
                if(publicRequest.IsSetTargetPrincipal())
                {
                    request.Parameters.Add("TargetPrincipal", StringUtils.FromString(publicRequest.TargetPrincipal));
                }
                if(publicRequest.IsSetTaskPolicyArn())
                {
                    if(publicRequest.TaskPolicyArn.IsSetArn())
                    {
                        request.Parameters.Add("TaskPolicyArn" + "." + "arn", StringUtils.FromString(publicRequest.TaskPolicyArn.Arn));
                    }
                }
            }
            return request;
        }
                    private static AssumeRootRequestMarshaller _instance = new AssumeRootRequestMarshaller();        

        internal static AssumeRootRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssumeRootRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}