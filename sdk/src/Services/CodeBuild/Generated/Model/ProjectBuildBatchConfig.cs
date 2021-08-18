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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains configuration information about a batch build project.
    /// </summary>
    public partial class ProjectBuildBatchConfig
    {
        private bool? _combineArtifacts;
        private BatchRestrictions _restrictions;
        private string _serviceRole;
        private int? _timeoutInMins;

        /// <summary>
        /// Gets and sets the property CombineArtifacts. 
        /// <para>
        /// Specifies if the build artifacts for the batch build should be combined into a single
        /// artifact location.
        /// </para>
        /// </summary>
        public bool CombineArtifacts
        {
            get { return this._combineArtifacts.GetValueOrDefault(); }
            set { this._combineArtifacts = value; }
        }

        // Check to see if CombineArtifacts property is set
        internal bool IsSetCombineArtifacts()
        {
            return this._combineArtifacts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        /// A <code>BatchRestrictions</code> object that specifies the restrictions for the batch
        /// build.
        /// </para>
        /// </summary>
        public BatchRestrictions Restrictions
        {
            get { return this._restrictions; }
            set { this._restrictions = value; }
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this._restrictions != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// Specifies the service role ARN for the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMins. 
        /// <para>
        /// Specifies the maximum amount of time, in minutes, that the batch build must be completed
        /// in.
        /// </para>
        /// </summary>
        public int TimeoutInMins
        {
            get { return this._timeoutInMins.GetValueOrDefault(); }
            set { this._timeoutInMins = value; }
        }

        // Check to see if TimeoutInMins property is set
        internal bool IsSetTimeoutInMins()
        {
            return this._timeoutInMins.HasValue; 
        }

    }
}