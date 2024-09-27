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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEnvironmentHealth Request Marshaller
    /// </summary>       
    public class DescribeEnvironmentHealthRequestMarshaller : IMarshaller<IRequest, DescribeEnvironmentHealthRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEnvironmentHealthRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeEnvironmentHealthRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeEnvironmentHealth");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttributeNames())
                {
                    if (publicRequest.AttributeNames.Count == 0)
                        request.Parameters.Add("AttributeNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AttributeNames)
                         {
                             request.Parameters.Add("AttributeNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEnvironmentId())
                {
                    request.Parameters.Add("EnvironmentId", StringUtils.FromString(publicRequest.EnvironmentId));
                }
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
            }
            return request;
        }
                    private static DescribeEnvironmentHealthRequestMarshaller _instance = new DescribeEnvironmentHealthRequestMarshaller();        

        internal static DescribeEnvironmentHealthRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeEnvironmentHealthRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}