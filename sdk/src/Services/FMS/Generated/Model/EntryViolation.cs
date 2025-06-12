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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Detailed information about an entry violation in a network ACL. The violation is against
    /// the network ACL specification inside the Firewall Manager network ACL policy. This
    /// data object is part of <c>InvalidNetworkAclEntriesViolation</c>.
    /// </summary>
    public partial class EntryViolation
    {
        private string _actualEvaluationOrder;
        private List<EntryDescription> _entriesWithConflicts = AWSConfigs.InitializeCollections ? new List<EntryDescription>() : null;
        private EntryDescription _entryAtExpectedEvaluationOrder;
        private List<string> _entryViolationReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EntryDescription _expectedEntry;
        private string _expectedEvaluationOrder;

        /// <summary>
        /// Gets and sets the property ActualEvaluationOrder. 
        /// <para>
        /// The evaluation location within the ordered list of entries where the <c>ExpectedEntry</c>
        /// is currently located. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ActualEvaluationOrder
        {
            get { return this._actualEvaluationOrder; }
            set { this._actualEvaluationOrder = value; }
        }

        // Check to see if ActualEvaluationOrder property is set
        internal bool IsSetActualEvaluationOrder()
        {
            return this._actualEvaluationOrder != null;
        }

        /// <summary>
        /// Gets and sets the property EntriesWithConflicts. 
        /// <para>
        /// The list of entries that are in conflict with <c>ExpectedEntry</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntryDescription> EntriesWithConflicts
        {
            get { return this._entriesWithConflicts; }
            set { this._entriesWithConflicts = value; }
        }

        // Check to see if EntriesWithConflicts property is set
        internal bool IsSetEntriesWithConflicts()
        {
            return this._entriesWithConflicts != null && (this._entriesWithConflicts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntryAtExpectedEvaluationOrder. 
        /// <para>
        /// The entry that's currently in the <c>ExpectedEvaluationOrder</c> location, in place
        /// of the expected entry. 
        /// </para>
        /// </summary>
        public EntryDescription EntryAtExpectedEvaluationOrder
        {
            get { return this._entryAtExpectedEvaluationOrder; }
            set { this._entryAtExpectedEvaluationOrder = value; }
        }

        // Check to see if EntryAtExpectedEvaluationOrder property is set
        internal bool IsSetEntryAtExpectedEvaluationOrder()
        {
            return this._entryAtExpectedEvaluationOrder != null;
        }

        /// <summary>
        /// Gets and sets the property EntryViolationReasons. 
        /// <para>
        /// Descriptions of the violations that Firewall Manager found for these entries. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryViolationReasons
        {
            get { return this._entryViolationReasons; }
            set { this._entryViolationReasons = value; }
        }

        // Check to see if EntryViolationReasons property is set
        internal bool IsSetEntryViolationReasons()
        {
            return this._entryViolationReasons != null && (this._entryViolationReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedEntry. 
        /// <para>
        /// The Firewall Manager-managed network ACL entry that is involved in the entry violation.
        /// 
        /// </para>
        /// </summary>
        public EntryDescription ExpectedEntry
        {
            get { return this._expectedEntry; }
            set { this._expectedEntry = value; }
        }

        // Check to see if ExpectedEntry property is set
        internal bool IsSetExpectedEntry()
        {
            return this._expectedEntry != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedEvaluationOrder. 
        /// <para>
        /// The evaluation location within the ordered list of entries where the <c>ExpectedEntry</c>
        /// should be, according to the network ACL policy specifications. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ExpectedEvaluationOrder
        {
            get { return this._expectedEvaluationOrder; }
            set { this._expectedEvaluationOrder = value; }
        }

        // Check to see if ExpectedEvaluationOrder property is set
        internal bool IsSetExpectedEvaluationOrder()
        {
            return this._expectedEvaluationOrder != null;
        }

    }
}