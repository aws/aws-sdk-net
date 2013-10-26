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
    /// Container for the parameters to the ImportInstance operation.
    /// 
    /// </summary>
    public partial class ImportInstanceRequest : AmazonEC2Request
    {
        private string description;
        private ImportInstanceLaunchSpecification launchSpecification;
        private List<DiskImage> diskImages = new List<DiskImage>();
        private PlatformValues platform;

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
        public ImportInstanceLaunchSpecification LaunchSpecification
        {
            get { return this.launchSpecification; }
            set { this.launchSpecification = value; }
        }

        // Check to see if LaunchSpecification property is set
        internal bool IsSetLaunchSpecification()
        {
            return this.launchSpecification != null;
        }
        public List<DiskImage> DiskImages
        {
            get { return this.diskImages; }
            set { this.diskImages = value; }
        }

        // Check to see if DiskImages property is set
        internal bool IsSetDiskImages()
        {
            return this.diskImages.Count > 0;
        }
        public PlatformValues Platform
        {
            get { return this.platform; }
            set { this.platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this.platform != null;
        }

    }
}
    
