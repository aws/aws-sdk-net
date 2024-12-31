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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataAutomationProjects operation.
    /// Lists all existing Amazon Bedrock Data Automation Projects
    /// </summary>
    public partial class ListDataAutomationProjectsRequest : AmazonBedrockDataAutomationRequest
    {
        private BlueprintFilter _blueprintFilter;
        private int? _maxResults;
        private string _nextToken;
        private DataAutomationProjectStageFilter _projectStageFilter;
        private ResourceOwner _resourceOwner;

        /// <summary>
        /// Gets and sets the property BlueprintFilter.
        /// </summary>
        public BlueprintFilter BlueprintFilter
        {
            get { return this._blueprintFilter; }
            set { this._blueprintFilter = value; }
        }

        // Check to see if BlueprintFilter property is set
        internal bool IsSetBlueprintFilter()
        {
            return this._blueprintFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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

        /// <summary>
        /// Gets and sets the property ProjectStageFilter.
        /// </summary>
        public DataAutomationProjectStageFilter ProjectStageFilter
        {
            get { return this._projectStageFilter; }
            set { this._projectStageFilter = value; }
        }

        // Check to see if ProjectStageFilter property is set
        internal bool IsSetProjectStageFilter()
        {
            return this._projectStageFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner.
        /// </summary>
        public ResourceOwner ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

    }
}