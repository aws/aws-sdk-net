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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetPromptFile operation.
    /// </summary>
    public partial class GetPromptFileResponse : AmazonWebServiceResponse
    {
        private string _promptPresignedUrl;

        /// <summary>
        /// Gets and sets the property PromptPresignedUrl. 
        /// <para>
        /// A generated URL to the prompt that can be given to an unauthorized user so they can
        /// access the prompt in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string PromptPresignedUrl
        {
            get { return this._promptPresignedUrl; }
            set { this._promptPresignedUrl = value; }
        }

        // Check to see if PromptPresignedUrl property is set
        internal bool IsSetPromptPresignedUrl()
        {
            return this._promptPresignedUrl != null;
        }

    }
}