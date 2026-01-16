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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
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
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// This is the response object from the ListDeploymentPatternVersions operation.
    /// </summary>
    public partial class ListDeploymentPatternVersionsResponse : AmazonWebServiceResponse
    {
        private List<DeploymentPatternVersionDataSummary> _deploymentPatternVersions = AWSConfigs.InitializeCollections ? new List<DeploymentPatternVersionDataSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeploymentPatternVersions. 
        /// <para>
        /// The deployment pattern versions.
        /// </para>
        /// </summary>
        public List<DeploymentPatternVersionDataSummary> DeploymentPatternVersions
        {
            get { return this._deploymentPatternVersions; }
            set { this._deploymentPatternVersions = value; }
        }

        // Check to see if DeploymentPatternVersions property is set
        internal bool IsSetDeploymentPatternVersions()
        {
            return this._deploymentPatternVersions != null && (this._deploymentPatternVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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