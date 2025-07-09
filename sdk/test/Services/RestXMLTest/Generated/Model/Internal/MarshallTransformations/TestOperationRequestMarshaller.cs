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
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXMLTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXMLTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestOperation Request Marshaller
    /// </summary>       
    public partial class TestOperationRequestMarshaller : IMarshaller<IRequest, TestOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestOperationRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXMLTest");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetContentLanguage()) 
            {
                        request.Headers["x-amz-content-language"] = StringUtils.FromList(publicRequest.ContentLanguage);
            }
        
            if (publicRequest.IsSetContentLanguageEnums()) 
            {
                        request.Headers["x-amz-content-language-as-enums"] = StringUtils.FromList(publicRequest.ContentLanguageEnums);
            }
            request.ResourcePath = "/";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static TestOperationRequestMarshaller _instance = new TestOperationRequestMarshaller();        

        internal static TestOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, TestOperationRequest publicRequest);
    }    
}