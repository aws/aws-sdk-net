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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the ListMessageTemplateVersions operation.
    /// </summary>
    public partial class ListMessageTemplateVersionsResponse : AmazonWebServiceResponse
    {
        private List<MessageTemplateVersionSummary> _messageTemplateVersionSummaries = AWSConfigs.InitializeCollections ? new List<MessageTemplateVersionSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MessageTemplateVersionSummaries. 
        /// <para>
        /// Summary information about the versions of a message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MessageTemplateVersionSummary> MessageTemplateVersionSummaries
        {
            get { return this._messageTemplateVersionSummaries; }
            set { this._messageTemplateVersionSummaries = value; }
        }

        // Check to see if MessageTemplateVersionSummaries property is set
        internal bool IsSetMessageTemplateVersionSummaries()
        {
            return this._messageTemplateVersionSummaries != null && (this._messageTemplateVersionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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