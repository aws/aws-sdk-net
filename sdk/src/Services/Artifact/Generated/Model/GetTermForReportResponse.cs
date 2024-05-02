/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// This is the response object from the GetTermForReport operation.
    /// </summary>
    public partial class GetTermForReportResponse : AmazonWebServiceResponse
    {
        private string _documentPresignedUrl;
        private string _termToken;

        /// <summary>
        /// Gets and sets the property DocumentPresignedUrl. 
        /// <para>
        /// Presigned S3 url to access the term content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string DocumentPresignedUrl
        {
            get { return this._documentPresignedUrl; }
            set { this._documentPresignedUrl = value; }
        }

        // Check to see if DocumentPresignedUrl property is set
        internal bool IsSetDocumentPresignedUrl()
        {
            return this._documentPresignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TermToken. 
        /// <para>
        /// Unique token representing this request event.
        /// </para>
        /// </summary>
        public string TermToken
        {
            get { return this._termToken; }
            set { this._termToken = value; }
        }

        // Check to see if TermToken property is set
        internal bool IsSetTermToken()
        {
            return this._termToken != null;
        }

    }
}