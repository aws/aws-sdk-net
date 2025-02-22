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
    /// CreateSnapshots Request Marshaller
    /// </summary>       
    public class CreateSnapshotsRequestMarshaller : IMarshaller<IRequest, CreateSnapshotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSnapshotsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateSnapshots");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCopyTagsFromSource())
                {
                    request.Parameters.Add("CopyTagsFromSource", StringUtils.FromString(publicRequest.CopyTagsFromSource));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceSpecification())
                {
                    if(publicRequest.InstanceSpecification.IsSetExcludeBootVolume())
                    {
                        request.Parameters.Add("InstanceSpecification" + "." + "ExcludeBootVolume", StringUtils.FromBool(publicRequest.InstanceSpecification.ExcludeBootVolume));
                    }
                    if(publicRequest.InstanceSpecification.IsSetExcludeDataVolumeIds())
                    {
                        if (publicRequest.InstanceSpecification.ExcludeDataVolumeIds.Count == 0)
                            request.Parameters.Add("InstanceSpecification" + "." + "ExcludeDataVolumeId", "");
                        else
                        {
                             int publicRequestInstanceSpecificationlistValueIndex = 1;
                             foreach(var publicRequestInstanceSpecificationlistValue in publicRequest.InstanceSpecification.ExcludeDataVolumeIds)
                             {
                                 request.Parameters.Add("InstanceSpecification" + "." + "ExcludeDataVolumeId" + "." + publicRequestInstanceSpecificationlistValueIndex, StringUtils.FromString(publicRequestInstanceSpecificationlistValue));
                                 publicRequestInstanceSpecificationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceSpecification.IsSetInstanceId())
                    {
                        request.Parameters.Add("InstanceSpecification" + "." + "InstanceId", StringUtils.FromString(publicRequest.InstanceSpecification.InstanceId));
                    }
                }
                if(publicRequest.IsSetLocation())
                {
                    request.Parameters.Add("Location", StringUtils.FromString(publicRequest.Location));
                }
                if(publicRequest.IsSetOutpostArn())
                {
                    request.Parameters.Add("OutpostArn", StringUtils.FromString(publicRequest.OutpostArn));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
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
                    private static CreateSnapshotsRequestMarshaller _instance = new CreateSnapshotsRequestMarshaller();        

        internal static CreateSnapshotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSnapshotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}