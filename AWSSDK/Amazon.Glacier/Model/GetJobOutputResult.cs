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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public class GetJobOutputResult  
    {
        
        private Stream body;
        private string checksum;
        private int? status;
        private string contentRange;
        private string acceptRanges;
        private string contentType;
        private string archiveDescription;

        /// <summary>
        /// The job data, either archive data or inventory data.
        ///  
        /// </summary>
        public Stream Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        /// <summary>
        /// Sets the Body property
        /// </summary>
        /// <param name="body">The value to set for the Body property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithBody(Stream body)
        {
            this.body = body;
            return this;
        }
            

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;       
        }

        /// <summary>
        /// The checksum of the data in the response. This header is returned only when retrieving the output for an archive retrieval job. Furthermore,
        /// this header appears only under the following conditions: <ul> <li>You get the entire range of the archive.</li> <li>You request a range to
        /// return of the archive that starts and ends on a multiple of 1 MB. For example, if you have an 3.1 MB archive and you specify a range to
        /// return that starts at 1 MB and ends at 2 MB, then the x-amz-sha256-tree-hash is returned as a response header.</li> <li>You request a range
        /// of the archive to return that starts on a multiple of 1 MB and goes to the end of the archive. For example, if you have a 3.1 MB archive and
        /// you specify a range that starts at 2 MB and ends at 3.1 MB (the end of the archive), then the x-amz-sha256-tree-hash is returned as a
        /// response header.</li> </ul>
        ///  
        /// </summary>
        public string Checksum
        {
            get { return this.checksum; }
            set { this.checksum = value; }
        }

        /// <summary>
        /// Sets the Checksum property
        /// </summary>
        /// <param name="checksum">The value to set for the Checksum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithChecksum(string checksum)
        {
            this.checksum = checksum;
            return this;
        }
            

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this.checksum != null;       
        }

        /// <summary>
        /// The HTTP response code for a job output request. The value depends on whether a range was specified in the request.
        ///  
        /// </summary>
        public int Status
        {
            get { return this.status ?? default(int); }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithStatus(int status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status.HasValue;       
        }

        /// <summary>
        /// The range of bytes returned by Amazon Glacier. If only partial output is downloaded, the response provides the range of bytes Amazon Glacier
        /// returned. For example, bytes 0-1048575/8388608 returns the first 1 MB from 8 MB.
        ///  
        /// </summary>
        public string ContentRange
        {
            get { return this.contentRange; }
            set { this.contentRange = value; }
        }

        /// <summary>
        /// Sets the ContentRange property
        /// </summary>
        /// <param name="contentRange">The value to set for the ContentRange property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithContentRange(string contentRange)
        {
            this.contentRange = contentRange;
            return this;
        }
            

        // Check to see if ContentRange property is set
        internal bool IsSetContentRange()
        {
            return this.contentRange != null;       
        }

        /// <summary>
        /// Indicates the range units accepted. For more information, go to <a
        /// href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html">RFC2616</a>.
        ///  
        /// </summary>
        public string AcceptRanges
        {
            get { return this.acceptRanges; }
            set { this.acceptRanges = value; }
        }

        /// <summary>
        /// Sets the AcceptRanges property
        /// </summary>
        /// <param name="acceptRanges">The value to set for the AcceptRanges property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithAcceptRanges(string acceptRanges)
        {
            this.acceptRanges = acceptRanges;
            return this;
        }
            

        // Check to see if AcceptRanges property is set
        internal bool IsSetAcceptRanges()
        {
            return this.acceptRanges != null;       
        }

        /// <summary>
        /// The Content-Type depends on whether the job output is an archive or a vault inventory. For archive data, the Content-Type is
        /// application/octet-stream. For vault inventory, if you requested CSV format when you initiated the job, the Content-Type is text/csv.
        /// Otherwise, by default, vault inventory is returned as JSON, and the Content-Type is application/json.
        ///  
        /// </summary>
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Sets the ContentType property
        /// </summary>
        /// <param name="contentType">The value to set for the ContentType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithContentType(string contentType)
        {
            this.contentType = contentType;
            return this;
        }
            

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this.contentType != null;       
        }

        /// <summary>
        /// The description of an archive.
        ///  
        /// </summary>
        public string ArchiveDescription
        {
            get { return this.archiveDescription; }
            set { this.archiveDescription = value; }
        }

        /// <summary>
        /// Sets the ArchiveDescription property
        /// </summary>
        /// <param name="archiveDescription">The value to set for the ArchiveDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetJobOutputResult WithArchiveDescription(string archiveDescription)
        {
            this.archiveDescription = archiveDescription;
            return this;
        }
            

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this.archiveDescription != null;       
        }
    }
}
