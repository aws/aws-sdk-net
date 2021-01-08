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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// This is the response object from the AddResourcePermissions operation.
    /// </summary>
    public partial class AddResourcePermissionsResponse : AmazonWebServiceResponse
    {
        private List<ShareResult> _shareResults = new List<ShareResult>();

        /// <summary>
        /// Gets and sets the property ShareResults. 
        /// <para>
        /// The share results.
        /// </para>
        /// </summary>
        public List<ShareResult> ShareResults
        {
            get { return this._shareResults; }
            set { this._shareResults = value; }
        }

        // Check to see if ShareResults property is set
        internal bool IsSetShareResults()
        {
            return this._shareResults != null && this._shareResults.Count > 0; 
        }

    }
}