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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterSnapshotAttribute operation.
    /// Adds an attribute and values to, or removes an attribute and values from, a manual
    /// DB cluster snapshot.
    /// 
    ///  
    /// <para>
    /// To share a manual cluster snapshot with other AWS accounts, specify <code>restore</code>
    /// as the <code>AttributeName</code>, and use the <code>ValuesToAdd</code> parameter
    /// to add a list of IDs of the AWS accounts that are authorized to restore the manual
    /// cluster snapshot. Use the value <code>all</code> to make the manual cluster snapshot
    /// public, which means that it can be copied or restored by all AWS accounts. Do not
    /// add the <code>all</code> value for any manual DB cluster snapshots that contain private
    /// information that you don't want available to all AWS accounts. If a manual cluster
    /// snapshot is encrypted, it can be shared, but only by specifying a list of authorized
    /// AWS account IDs for the <code>ValuesToAdd</code> parameter. You can't use <code>all</code>
    /// as a value for that parameter in this case.
    /// </para>
    /// </summary>
    public partial class ModifyDBClusterSnapshotAttributeRequest : AmazonDocDBRequest
    {
        private string _attributeName;
        private string _dbClusterSnapshotIdentifier;
        private List<string> _valuesToAdd = new List<string>();
        private List<string> _valuesToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the cluster snapshot attribute to modify.
        /// </para>
        ///  
        /// <para>
        /// To manage authorization for other AWS accounts to copy or restore a manual cluster
        /// snapshot, set this value to <code>restore</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// The identifier for the cluster snapshot to modify the attributes for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterSnapshotIdentifier
        {
            get { return this._dbClusterSnapshotIdentifier; }
            set { this._dbClusterSnapshotIdentifier = value; }
        }

        // Check to see if DBClusterSnapshotIdentifier property is set
        internal bool IsSetDBClusterSnapshotIdentifier()
        {
            return this._dbClusterSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ValuesToAdd. 
        /// <para>
        /// A list of cluster snapshot attributes to add to the attribute specified by <code>AttributeName</code>.
        /// </para>
        ///  
        /// <para>
        /// To authorize other AWS accounts to copy or restore a manual cluster snapshot, set
        /// this list to include one or more AWS account IDs. To make the manual cluster snapshot
        /// restorable by any AWS account, set it to <code>all</code>. Do not add the <code>all</code>
        /// value for any manual cluster snapshots that contain private information that you don't
        /// want to be available to all AWS accounts.
        /// </para>
        /// </summary>
        public List<string> ValuesToAdd
        {
            get { return this._valuesToAdd; }
            set { this._valuesToAdd = value; }
        }

        // Check to see if ValuesToAdd property is set
        internal bool IsSetValuesToAdd()
        {
            return this._valuesToAdd != null && this._valuesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValuesToRemove. 
        /// <para>
        /// A list of cluster snapshot attributes to remove from the attribute specified by <code>AttributeName</code>.
        /// </para>
        ///  
        /// <para>
        /// To remove authorization for other AWS accounts to copy or restore a manual cluster
        /// snapshot, set this list to include one or more AWS account identifiers. To remove
        /// authorization for any AWS account to copy or restore the cluster snapshot, set it
        /// to <code>all</code> . If you specify <code>all</code>, an AWS account whose account
        /// ID is explicitly added to the <code>restore</code> attribute can still copy or restore
        /// a manual cluster snapshot.
        /// </para>
        /// </summary>
        public List<string> ValuesToRemove
        {
            get { return this._valuesToRemove; }
            set { this._valuesToRemove = value; }
        }

        // Check to see if ValuesToRemove property is set
        internal bool IsSetValuesToRemove()
        {
            return this._valuesToRemove != null && this._valuesToRemove.Count > 0; 
        }

    }
}