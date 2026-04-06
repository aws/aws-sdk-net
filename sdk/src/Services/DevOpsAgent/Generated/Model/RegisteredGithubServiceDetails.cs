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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Details specific to a registered GitHub service.
    /// </summary>
    public partial class RegisteredGithubServiceDetails
    {
        private string _owner;
        private GithubRepoOwnerType _ownerType;
        private string _targetUrl;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The GitHub repository owner name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerType. 
        /// <para>
        /// The GitHub repository owner type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GithubRepoOwnerType OwnerType
        {
            get { return this._ownerType; }
            set { this._ownerType = value; }
        }

        // Check to see if OwnerType property is set
        internal bool IsSetOwnerType()
        {
            return this._ownerType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// The GitHub Enterprise Server instance URL (absent for github.com).
        /// </para>
        /// </summary>
        public string TargetUrl
        {
            get { return this._targetUrl; }
            set { this._targetUrl = value; }
        }

        // Check to see if TargetUrl property is set
        internal bool IsSetTargetUrl()
        {
            return this._targetUrl != null;
        }

    }
}