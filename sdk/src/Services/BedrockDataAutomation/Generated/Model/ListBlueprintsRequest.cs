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
    /// Container for the parameters to the ListBlueprints operation.
    /// Lists all existing Amazon Bedrock Data Automation Blueprints
    /// </summary>
    public partial class ListBlueprintsRequest : AmazonBedrockDataAutomationRequest
    {
        private string _blueprintArn;
        private BlueprintStageFilter _blueprintStageFilter;
        private int? _maxResults;
        private string _nextToken;
        private DataAutomationProjectFilter _projectFilter;
        private ResourceOwner _resourceOwner;

        /// <summary>
        /// Gets and sets the property BlueprintArn.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BlueprintArn
        {
            get { return this._blueprintArn; }
            set { this._blueprintArn = value; }
        }

        // Check to see if BlueprintArn property is set
        internal bool IsSetBlueprintArn()
        {
            return this._blueprintArn != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintStageFilter.
        /// </summary>
        public BlueprintStageFilter BlueprintStageFilter
        {
            get { return this._blueprintStageFilter; }
            set { this._blueprintStageFilter = value; }
        }

        // Check to see if BlueprintStageFilter property is set
        internal bool IsSetBlueprintStageFilter()
        {
            return this._blueprintStageFilter != null;
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
        /// Gets and sets the property ProjectFilter.
        /// </summary>
        public DataAutomationProjectFilter ProjectFilter
        {
            get { return this._projectFilter; }
            set { this._projectFilter = value; }
        }

        // Check to see if ProjectFilter property is set
        internal bool IsSetProjectFilter()
        {
            return this._projectFilter != null;
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