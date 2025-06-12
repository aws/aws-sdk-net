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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterSnapshotAttribute operation.
    /// Adds an attribute and values to, or removes an attribute and values from, a manual
    /// cluster snapshot.
    /// 
    ///  
    /// <para>
    /// To share a manual cluster snapshot with other Amazon Web Services accounts, specify
    /// <c>restore</c> as the <c>AttributeName</c>, and use the <c>ValuesToAdd</c> parameter
    /// to add a list of IDs of the Amazon Web Services accounts that are authorized to restore
    /// the manual cluster snapshot. Use the value <c>all</c> to make the manual cluster snapshot
    /// public, which means that it can be copied or restored by all Amazon Web Services accounts.
    /// Do not add the <c>all</c> value for any manual cluster snapshots that contain private
    /// information that you don't want available to all Amazon Web Services accounts. If
    /// a manual cluster snapshot is encrypted, it can be shared, but only by specifying a
    /// list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
    /// You can't use <c>all</c> as a value for that parameter in this case.
    /// </para>
    /// </summary>
    public partial class ModifyDBClusterSnapshotAttributeRequest : AmazonDocDBRequest
    {
        private string _attributeName;
        private string _dbClusterSnapshotIdentifier;
        private List<string> _valuesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _valuesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the cluster snapshot attribute to modify.
        /// </para>
        ///  
        /// <para>
        /// To manage authorization for other Amazon Web Services accounts to copy or restore
        /// a manual cluster snapshot, set this value to <c>restore</c>.
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
        /// A list of cluster snapshot attributes to add to the attribute specified by <c>AttributeName</c>.
        /// </para>
        ///  
        /// <para>
        /// To authorize other Amazon Web Services accounts to copy or restore a manual cluster
        /// snapshot, set this list to include one or more Amazon Web Services account IDs. To
        /// make the manual cluster snapshot restorable by any Amazon Web Services account, set
        /// it to <c>all</c>. Do not add the <c>all</c> value for any manual cluster snapshots
        /// that contain private information that you don't want to be available to all Amazon
        /// Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValuesToAdd
        {
            get { return this._valuesToAdd; }
            set { this._valuesToAdd = value; }
        }

        // Check to see if ValuesToAdd property is set
        internal bool IsSetValuesToAdd()
        {
            return this._valuesToAdd != null && (this._valuesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValuesToRemove. 
        /// <para>
        /// A list of cluster snapshot attributes to remove from the attribute specified by <c>AttributeName</c>.
        /// </para>
        ///  
        /// <para>
        /// To remove authorization for other Amazon Web Services accounts to copy or restore
        /// a manual cluster snapshot, set this list to include one or more Amazon Web Services
        /// account identifiers. To remove authorization for any Amazon Web Services account to
        /// copy or restore the cluster snapshot, set it to <c>all</c> . If you specify <c>all</c>,
        /// an Amazon Web Services account whose account ID is explicitly added to the <c>restore</c>
        /// attribute can still copy or restore a manual cluster snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValuesToRemove
        {
            get { return this._valuesToRemove; }
            set { this._valuesToRemove = value; }
        }

        // Check to see if ValuesToRemove property is set
        internal bool IsSetValuesToRemove()
        {
            return this._valuesToRemove != null && (this._valuesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}