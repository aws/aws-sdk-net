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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReservedInstancesListing Request Marshaller
    /// </summary>       
    public class CreateReservedInstancesListingRequestMarshaller : IMarshaller<IRequest, CreateReservedInstancesListingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReservedInstancesListingRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReservedInstancesListingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateReservedInstancesListing");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetPriceSchedules())
                {
                    if (publicRequest.PriceSchedules.Count == 0)
                        request.Parameters.Add("PriceSchedules", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PriceSchedules)
                         {
                            if(publicRequestlistValue.IsSetCurrencyCode())
                            {
                                request.Parameters.Add("PriceSchedules" + "." + publicRequestlistValueIndex + "." + "CurrencyCode", StringUtils.FromString(publicRequestlistValue.CurrencyCode));
                            }
                            if(publicRequestlistValue.IsSetPrice())
                            {
                                request.Parameters.Add("PriceSchedules" + "." + publicRequestlistValueIndex + "." + "Price", StringUtils.FromDouble(publicRequestlistValue.Price));
                            }
                            if(publicRequestlistValue.IsSetTerm())
                            {
                                request.Parameters.Add("PriceSchedules" + "." + publicRequestlistValueIndex + "." + "Term", StringUtils.FromLong(publicRequestlistValue.Term));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetReservedInstancesId())
                {
                    request.Parameters.Add("ReservedInstancesId", StringUtils.FromString(publicRequest.ReservedInstancesId));
                }
            }
            return request;
        }
                    private static CreateReservedInstancesListingRequestMarshaller _instance = new CreateReservedInstancesListingRequestMarshaller();        

        internal static CreateReservedInstancesListingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReservedInstancesListingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}