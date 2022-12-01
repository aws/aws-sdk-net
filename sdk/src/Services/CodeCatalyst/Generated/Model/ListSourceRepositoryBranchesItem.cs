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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about a branch of a source repository returned in a list of branches.
    /// </summary>
    public partial class ListSourceRepositoryBranchesItem
    {
        private string _headCommitId;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _ref;

        /// <summary>
        /// Gets and sets the property HeadCommitId. 
        /// <para>
        /// The commit ID of the tip of the branch at the time of the request, also known as the
        /// head commit.
        /// </para>
        /// </summary>
        public string HeadCommitId
        {
            get { return this._headCommitId; }
            set { this._headCommitId = value; }
        }

        // Check to see if HeadCommitId property is set
        internal bool IsSetHeadCommitId()
        {
            return this._headCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time the branch was last updated, in coordinated universal time (UTC) timestamp
        /// format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the branch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Ref. 
        /// <para>
        /// The Git reference name of the branch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Ref
        {
            get { return this._ref; }
            set { this._ref = value; }
        }

        // Check to see if Ref property is set
        internal bool IsSetRef()
        {
            return this._ref != null;
        }

    }
}