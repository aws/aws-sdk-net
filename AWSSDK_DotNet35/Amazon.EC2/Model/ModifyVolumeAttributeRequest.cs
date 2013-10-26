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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVolumeAttribute operation.
    /// 
    /// </summary>
    public partial class ModifyVolumeAttributeRequest : AmazonEC2Request
    {
        private string volumeId;
        private bool? autoEnableIO;

        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }
        public bool AutoEnableIO
        {
            get { return this.autoEnableIO ?? default(bool); }
            set { this.autoEnableIO = value; }
        }

        // Check to see if AutoEnableIO property is set
        internal bool IsSetAutoEnableIO()
        {
            return this.autoEnableIO.HasValue;
        }

    }
}
    
