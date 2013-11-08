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
    /// <para>Contains the Amazon Glacier response to your request.</para>
    /// </summary>
    public partial class ListMultipartUploadsResult : AmazonWebServiceResponse
    {
        
        private List<UploadListElement> uploadsList = new List<UploadListElement>();
        private string marker;

        /// <summary>
        /// A list of in-progress multipart uploads.
        ///  
        /// </summary>
        public List<UploadListElement> UploadsList
        {
            get { return this.uploadsList; }
            set { this.uploadsList = value; }
        }

        // Check to see if UploadsList property is set
        internal bool IsSetUploadsList()
        {
            return this.uploadsList.Count > 0;
        }

        /// <summary>
        /// An opaque string that represents where to continue pagination of the results. You use the marker in a new List Multipart Uploads request to
        /// obtain more uploads in the list. If there are no more uploads, this value is <c>null</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
