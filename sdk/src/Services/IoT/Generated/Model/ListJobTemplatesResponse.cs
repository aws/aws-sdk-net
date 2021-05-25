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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the ListJobTemplates operation.
    /// </summary>
    public partial class ListJobTemplatesResponse : AmazonWebServiceResponse
    {
        private List<JobTemplateSummary> _jobTemplates = new List<JobTemplateSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobTemplates. 
        /// <para>
        /// A list of objects that contain information about the job templates.
        /// </para>
        /// </summary>
        public List<JobTemplateSummary> JobTemplates
        {
            get { return this._jobTemplates; }
            set { this._jobTemplates = value; }
        }

        // Check to see if JobTemplates property is set
        internal bool IsSetJobTemplates()
        {
            return this._jobTemplates != null && this._jobTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or <b>null</b> if there are no additional results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}