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
    /// <para>Provides options for defining a job.</para>
    /// </summary>
    public class JobParameters  
    {
        
        private string format;
        private string type;
        private string archiveId;
        private string description;
        private string sNSTopic;
        private string retrievalByteRange;

        /// <summary>
        /// When initiating a job to retrieve a vault inventory, you can optionally add this parameter to your request to specify the output format. If
        /// you are initiating an inventory job and do not specify a Format field, JSON is the default format. Valid Values are "CSV" and "JSON".
        ///  
        /// </summary>
        public string Format
        {
            get { return this.format; }
            set { this.format = value; }
        }

        /// <summary>
        /// Sets the Format property
        /// </summary>
        /// <param name="format">The value to set for the Format property </param>
        /// <returns>this instance</returns>
        public JobParameters WithFormat(string format)
        {
            this.format = format;
            return this;
        }
            

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this.format != null;       
        }

        /// <summary>
        /// The job type. You can initiate a job to retrieve an archive or get an inventory of a vault. Valid Values are "archive-retrieval" and
        /// "inventory-retrieval".
        ///  
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        public JobParameters WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;       
        }

        /// <summary>
        /// The ID of the archive that you want to retrieve. This field is required only if <c>Type</c> is set to archive-retrieval. An error occurs if
        /// you specify this request parameter for an inventory retrieval job request.
        ///  
        /// </summary>
        public string ArchiveId
        {
            get { return this.archiveId; }
            set { this.archiveId = value; }
        }

        /// <summary>
        /// Sets the ArchiveId property
        /// </summary>
        /// <param name="archiveId">The value to set for the ArchiveId property </param>
        /// <returns>this instance</returns>
        public JobParameters WithArchiveId(string archiveId)
        {
            this.archiveId = archiveId;
            return this;
        }
            

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this.archiveId != null;       
        }

        /// <summary>
        /// The optional description for the job. The description must be less than or equal to 1,024 bytes. The allowable characters are 7-bit ASCII
        /// without control codes-specifically, ASCII values 32-126 decimal or 0x20-0x7E hexadecimal.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public JobParameters WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// The Amazon SNS topic ARN to which Amazon Glacier sends a notification when the job is completed and the output is ready for you to download.
        /// The specified topic publishes the notification to its subscribers. The SNS topic must exist.
        ///  
        /// </summary>
        public string SNSTopic
        {
            get { return this.sNSTopic; }
            set { this.sNSTopic = value; }
        }

        /// <summary>
        /// Sets the SNSTopic property
        /// </summary>
        /// <param name="sNSTopic">The value to set for the SNSTopic property </param>
        /// <returns>this instance</returns>
        public JobParameters WithSNSTopic(string sNSTopic)
        {
            this.sNSTopic = sNSTopic;
            return this;
        }
            

        // Check to see if SNSTopic property is set
        internal bool IsSetSNSTopic()
        {
            return this.sNSTopic != null;       
        }

        /// <summary>
        /// The byte range to retrieve for an archive retrieval. in the form "<i>StartByteValue</i>-<i>EndByteValue</i>" If not specified, the whole
        /// archive is retrieved. If specified, the byte range must be megabyte (1024*1024) aligned which means that <i>StartByteValue</i> must be
        /// divisible by 1 MB and <i>EndByteValue</i> plus 1 must be divisible by 1 MB or be the end of the archive specified as the archive byte size
        /// value minus 1. If RetrievalByteRange is not megabyte aligned, this operation returns a 400 response. An error occurs if you specify this
        /// field for an inventory retrieval job request.
        ///  
        /// </summary>
        public string RetrievalByteRange
        {
            get { return this.retrievalByteRange; }
            set { this.retrievalByteRange = value; }
        }

        /// <summary>
        /// Sets the RetrievalByteRange property
        /// </summary>
        /// <param name="retrievalByteRange">The value to set for the RetrievalByteRange property </param>
        /// <returns>this instance</returns>
        public JobParameters WithRetrievalByteRange(string retrievalByteRange)
        {
            this.retrievalByteRange = retrievalByteRange;
            return this;
        }
            

        // Check to see if RetrievalByteRange property is set
        internal bool IsSetRetrievalByteRange()
        {
            return this.retrievalByteRange != null;       
        }
    }
}
