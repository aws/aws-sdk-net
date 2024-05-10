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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
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
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// This is the response object from the ListTemplateSteps operation.
    /// </summary>
    public partial class ListTemplateStepsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TemplateStepSummary> _templateStepSummaryList = AWSConfigs.InitializeCollections ? new List<TemplateStepSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property TemplateStepSummaryList. 
        /// <para>
        /// The list of summaries of steps in a template.
        /// </para>
        /// </summary>
        public List<TemplateStepSummary> TemplateStepSummaryList
        {
            get { return this._templateStepSummaryList; }
            set { this._templateStepSummaryList = value; }
        }

        // Check to see if TemplateStepSummaryList property is set
        internal bool IsSetTemplateStepSummaryList()
        {
            return this._templateStepSummaryList != null && (this._templateStepSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}