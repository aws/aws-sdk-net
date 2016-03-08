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
    /// Information about an application revision.
    /// </summary>
    public partial class GenericRevisionInfo
    {
        private List<string> _deploymentGroups = new List<string>();
        private string _description;
        private DateTime? _firstUsedTime;
        private DateTime? _lastUsedTime;
        private DateTime? _registerTime;

        /// <summary>
        /// Gets and sets the property DeploymentGroups. 
        /// <para>
        /// The deployment groups where this is the current target revision.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A comment about the revision.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FirstUsedTime. 
        /// <para>
        /// When the revision was first used by AWS CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime FirstUsedTime
        {
            get { return this._firstUsedTime.GetValueOrDefault(); }
            set { this._firstUsedTime = value; }
        }

        // Check to see if FirstUsedTime property is set
        internal bool IsSetFirstUsedTime()
        {
            return this._firstUsedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUsedTime. 
        /// <para>
        /// When the revision was last used by AWS CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime LastUsedTime
        {
            get { return this._lastUsedTime.GetValueOrDefault(); }
            set { this._lastUsedTime = value; }
        }

        // Check to see if LastUsedTime property is set
        internal bool IsSetLastUsedTime()
        {
            return this._lastUsedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisterTime. 
        /// <para>
        /// When the revision was registered with AWS CodeDeploy.
        /// </para>
        /// </summary>
        public DateTime RegisterTime
        {
            get { return this._registerTime.GetValueOrDefault(); }
            set { this._registerTime = value; }
        }

        // Check to see if RegisterTime property is set
        internal bool IsSetRegisterTime()
        {
            return this._registerTime.HasValue; 
        }

    }
}