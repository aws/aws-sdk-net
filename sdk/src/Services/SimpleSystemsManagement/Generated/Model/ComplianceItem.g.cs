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
    /// Information about the compliance as defined by the resource type. For example, for
    /// a patch resource type, <c>Items</c> includes information about the PatchSeverity,
    /// Classification, and so on.
    /// </summary>
    public partial class ComplianceItem
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type. For example, Association (for a State Manager association), Patch,
        /// or Custom:<c>string</c> are all valid compliance types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A "Key": "Value" tag combination for the compliance item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Details { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null && (this.Details.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// A summary for the compliance item. The summary includes an execution ID, the execution
        /// type (for example, command), and the execution time.
        /// </para>
        ///  <important> 
        /// <para>
        /// For State Manager associations, the <c>ExecutionTime</c> value represents when the
        /// compliance status was captured and aggregated by the Systems Manager service, not
        /// necessarily when the underlying association was executed on the managed node. State
        /// Manager updates compliance status for all associations on an instance whenever any
        /// association executes, which means multiple associations may show the same execution
        /// time even if they were executed at different times.
        /// </para>
        ///  </important>
        /// </summary>
        public ComplianceExecutionSummary ExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionSummary property is set.
        /// </summary>
        internal bool IsSetExecutionSummary() => this.ExecutionSummary != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An ID for the compliance item. For example, if the compliance item is a Windows patch,
        /// the ID could be the number of the KB article; for example: KB4010320.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// An ID for the resource. For a managed node, this is the node ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource. <c>ManagedInstance</c> is currently the only supported resource
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the compliance status. Severity can be one of the following: Critical,
        /// High, Medium, Low, Informational, Unspecified.
        /// </para>
        /// </summary>
        public ComplianceSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the compliance item. An item is either COMPLIANT, NON_COMPLIANT, or
        /// an empty string (for Windows patches that aren't applicable).
        /// </para>
        /// </summary>
        public ComplianceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title for the compliance item. For example, if the compliance item is a Windows
        /// patch, the title could be the title of the KB article for the patch; for example:
        /// Security Update for Active Directory Federation Services.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
