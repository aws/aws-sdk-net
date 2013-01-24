/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Returns information about the  CreateCachediSCSIVolumeResult response and response metadata.
    /// </summary>
    public class CreateCachediSCSIVolumeResponse : AmazonWebServiceResponse
    {
        private CreateCachediSCSIVolumeResult createCachediSCSIVolumeResult;

        /// <summary>
        /// Gets and sets the CreateCachediSCSIVolumeResult property.
        /// A JSON object containing the following fields: CreateCachediSCSIVolume$TargetARN CreateCachediSCSIVolume$VolumeARN
        /// </summary>
        public CreateCachediSCSIVolumeResult CreateCachediSCSIVolumeResult
        {
            get 
            {
                if(this.createCachediSCSIVolumeResult == null)
                {
                    this.createCachediSCSIVolumeResult = new CreateCachediSCSIVolumeResult();
                }

                return this.createCachediSCSIVolumeResult; 
            }
            set { this.createCachediSCSIVolumeResult = value; }
        }
    }
}
    
