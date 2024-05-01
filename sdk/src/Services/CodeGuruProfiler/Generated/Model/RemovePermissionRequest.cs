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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the RemovePermission operation.
    /// Removes permissions from a profiling group's resource-based policy that are provided
    /// using an action group. The one supported action group that can be removed is <c>agentPermission</c>
    /// which grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
    /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
    /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
    /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
    /// <c>PostAgentProfile</c> </a>.
    /// </summary>
    public partial class RemovePermissionRequest : AmazonCodeGuruProfilerRequest
    {
        private ActionGroup _actionGroup;
        private string _profilingGroupName;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property ActionGroup. 
        /// <para>
        ///  Specifies an action group that contains the permissions to remove from a profiling
        /// group's resource-based policy. One action group is supported, <c>agentPermissions</c>,
        /// which grants <c>ConfigureAgent</c> and <c>PostAgentProfile</c> permissions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionGroup ActionGroup
        {
            get { return this._actionGroup; }
            set { this._actionGroup = value; }
        }

        // Check to see if ActionGroup property is set
        internal bool IsSetActionGroup()
        {
            return this._actionGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        ///  A universally unique identifier (UUID) for the revision of the resource-based policy
        /// from which you want to remove permissions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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