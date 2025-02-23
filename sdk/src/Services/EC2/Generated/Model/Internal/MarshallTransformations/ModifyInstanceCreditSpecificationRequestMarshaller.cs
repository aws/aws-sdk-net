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
    /// ModifyInstanceCreditSpecification Request Marshaller
    /// </summary>       
    public class ModifyInstanceCreditSpecificationRequestMarshaller : IMarshaller<IRequest, ModifyInstanceCreditSpecificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceCreditSpecificationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyInstanceCreditSpecificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyInstanceCreditSpecification");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceCreditSpecifications())
                {
                    if (publicRequest.InstanceCreditSpecifications.Count == 0)
                        request.Parameters.Add("InstanceCreditSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.InstanceCreditSpecifications)
                         {
                            if(publicRequestlistValue.IsSetCpuCredits())
                            {
                                request.Parameters.Add("InstanceCreditSpecification" + "." + publicRequestlistValueIndex + "." + "CpuCredits", StringUtils.FromString(publicRequestlistValue.CpuCredits));
                            }
                            if(publicRequestlistValue.IsSetInstanceId())
                            {
                                request.Parameters.Add("InstanceCreditSpecification" + "." + publicRequestlistValueIndex + "." + "InstanceId", StringUtils.FromString(publicRequestlistValue.InstanceId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyInstanceCreditSpecificationRequestMarshaller _instance = new ModifyInstanceCreditSpecificationRequestMarshaller();        

        internal static ModifyInstanceCreditSpecificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyInstanceCreditSpecificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}