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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// This is the response object from the ListTemplates operation.
    /// </summary>
    public partial class ListTemplatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TemplateSummary> _templates = AWSConfigs.InitializeCollections ? new List<TemplateSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Use this parameter when paginating results in a subsequent request after you receive
        /// a response with truncated results. Set it to the value of the <c>NextToken</c> parameter
        /// from the response you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

        /// <summary>
        /// Gets and sets the property Templates. 
        /// <para>
        /// Custom configuration templates used when issuing a certificate. 
        /// </para>
        /// </summary>
        public List<TemplateSummary> Templates
        {
            get { return this._templates; }
            set { this._templates = value; }
        }

        // Check to see if Templates property is set
        internal bool IsSetTemplates()
        {
            return this._templates != null && (this._templates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}