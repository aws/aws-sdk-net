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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeploymentTargets operation.
    /// Returns an array of target IDs that are associated a deployment.
    /// </summary>
    public partial class ListDeploymentTargetsRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private string _nextToken;
        private Dictionary<string, List<string>> _targetFilters = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token identifier returned from the previous <c>ListDeploymentTargets</c> call.
        /// It can be used to return the next set of deployment targets in the list. 
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

        /// <summary>
        /// Gets and sets the property TargetFilters. 
        /// <para>
        ///  A key used to filter the returned targets. The two valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TargetStatus</c> - A <c>TargetStatus</c> filter string can be <c>Failed</c>, <c>InProgress</c>,
        /// <c>Pending</c>, <c>Ready</c>, <c>Skipped</c>, <c>Succeeded</c>, or <c>Unknown</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServerInstanceLabel</c> - A <c>ServerInstanceLabel</c> filter string can be <c>Blue</c>
        /// or <c>Green</c>. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> TargetFilters
        {
            get { return this._targetFilters; }
            set { this._targetFilters = value; }
        }

        // Check to see if TargetFilters property is set
        internal bool IsSetTargetFilters()
        {
            return this._targetFilters != null && (this._targetFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}