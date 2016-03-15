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
    /// Represents the output of a list deployment groups operation.
    /// </summary>
    public partial class ListDeploymentGroupsResponse : AmazonWebServiceResponse
    {
        private string _applicationName;
        private List<string> _deploymentGroups = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
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
        /// Gets and sets the property DeploymentGroups. 
        /// <para>
        /// A list of corresponding deployment group names.
        /// </para>
        /// </summary>
        public List<string> DeploymentGroups
        {
            get { return this._deploymentGroups; }
            set { this._deploymentGroups = value; }
        }

        // Check to see if DeploymentGroups property is set
        internal bool IsSetDeploymentGroups()
        {
            return this._deploymentGroups != null && this._deploymentGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a large amount of information is returned, an identifier is also returned. It can
        /// be used in a subsequent list deployment groups call to return the next set of deployment
        /// groups in the list.
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