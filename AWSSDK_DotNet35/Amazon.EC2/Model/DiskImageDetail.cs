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

namespace Amazon.EC2.Model
{
    /// <summary>Disk Image Detail
    /// </summary>
    public class DiskImageDetail
    {
        
        private DiskImageFormat format;
        private long? bytes;
        private string importManifestUrl;

        public DiskImageFormat Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.format != null;
        }
        public long Bytes
        {
            get { return this.bytes ?? default(long); }
            set { this.bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this.bytes.HasValue;
        }
        public string ImportManifestUrl
        {
            get { return this.importManifestUrl; }
            set { this.importManifestUrl = value; }
        }

        // Check to see if ImportManifestUrl property is set
        internal bool IsSetImportManifestUrl()
        {
            return this.importManifestUrl != null;
        }
    }
}
