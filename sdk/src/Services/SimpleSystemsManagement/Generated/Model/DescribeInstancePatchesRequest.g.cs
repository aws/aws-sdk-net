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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstancePatches operation. Retrieves information
    /// about the patches on the specified managed node and their state relative to the patch
    /// baseline being used for the node.
    /// </summary>
    public partial class DescribeInstancePatchesRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Each element in the array is a structure containing a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// Supported keys for <c>DescribeInstancePatches</c>include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Classification</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Security</c> | <c>SecurityUpdates</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>KBId</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>KB4480056</c> | <c>java-1.7.0-openjdk.x86_64</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Severity</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Important</c> | <c>Medium</c> | <c>Low</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>State</c> </b> 
        /// </para>
        ///  
        /// <para>
        /// Sample values: <c>Installed</c> | <c>InstalledOther</c> | <c>InstalledPendingReboot</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For lists of all <c>State</c> values, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-compliance-states.html">Patch
        /// compliance state values</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<PatchOrchestratorFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<PatchOrchestratorFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node whose patch state information should be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of patches to return (per page).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
