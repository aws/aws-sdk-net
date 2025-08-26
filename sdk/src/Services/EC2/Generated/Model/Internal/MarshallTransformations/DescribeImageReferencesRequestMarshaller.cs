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
    /// DescribeImageReferences Request Marshaller
    /// </summary>       
    public class DescribeImageReferencesRequestMarshaller : IMarshaller<IRequest, DescribeImageReferencesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeImageReferencesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeImageReferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "DescribeImageReferences");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetImageIds())
                {
                    if (publicRequest.ImageIds.Count == 0)
                        request.Parameters.Add("ImageId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ImageIds)
                         {
                             request.Parameters.Add("ImageId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetIncludeAllResourceTypes())
                {
                    request.Parameters.Add("IncludeAllResourceTypes", StringUtils.FromBool(publicRequest.IncludeAllResourceTypes));
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetResourceTypes())
                {
                    if (publicRequest.ResourceTypes.Count == 0)
                        request.Parameters.Add("ResourceType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ResourceTypes)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("ResourceType" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetResourceTypeOptions())
                            {
                                if (publicRequestlistValue.ResourceTypeOptions.Count == 0)
                                    request.Parameters.Add("ResourceType" + "." + publicRequestlistValueIndex + "." + "ResourceTypeOption", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ResourceTypeOptions)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetOptionName())
                                        {
                                            request.Parameters.Add("ResourceType" + "." + publicRequestlistValueIndex + "." + "ResourceTypeOption" + "." + publicRequestlistValuelistValueIndex + "." + "OptionName", StringUtils.FromString(publicRequestlistValuelistValue.OptionName));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetOptionValues())
                                        {
                                            if (publicRequestlistValuelistValue.OptionValues.Count == 0)
                                                request.Parameters.Add("ResourceType" + "." + publicRequestlistValueIndex + "." + "ResourceTypeOption" + "." + publicRequestlistValuelistValueIndex + "." + "OptionValue", "");
                                            else
                                            {
                                                 int publicRequestlistValuelistValuelistValueIndex = 1;
                                                 foreach(var publicRequestlistValuelistValuelistValue in publicRequestlistValuelistValue.OptionValues)
                                                 {
                                                     request.Parameters.Add("ResourceType" + "." + publicRequestlistValueIndex + "." + "ResourceTypeOption" + "." + publicRequestlistValuelistValueIndex + "." + "OptionValue" + "." + publicRequestlistValuelistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValuelistValue));
                                                     publicRequestlistValuelistValuelistValueIndex++;
                                                 }
                                            }
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static DescribeImageReferencesRequestMarshaller _instance = new DescribeImageReferencesRequestMarshaller();        

        internal static DescribeImageReferencesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeImageReferencesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}