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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about an override event for approval rules for a pull request.
    /// </summary>
    public partial class ApprovalRuleOverriddenEventMetadata
    {
        private OverrideStatus _overrideStatus;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property OverrideStatus. 
        /// <para>
        /// The status of the override event.
        /// </para>
        /// </summary>
        public OverrideStatus OverrideStatus
        {
            get { return this._overrideStatus; }
            set { this._overrideStatus = value; }
        }

        // Check to see if OverrideStatus property is set
        internal bool IsSetOverrideStatus()
        {
            return this._overrideStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID of the pull request when the override event occurred.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

    }
}