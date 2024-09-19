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
    /// QueryLists Request Marshaller
    /// </summary>       
    public class QueryListsRequestMarshaller : IMarshaller<IRequest, QueryListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryListsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2Protocol");
            request.Parameters.Add("Action", "QueryLists");
            request.Parameters.Add("Version", "2020-01-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetComplexListArg())
                {
                    if (publicRequest.ComplexListArg.Count == 0)
                        request.Parameters.Add("ComplexListArg", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ComplexListArg)
                         {
                            if(publicRequestlistValue.IsSetHi())
                            {
                                request.Parameters.Add("ComplexListArg" + "." + publicRequestlistValueIndex + "." + "Hi", StringUtils.FromString(publicRequestlistValue.Hi));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetListArg())
                {
                    if (publicRequest.ListArg.Count == 0)
                        request.Parameters.Add("ListArg", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ListArg)
                         {
                             request.Parameters.Add("ListArg" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetListArgWithXmlName())
                {
                    if (publicRequest.ListArgWithXmlName.Count == 0)
                        request.Parameters.Add("Hi", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ListArgWithXmlName)
                         {
                             request.Parameters.Add("Hi" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetListArgWithXmlNameMember())
                {
                    if (publicRequest.ListArgWithXmlNameMember.Count == 0)
                        request.Parameters.Add("ListArgWithXmlNameMember", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ListArgWithXmlNameMember)
                         {
                             request.Parameters.Add("ListArgWithXmlNameMember" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNestedWithList())
                {
                    if(publicRequest.NestedWithList.IsSetListArg())
                    {
                        if (publicRequest.NestedWithList.ListArg.Count == 0)
                            request.Parameters.Add("NestedWithList" + "." + "ListArg", "");
                        else
                        {
                             int publicRequestNestedWithListlistValueIndex = 1;
                             foreach(var publicRequestNestedWithListlistValue in publicRequest.NestedWithList.ListArg)
                             {
                                 request.Parameters.Add("NestedWithList" + "." + "ListArg" + "." + publicRequestNestedWithListlistValueIndex, StringUtils.FromString(publicRequestNestedWithListlistValue));
                                 publicRequestNestedWithListlistValueIndex++;
                             }
                        }
                    }
                }
            }
            return request;
        }
                    private static QueryListsRequestMarshaller _instance = new QueryListsRequestMarshaller();        

        internal static QueryListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}