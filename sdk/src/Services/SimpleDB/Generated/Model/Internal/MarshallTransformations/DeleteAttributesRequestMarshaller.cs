/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAttributes Request Marshaller
    /// </summary>       
    public class DeleteAttributesRequestMarshaller : IMarshaller<IRequest, DeleteAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAttributesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleDB");
            request.Parameters.Add("Action", "DeleteAttributes");
            request.Parameters.Add("Version", "2009-04-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttributes())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Attributes)
                    {
                        if(publicRequestlistValue.IsSetAlternateNameEncoding())
                        {
                            request.Parameters.Add("Attribute" + "." + publicRequestlistValueIndex + "." + "AlternateNameEncoding", StringUtils.FromString(publicRequestlistValue.AlternateNameEncoding));
                        }
                        if(publicRequestlistValue.IsSetAlternateValueEncoding())
                        {
                            request.Parameters.Add("Attribute" + "." + publicRequestlistValueIndex + "." + "AlternateValueEncoding", StringUtils.FromString(publicRequestlistValue.AlternateValueEncoding));
                        }
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("Attribute" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Attribute" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetDomainName())
                {
                    request.Parameters.Add("DomainName", StringUtils.FromString(publicRequest.DomainName));
                }
                if(publicRequest.IsSetExpected())
                {
                    if(publicRequest.Expected.IsSetExists())
                    {
                        request.Parameters.Add("Expected" + "." + "Exists", StringUtils.FromBool(publicRequest.Expected.Exists));
                    }
                    if(publicRequest.Expected.IsSetName())
                    {
                        request.Parameters.Add("Expected" + "." + "Name", StringUtils.FromString(publicRequest.Expected.Name));
                    }
                    if(publicRequest.Expected.IsSetValue())
                    {
                        request.Parameters.Add("Expected" + "." + "Value", StringUtils.FromString(publicRequest.Expected.Value));
                    }
                }
                if(publicRequest.IsSetItemName())
                {
                    request.Parameters.Add("ItemName", StringUtils.FromString(publicRequest.ItemName));
                }
            }
            return request;
        }
                    private static DeleteAttributesRequestMarshaller _instance = new DeleteAttributesRequestMarshaller();        

        internal static DeleteAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}