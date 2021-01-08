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
    /// GetReservedInstancesExchangeQuote Request Marshaller
    /// </summary>       
    public class GetReservedInstancesExchangeQuoteRequestMarshaller : IMarshaller<IRequest, GetReservedInstancesExchangeQuoteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetReservedInstancesExchangeQuoteRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetReservedInstancesExchangeQuoteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetReservedInstancesExchangeQuote");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetReservedInstanceIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ReservedInstanceIds)
                    {
                        request.Parameters.Add("ReservedInstanceId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetConfigurations())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TargetConfigurations)
                    {
                        if(publicRequestlistValue.IsSetInstanceCount())
                        {
                            request.Parameters.Add("TargetConfiguration" + "." + publicRequestlistValueIndex + "." + "InstanceCount", StringUtils.FromInt(publicRequestlistValue.InstanceCount));
                        }
                        if(publicRequestlistValue.IsSetOfferingId())
                        {
                            request.Parameters.Add("TargetConfiguration" + "." + publicRequestlistValueIndex + "." + "OfferingId", StringUtils.FromString(publicRequestlistValue.OfferingId));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static GetReservedInstancesExchangeQuoteRequestMarshaller _instance = new GetReservedInstancesExchangeQuoteRequestMarshaller();        

        internal static GetReservedInstancesExchangeQuoteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReservedInstancesExchangeQuoteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}