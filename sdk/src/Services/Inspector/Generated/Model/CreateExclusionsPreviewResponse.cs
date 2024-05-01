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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the CreateExclusionsPreview operation.
    /// </summary>
    public partial class CreateExclusionsPreviewResponse : AmazonWebServiceResponse
    {
        private string _previewToken;

        /// <summary>
        /// Gets and sets the property PreviewToken. 
        /// <para>
        /// Specifies the unique identifier of the requested exclusions preview. You can use the
        /// unique identifier to retrieve the exclusions preview when running the GetExclusionsPreview
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PreviewToken
        {
            get { return this._previewToken; }
            set { this._previewToken = value; }
        }

        // Check to see if PreviewToken property is set
        internal bool IsSetPreviewToken()
        {
            return this._previewToken != null;
        }

    }
}