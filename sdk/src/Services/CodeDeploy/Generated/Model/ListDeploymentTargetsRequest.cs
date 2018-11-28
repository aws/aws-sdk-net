/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private Dictionary<string, List<string>> _targetFilters = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
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
        ///  A token identifier returned from the previous <code>ListDeploymentTargets</code>
        /// call. It can be used to return the next set of deployment targets in the list. 
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
        ///  A key used to filter the returned targets. 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> TargetFilters
        {
            get { return this._targetFilters; }
            set { this._targetFilters = value; }
        }

        // Check to see if TargetFilters property is set
        internal bool IsSetTargetFilters()
        {
            return this._targetFilters != null && this._targetFilters.Count > 0; 
        }

    }
}