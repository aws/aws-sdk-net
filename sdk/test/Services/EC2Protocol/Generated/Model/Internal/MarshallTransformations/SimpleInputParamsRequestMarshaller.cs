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
 * Do not modify this file. This file is generated from the ec2-protocol-2020-01-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimpleInputParams Request Marshaller
    /// </summary>       
    public class SimpleInputParamsRequestMarshaller : IMarshaller<IRequest, SimpleInputParamsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleInputParamsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SimpleInputParamsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2Protocol");
            request.Parameters.Add("Action", "SimpleInputParams");
            request.Parameters.Add("Version", "2020-01-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBam())
                {
                    request.Parameters.Add("Bam", StringUtils.FromInt(publicRequest.Bam));
                }
                if(publicRequest.IsSetBar())
                {
                    request.Parameters.Add("Bar", StringUtils.FromString(publicRequest.Bar));
                }
                if(publicRequest.IsSetBaz())
                {
                    request.Parameters.Add("Baz", StringUtils.FromBool(publicRequest.Baz));
                }
                if(publicRequest.IsSetBoo())
                {
                    request.Parameters.Add("Boo", StringUtils.FromDouble(publicRequest.Boo));
                }
                if(publicRequest.IsSetFloatValue())
                {
                    request.Parameters.Add("FloatValue", StringUtils.FromFloat(publicRequest.FloatValue));
                }
                if(publicRequest.IsSetFoo())
                {
                    request.Parameters.Add("Foo", StringUtils.FromString(publicRequest.Foo));
                }
                if(publicRequest.IsSetFooEnum())
                {
                    request.Parameters.Add("FooEnum", StringUtils.FromString(publicRequest.FooEnum));
                }
                if(publicRequest.IsSetHasQueryAndXmlName())
                {
                    request.Parameters.Add("HasQueryAndXmlName", StringUtils.FromString(publicRequest.HasQueryAndXmlName));
                }
                if(publicRequest.IsSetHasQueryName())
                {
                    request.Parameters.Add("HasQueryName", StringUtils.FromString(publicRequest.HasQueryName));
                }
                if(publicRequest.IsSetQux())
                {
                    request.Parameters.Add("Qux", StringUtils.FromMemoryStream(publicRequest.Qux));
                }
                if(publicRequest.IsSetUsesXmlName())
                {
                    request.Parameters.Add("UsesXmlName", StringUtils.FromString(publicRequest.UsesXmlName));
                }
            }
            return request;
        }
                    private static SimpleInputParamsRequestMarshaller _instance = new SimpleInputParamsRequestMarshaller();        

        internal static SimpleInputParamsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleInputParamsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}