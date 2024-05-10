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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCidrLocations Request Marshaller
    /// </summary>       
    public class ListCidrLocationsRequestMarshaller : IMarshaller<IRequest, ListCidrLocationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCidrLocationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCidrLocationsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            if (!publicRequest.IsSetCollectionId())
                throw new AmazonRoute53Exception("Request object does not have required field CollectionId set");
            request.AddPathResource("{CidrCollectionId}", StringUtils.FromString(publicRequest.CollectionId));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nexttoken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxresults", StringUtils.FromString(publicRequest.MaxResults));
            request.ResourcePath = "/2013-04-01/cidrcollection/{CidrCollectionId}";


            request.UseQueryString = true;
            return request;
        }
        private static ListCidrLocationsRequestMarshaller _instance = new ListCidrLocationsRequestMarshaller();        

        internal static ListCidrLocationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCidrLocationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}