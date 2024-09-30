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
    /// ListResourceScanRelatedResources Request Marshaller
    /// </summary>       
    public class ListResourceScanRelatedResourcesRequestMarshaller : IMarshaller<IRequest, ListResourceScanRelatedResourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListResourceScanRelatedResourcesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListResourceScanRelatedResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ListResourceScanRelatedResources");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetResources())
                {
                    if (publicRequest.Resources.Count == 0)
                        request.Parameters.Add("Resources", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Resources)
                         {
                            if(publicRequestlistValue.IsSetResourceIdentifier())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.ResourceIdentifier.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.ResourceIdentifier.TryGetValue(key, out value);
                                    request.Parameters.Add("Resources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("Resources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("Resources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetResourceScanId())
                {
                    request.Parameters.Add("ResourceScanId", StringUtils.FromString(publicRequest.ResourceScanId));
                }
            }
            return request;
        }
                    private static ListResourceScanRelatedResourcesRequestMarshaller _instance = new ListResourceScanRelatedResourcesRequestMarshaller();        

        internal static ListResourceScanRelatedResourcesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListResourceScanRelatedResourcesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}