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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeregisterNamespace Request Marshaller
    /// </summary>       
    public class DeregisterNamespaceRequestMarshaller : IMarshaller<IRequest, DeregisterNamespaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeregisterNamespaceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeregisterNamespaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "DeregisterNamespace");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConsumerIdentifiers())
                {
                    if (publicRequest.ConsumerIdentifiers.Count == 0)
                        request.Parameters.Add("ConsumerIdentifiers", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ConsumerIdentifiers)
                         {
                             request.Parameters.Add("ConsumerIdentifiers" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNamespaceIdentifier())
                {
                    if(publicRequest.NamespaceIdentifier.IsSetProvisionedIdentifier())
                    {
                        if(publicRequest.NamespaceIdentifier.ProvisionedIdentifier.IsSetClusterIdentifier())
                        {
                            request.Parameters.Add("NamespaceIdentifier" + "." + "ProvisionedIdentifier" + "." + "ClusterIdentifier", StringUtils.FromString(publicRequest.NamespaceIdentifier.ProvisionedIdentifier.ClusterIdentifier));
                        }
                    }
                    if(publicRequest.NamespaceIdentifier.IsSetServerlessIdentifier())
                    {
                        if(publicRequest.NamespaceIdentifier.ServerlessIdentifier.IsSetNamespaceIdentifier())
                        {
                            request.Parameters.Add("NamespaceIdentifier" + "." + "ServerlessIdentifier" + "." + "NamespaceIdentifier", StringUtils.FromString(publicRequest.NamespaceIdentifier.ServerlessIdentifier.NamespaceIdentifier));
                        }
                        if(publicRequest.NamespaceIdentifier.ServerlessIdentifier.IsSetWorkgroupIdentifier())
                        {
                            request.Parameters.Add("NamespaceIdentifier" + "." + "ServerlessIdentifier" + "." + "WorkgroupIdentifier", StringUtils.FromString(publicRequest.NamespaceIdentifier.ServerlessIdentifier.WorkgroupIdentifier));
                        }
                    }
                }
            }
            return request;
        }
                    private static DeregisterNamespaceRequestMarshaller _instance = new DeregisterNamespaceRequestMarshaller();        

        internal static DeregisterNamespaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeregisterNamespaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}