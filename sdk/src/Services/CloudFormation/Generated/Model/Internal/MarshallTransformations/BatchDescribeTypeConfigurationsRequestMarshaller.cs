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
    /// BatchDescribeTypeConfigurations Request Marshaller
    /// </summary>       
    public class BatchDescribeTypeConfigurationsRequestMarshaller : IMarshaller<IRequest, BatchDescribeTypeConfigurationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDescribeTypeConfigurationsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDescribeTypeConfigurationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "BatchDescribeTypeConfigurations");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetTypeConfigurationIdentifiers())
                {
                    if (publicRequest.TypeConfigurationIdentifiers.Count == 0)
                        request.Parameters.Add("TypeConfigurationIdentifiers", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TypeConfigurationIdentifiers)
                         {
                            if(publicRequestlistValue.IsSetType())
                            {
                                request.Parameters.Add("TypeConfigurationIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Type", StringUtils.FromString(publicRequestlistValue.Type));
                            }
                            if(publicRequestlistValue.IsSetTypeArn())
                            {
                                request.Parameters.Add("TypeConfigurationIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TypeArn", StringUtils.FromString(publicRequestlistValue.TypeArn));
                            }
                            if(publicRequestlistValue.IsSetTypeConfigurationAlias())
                            {
                                request.Parameters.Add("TypeConfigurationIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TypeConfigurationAlias", StringUtils.FromString(publicRequestlistValue.TypeConfigurationAlias));
                            }
                            if(publicRequestlistValue.IsSetTypeConfigurationArn())
                            {
                                request.Parameters.Add("TypeConfigurationIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TypeConfigurationArn", StringUtils.FromString(publicRequestlistValue.TypeConfigurationArn));
                            }
                            if(publicRequestlistValue.IsSetTypeName())
                            {
                                request.Parameters.Add("TypeConfigurationIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex + "." + "TypeName", StringUtils.FromString(publicRequestlistValue.TypeName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static BatchDescribeTypeConfigurationsRequestMarshaller _instance = new BatchDescribeTypeConfigurationsRequestMarshaller();        

        internal static BatchDescribeTypeConfigurationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDescribeTypeConfigurationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}