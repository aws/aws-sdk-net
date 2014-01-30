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
    /// <summary>
    /// 
    /// </summary>
    public class DiskImageDescription
    {
        
        private DiskImageFormat format;
        private long? size;
        private string importManifestUrl;
        private string checksum;


        /// <summary>
        /// The disk image format.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>VMDK, RAW, VHD</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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

        /// <summary>
        /// The size of the disk image.
        ///  
        /// </summary>
        public long Size
        {
            get { return this.size ?? default(long); }
            set { this.size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }

        /// <summary>
        /// A presigned URL for the import manifest stored in Amazon S3. For information about creating a presigned URL for an Amazon S3 object, read
        /// the "Query String Request Authentication Alternative" section of the <a
        /// href="http://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">Authenticating REST Requests</a> topic in the <i>Amazon Simple
        /// Storage Service Developer Guide</i>.
        ///  
        /// </summary>
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

        /// <summary>
        /// The checksum computed for the disk image.
        ///  
        /// </summary>
        public string Checksum
        {
            get { return this.checksum; }
            set { this.checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this.checksum != null;
        }
    }
}
