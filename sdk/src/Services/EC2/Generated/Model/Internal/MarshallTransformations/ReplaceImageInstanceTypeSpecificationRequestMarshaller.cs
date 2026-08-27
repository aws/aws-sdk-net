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
    /// ReplaceImageInstanceTypeSpecification Request Marshaller
    /// </summary>       
    public class ReplaceImageInstanceTypeSpecificationRequestMarshaller : IMarshaller<IRequest, ReplaceImageInstanceTypeSpecificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplaceImageInstanceTypeSpecificationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReplaceImageInstanceTypeSpecificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ReplaceImageInstanceTypeSpecification");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetInstanceTypeSpecification())
                {
                    if(publicRequest.InstanceTypeSpecification.IsSetSupportedInstanceTypes())
                    {
                        if (publicRequest.InstanceTypeSpecification.SupportedInstanceTypes.Count == 0)
                            request.Parameters.Add("InstanceTypeSpecification" + "." + "SupportedInstanceType", "");
                        else
                        {
                             int publicRequestInstanceTypeSpecificationlistValueIndex = 1;
                             foreach(var publicRequestInstanceTypeSpecificationlistValue in publicRequest.InstanceTypeSpecification.SupportedInstanceTypes)
                             {
                                 request.Parameters.Add("InstanceTypeSpecification" + "." + "SupportedInstanceType" + "." + publicRequestInstanceTypeSpecificationlistValueIndex, StringUtils.FromString(publicRequestInstanceTypeSpecificationlistValue));
                                 publicRequestInstanceTypeSpecificationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceTypeSpecification.IsSetUnsupportedInstanceTypes())
                    {
                        if (publicRequest.InstanceTypeSpecification.UnsupportedInstanceTypes.Count == 0)
                            request.Parameters.Add("InstanceTypeSpecification" + "." + "UnsupportedInstanceType", "");
                        else
                        {
                             int publicRequestInstanceTypeSpecificationlistValueIndex = 1;
                             foreach(var publicRequestInstanceTypeSpecificationlistValue in publicRequest.InstanceTypeSpecification.UnsupportedInstanceTypes)
                             {
                                 request.Parameters.Add("InstanceTypeSpecification" + "." + "UnsupportedInstanceType" + "." + publicRequestInstanceTypeSpecificationlistValueIndex, StringUtils.FromString(publicRequestInstanceTypeSpecificationlistValue));
                                 publicRequestInstanceTypeSpecificationlistValueIndex++;
                             }
                        }
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static ReplaceImageInstanceTypeSpecificationRequestMarshaller _instance = new ReplaceImageInstanceTypeSpecificationRequestMarshaller();        

        internal static ReplaceImageInstanceTypeSpecificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplaceImageInstanceTypeSpecificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}