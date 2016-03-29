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
    /// Container for the parameters to the ListDeployments operation.
    /// Lists the deployments in a deployment group for an application registered with the
    /// applicable IAM user or AWS account.
    /// </summary>
    public partial class ListDeploymentsRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private TimeRange _createTimeRange;
        private string _deploymentGroupName;
        private List<string> _includeOnlyStatuses = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an AWS CodeDeploy application associated with the applicable IAM user
        /// or AWS account.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimeRange. 
        /// <para>
        /// A time range (start and end) for returning a subset of the list of deployments.
        /// </para>
        /// </summary>
        public TimeRange CreateTimeRange
        {
            get { return this._createTimeRange; }
            set { this._createTimeRange = value; }
        }

        // Check to see if CreateTimeRange property is set
        internal bool IsSetCreateTimeRange()
        {
            return this._createTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The name of an existing deployment group for the specified application.
        /// </para>
        /// </summary>
        public string DeploymentGroupName
        {
            get { return this._deploymentGroupName; }
            set { this._deploymentGroupName = value; }
        }

        // Check to see if DeploymentGroupName property is set
        internal bool IsSetDeploymentGroupName()
        {
            return this._deploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeOnlyStatuses. 
        /// <para>
        /// A subset of deployments to list by status:
        /// </para>
        ///  <ul> <li>Created: Include created deployments in the resulting list.</li> <li>Queued:
        /// Include queued deployments in the resulting list.</li> <li>In Progress: Include in-progress
        /// deployments in the resulting list.</li> <li>Succeeded: Include successful deployments
        /// in the resulting list.</li> <li>Failed: Include failed deployments in the resulting
        /// list.</li> <li>Stopped: Include stopped deployments in the resulting list.</li> </ul>
        /// </summary>
        public List<string> IncludeOnlyStatuses
        {
            get { return this._includeOnlyStatuses; }
            set { this._includeOnlyStatuses = value; }
        }

        // Check to see if IncludeOnlyStatuses property is set
        internal bool IsSetIncludeOnlyStatuses()
        {
            return this._includeOnlyStatuses != null && this._includeOnlyStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier returned from the previous list deployments call. It can be used to
        /// return the next set of deployments in the list.
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