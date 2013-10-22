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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para> <para>For information about the underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html" >Upload Archive</a> .
    /// For conceptual information, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html" >Working
    /// with Archives in Amazon Glacier</a> .</para>
    /// </summary>
    public partial class CompleteMultipartUploadResult : AmazonWebServiceResponse
    {
        
        private string location;
        private string checksum;
        private string archiveId;

        /// <summary>
        /// The relative URI path of the newly added archive resource.
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// The checksum of the archive computed by Amazon Glacier.
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

        /// <summary>
        /// The ID of the archive. This value is also included as part of the location.
        ///  
        /// </summary>
        public string ArchiveId
        {
            get { return this.archiveId; }
            set { this.archiveId = value; }
        }

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this.archiveId != null;
        }
    }
}
