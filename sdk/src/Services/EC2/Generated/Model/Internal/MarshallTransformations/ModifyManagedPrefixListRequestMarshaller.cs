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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyManagedPrefixList Request Marshaller
    /// </summary>       
    public class ModifyManagedPrefixListRequestMarshaller : IMarshaller<IRequest, ModifyManagedPrefixListRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyManagedPrefixListRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyManagedPrefixListRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyManagedPrefixList");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddEntries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AddEntries)
                    {
                        if(publicRequestlistValue.IsSetCidr())
                        {
                            request.Parameters.Add("AddEntry" + "." + publicRequestlistValueIndex + "." + "Cidr", StringUtils.FromString(publicRequestlistValue.Cidr));
                        }
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("AddEntry" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetCurrentVersion())
                {
                    request.Parameters.Add("CurrentVersion", StringUtils.FromLong(publicRequest.CurrentVersion));
                }
                if(publicRequest.IsSetPrefixListId())
                {
                    request.Parameters.Add("PrefixListId", StringUtils.FromString(publicRequest.PrefixListId));
                }
                if(publicRequest.IsSetPrefixListName())
                {
                    request.Parameters.Add("PrefixListName", StringUtils.FromString(publicRequest.PrefixListName));
                }
                if(publicRequest.IsSetRemoveEntries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.RemoveEntries)
                    {
                        if(publicRequestlistValue.IsSetCidr())
                        {
                            request.Parameters.Add("RemoveEntry" + "." + publicRequestlistValueIndex + "." + "Cidr", StringUtils.FromString(publicRequestlistValue.Cidr));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static ModifyManagedPrefixListRequestMarshaller _instance = new ModifyManagedPrefixListRequestMarshaller();        

        internal static ModifyManagedPrefixListRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyManagedPrefixListRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}