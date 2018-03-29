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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ImportExport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ImportExport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetShippingLabel Request Marshaller
    /// </summary>       
    public class GetShippingLabelRequestMarshaller : IMarshaller<IRequest, GetShippingLabelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetShippingLabelRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetShippingLabelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ImportExport");
            request.Parameters.Add("Action", "GetShippingLabel");
            request.Parameters.Add("Version", "2010-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAPIVersion())
                {
                    request.Parameters.Add("APIVersion", StringUtils.FromString(publicRequest.APIVersion));
                }
                if(publicRequest.IsSetCity())
                {
                    request.Parameters.Add("city", StringUtils.FromString(publicRequest.City));
                }
                if(publicRequest.IsSetCompany())
                {
                    request.Parameters.Add("company", StringUtils.FromString(publicRequest.Company));
                }
                if(publicRequest.IsSetCountry())
                {
                    request.Parameters.Add("country", StringUtils.FromString(publicRequest.Country));
                }
                if(publicRequest.IsSetJobIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.JobIds)
                    {
                        request.Parameters.Add("jobIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetPhoneNumber())
                {
                    request.Parameters.Add("phoneNumber", StringUtils.FromString(publicRequest.PhoneNumber));
                }
                if(publicRequest.IsSetPostalCode())
                {
                    request.Parameters.Add("postalCode", StringUtils.FromString(publicRequest.PostalCode));
                }
                if(publicRequest.IsSetStateOrProvince())
                {
                    request.Parameters.Add("stateOrProvince", StringUtils.FromString(publicRequest.StateOrProvince));
                }
                if(publicRequest.IsSetStreet1())
                {
                    request.Parameters.Add("street1", StringUtils.FromString(publicRequest.Street1));
                }
                if(publicRequest.IsSetStreet2())
                {
                    request.Parameters.Add("street2", StringUtils.FromString(publicRequest.Street2));
                }
                if(publicRequest.IsSetStreet3())
                {
                    request.Parameters.Add("street3", StringUtils.FromString(publicRequest.Street3));
                }
            }
            return request;
        }
                    private static GetShippingLabelRequestMarshaller _instance = new GetShippingLabelRequestMarshaller();        

        internal static GetShippingLabelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetShippingLabelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}