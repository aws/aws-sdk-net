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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutComplianceItems operation.
    /// Registers a compliance type and other compliance details on a designated resource.
    /// This action lets you register custom compliance details with a resource. This call
    /// overwrites existing compliance information on the resource, so you must provide a
    /// full list of compliance items each time that you send the request.
    /// 
    ///  
    /// <para>
    /// ComplianceType can be one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// ExecutionId: The execution ID when the patch, association, or custom compliance item
    /// was applied.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ExecutionType: Specify patch, association, or Custom:<code>string</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ExecutionTime. The time the patch, association, or custom compliance item was applied
    /// to the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Id: The patch, association, or custom compliance ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Title: A title.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Status: The status of the compliance item. For example, <code>approved</code> for
    /// patches, or <code>Failed</code> for associations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Severity: A patch severity. For example, <code>critical</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DocumentName: A SSM document name. For example, AWS-RunPatchBaseline.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DocumentVersion: An SSM document version number. For example, 4.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Classification: A patch classification. For example, <code>security updates</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PatchBaselineId: A patch baseline ID.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PatchSeverity: A patch severity. For example, <code>Critical</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PatchState: A patch state. For example, <code>InstancesWithFailedPatches</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PatchGroup: The name of a patch group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// InstalledTime: The time the association, patch, or custom compliance item was applied
    /// to the resource. Specify the time by using the following format: yyyy-MM-dd'T'HH:mm:ss'Z'
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutComplianceItemsRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _complianceType;
        private ComplianceExecutionSummary _executionSummary;
        private string _itemContentHash;
        private List<ComplianceItemEntry> _items = new List<ComplianceItemEntry>();
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Specify the compliance type. For example, specify Association (for a State Manager
        /// association), Patch, or Custom:<code>string</code>.
        /// </para>
        /// </summary>
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// A summary of the call execution that includes an execution ID, the type of execution
        /// (for example, <code>Command</code>), and the date/time of the execution using a datetime
        /// object that is saved in the following format: yyyy-MM-dd'T'HH:mm:ss'Z'.
        /// </para>
        /// </summary>
        public ComplianceExecutionSummary ExecutionSummary
        {
            get { return this._executionSummary; }
            set { this._executionSummary = value; }
        }

        // Check to see if ExecutionSummary property is set
        internal bool IsSetExecutionSummary()
        {
            return this._executionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ItemContentHash. 
        /// <para>
        /// MD5 or SHA-256 content hash. The content hash is used to determine if existing information
        /// should be overwritten or ignored. If the content hashes match, the request to put
        /// compliance information is ignored.
        /// </para>
        /// </summary>
        public string ItemContentHash
        {
            get { return this._itemContentHash; }
            set { this._itemContentHash = value; }
        }

        // Check to see if ItemContentHash property is set
        internal bool IsSetItemContentHash()
        {
            return this._itemContentHash != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Information about the compliance as defined by the resource type. For example, for
        /// a patch compliance type, <code>Items</code> includes information about the PatchSeverity,
        /// Classification, etc.
        /// </para>
        /// </summary>
        public List<ComplianceItemEntry> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specify an ID for this resource. For a managed instance, this is the instance ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specify the type of resource. <code>ManagedInstance</code> is currently the only supported
        /// resource type.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}