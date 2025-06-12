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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyManagedPrefixList operation.
    /// Modifies the specified managed prefix list.
    /// 
    ///  
    /// <para>
    /// Adding or removing entries in a prefix list creates a new version of the prefix list.
    /// Changing the name of the prefix list does not affect the version.
    /// </para>
    ///  
    /// <para>
    /// If you specify a current version number that does not match the true current version
    /// number, the request fails.
    /// </para>
    /// </summary>
    public partial class ModifyManagedPrefixListRequest : AmazonEC2Request
    {
        private List<AddPrefixListEntry> _addEntries = AWSConfigs.InitializeCollections ? new List<AddPrefixListEntry>() : null;
        private long? _currentVersion;
        private bool? _dryRun;
        private int? _maxEntries;
        private string _prefixListId;
        private string _prefixListName;
        private List<RemovePrefixListEntry> _removeEntries = AWSConfigs.InitializeCollections ? new List<RemovePrefixListEntry>() : null;

        /// <summary>
        /// Gets and sets the property AddEntries. 
        /// <para>
        /// One or more entries to add to the prefix list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AddPrefixListEntry> AddEntries
        {
            get { return this._addEntries; }
            set { this._addEntries = value; }
        }

        // Check to see if AddEntries property is set
        internal bool IsSetAddEntries()
        {
            return this._addEntries != null && (this._addEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version of the prefix list.
        /// </para>
        /// </summary>
        public long? CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxEntries. 
        /// <para>
        /// The maximum number of entries for the prefix list. You cannot modify the entries of
        /// a prefix list and modify the size of a prefix list at the same time.
        /// </para>
        ///  
        /// <para>
        /// If any of the resources that reference the prefix list cannot support the new maximum
        /// size, the modify operation fails. Check the state message for the IDs of the first
        /// ten resources that do not support the new maximum size.
        /// </para>
        /// </summary>
        public int? MaxEntries
        {
            get { return this._maxEntries; }
            set { this._maxEntries = value; }
        }

        // Check to see if MaxEntries property is set
        internal bool IsSetMaxEntries()
        {
            return this._maxEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListName. 
        /// <para>
        /// A name for the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListName
        {
            get { return this._prefixListName; }
            set { this._prefixListName = value; }
        }

        // Check to see if PrefixListName property is set
        internal bool IsSetPrefixListName()
        {
            return this._prefixListName != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveEntries. 
        /// <para>
        /// One or more entries to remove from the prefix list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<RemovePrefixListEntry> RemoveEntries
        {
            get { return this._removeEntries; }
            set { this._removeEntries = value; }
        }

        // Check to see if RemoveEntries property is set
        internal bool IsSetRemoveEntries()
        {
            return this._removeEntries != null && (this._removeEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}