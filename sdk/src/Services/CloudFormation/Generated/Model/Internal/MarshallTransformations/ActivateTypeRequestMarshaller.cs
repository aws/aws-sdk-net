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
    /// ActivateType Request Marshaller
    /// </summary>       
    public class ActivateTypeRequestMarshaller : IMarshaller<IRequest, ActivateTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ActivateTypeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ActivateTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ActivateType");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoUpdate())
                {
                    request.Parameters.Add("AutoUpdate", StringUtils.FromBool(publicRequest.AutoUpdate));
                }
                if(publicRequest.IsSetExecutionRoleArn())
                {
                    request.Parameters.Add("ExecutionRoleArn", StringUtils.FromString(publicRequest.ExecutionRoleArn));
                }
                if(publicRequest.IsSetLoggingConfig())
                {
                    if(publicRequest.LoggingConfig.IsSetLogGroupName())
                    {
                        request.Parameters.Add("LoggingConfig" + "." + "LogGroupName", StringUtils.FromString(publicRequest.LoggingConfig.LogGroupName));
                    }
                    if(publicRequest.LoggingConfig.IsSetLogRoleArn())
                    {
                        request.Parameters.Add("LoggingConfig" + "." + "LogRoleArn", StringUtils.FromString(publicRequest.LoggingConfig.LogRoleArn));
                    }
                }
                if(publicRequest.IsSetMajorVersion())
                {
                    request.Parameters.Add("MajorVersion", StringUtils.FromLong(publicRequest.MajorVersion));
                }
                if(publicRequest.IsSetPublicTypeArn())
                {
                    request.Parameters.Add("PublicTypeArn", StringUtils.FromString(publicRequest.PublicTypeArn));
                }
                if(publicRequest.IsSetPublisherId())
                {
                    request.Parameters.Add("PublisherId", StringUtils.FromString(publicRequest.PublisherId));
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
                if(publicRequest.IsSetTypeName())
                {
                    request.Parameters.Add("TypeName", StringUtils.FromString(publicRequest.TypeName));
                }
                if(publicRequest.IsSetTypeNameAlias())
                {
                    request.Parameters.Add("TypeNameAlias", StringUtils.FromString(publicRequest.TypeNameAlias));
                }
                if(publicRequest.IsSetVersionBump())
                {
                    request.Parameters.Add("VersionBump", StringUtils.FromString(publicRequest.VersionBump));
                }
            }
            return request;
        }
                    private static ActivateTypeRequestMarshaller _instance = new ActivateTypeRequestMarshaller();        

        internal static ActivateTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivateTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}