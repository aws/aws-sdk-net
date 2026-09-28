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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutPermission operation. Adds permissions to a
    /// profiling group's resource-based policy that are provided using an action group. If
    /// a profiling group doesn't have a resource-based policy, one is created for it using
    /// the permissions in the action group and the roles and users in the <c>principals</c>
    /// parameter. <para> The one supported action group that can be added is <c>agentPermission</c>
    /// which grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
    /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
    /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
    /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
    /// <c>PostAgentProfile</c> </a>. </para> <para> The first time you call <c>PutPermission</c>
    /// on a profiling group, do not specify a <c>revisionId</c> because it doesn't have a
    /// resource-based policy. Subsequent calls must provide a <c>revisionId</c> to specify
    /// which revision of the resource-based policy to add the permissions to. </para> <para>
    /// The response contains the profiling group's JSON-formatted resource policy. </para>
    /// </summary>
    public partial class PutPermissionRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property ActionGroup. 
        /// <para>
        ///  Specifies an action group that contains permissions to add to a profiling group resource.
        /// One action group is supported, <c>agentPermissions</c>, which grants permission to
        /// perform actions required by the profiling agent, <c>ConfigureAgent</c> and <c>PostAgentProfile</c>
        /// permissions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionGroup ActionGroup { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroup property is set.
        /// </summary>
        internal bool IsSetActionGroup() => this.ActionGroup != null;

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        ///  A list ARNs for the roles and users you want to grant access to the profiling group.
        /// Wildcards are not are supported in the ARNs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> Principals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Principals property is set.
        /// </summary>
        internal bool IsSetPrincipals() => this.Principals != null && (this.Principals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group to grant access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        ///  A universally unique identifier (UUID) for the revision of the policy you are adding
        /// to the profiling group. Do not specify this when you add permissions to a profiling
        /// group for the first time. If a policy already exists on the profiling group, you must
        /// specify the <c>revisionId</c>. 
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;
    }
}
