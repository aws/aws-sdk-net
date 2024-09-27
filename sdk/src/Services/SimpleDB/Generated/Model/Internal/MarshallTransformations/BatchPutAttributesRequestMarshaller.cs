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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchPutAttributes Request Marshaller
    /// </summary>       
    public class BatchPutAttributesRequestMarshaller : IMarshaller<IRequest, BatchPutAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutAttributesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchPutAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDB");
            request.Parameters.Add("Action", "BatchPutAttributes");
            request.Parameters.Add("Version", "2009-04-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetItems())
                {
                    if (publicRequest.Items.Count == 0)
                        request.Parameters.Add("Item", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Items)
                         {
                            if(publicRequestlistValue.IsSetAttributes())
                            {
                                if (publicRequestlistValue.Attributes.Count == 0)
                                    request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Attributes)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetName())
                                        {
                                            request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetReplace())
                                        {
                                            request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "Replace", StringUtils.FromBool(publicRequestlistValuelistValue.Replace));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "Attribute" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Item" + "." + publicRequestlistValueIndex + "." + "ItemName", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static BatchPutAttributesRequestMarshaller _instance = new BatchPutAttributesRequestMarshaller();        

        internal static BatchPutAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchPutAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}