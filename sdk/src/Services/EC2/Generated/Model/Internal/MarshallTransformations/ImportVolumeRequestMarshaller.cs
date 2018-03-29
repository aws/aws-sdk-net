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
    /// ImportVolume Request Marshaller
    /// </summary>       
    public class ImportVolumeRequestMarshaller : IMarshaller<IRequest, ImportVolumeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportVolumeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportVolumeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ImportVolume");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetImage())
                {
                    if(publicRequest.Image.IsSetBytes())
                    {
                        request.Parameters.Add("Image" + "." + "Bytes", StringUtils.FromLong(publicRequest.Image.Bytes));
                    }
                    if(publicRequest.Image.IsSetFormat())
                    {
                        request.Parameters.Add("Image" + "." + "Format", StringUtils.FromString(publicRequest.Image.Format));
                    }
                    if(publicRequest.Image.IsSetImportManifestUrl())
                    {
                        request.Parameters.Add("Image" + "." + "ImportManifestUrl", StringUtils.FromString(publicRequest.Image.ImportManifestUrl));
                    }
                }
                if(publicRequest.IsSetVolume())
                {
                    if(publicRequest.Volume.IsSetSize())
                    {
                        request.Parameters.Add("Volume" + "." + "Size", StringUtils.FromLong(publicRequest.Volume.Size));
                    }
                }
            }
            return request;
        }
                    private static ImportVolumeRequestMarshaller _instance = new ImportVolumeRequestMarshaller();        

        internal static ImportVolumeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportVolumeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}