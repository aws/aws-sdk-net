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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the inventory configuration for an Amazon S3 bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketGETInventoryConfig.html">GET
    /// Bucket inventory</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public partial class InventoryConfiguration
    {
        private InventoryDestination _destination;
        private InventoryFilter _filter;
        private string _id;
        private InventoryIncludedObjectVersions _includedObjectVersions;
        private bool? _isEnabled;
        private List<string> _optionalFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private InventorySchedule _schedule;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Contains information about where to publish the inventory results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies an inventory filter. The inventory only includes objects that meet the filter's
        /// criteria.
        /// </para>
        /// </summary>
        public InventoryFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID used to identify the inventory configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedObjectVersions. 
        /// <para>
        /// Object versions to include in the inventory list. If set to <c>All</c>, the list includes
        /// all the object versions, which adds the version-related fields <c>VersionId</c>, <c>IsLatest</c>,
        /// and <c>DeleteMarker</c> to the list. If set to <c>Current</c>, the list does not contain
        /// these version-related fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryIncludedObjectVersions IncludedObjectVersions
        {
            get { return this._includedObjectVersions; }
            set { this._includedObjectVersions = value; }
        }

        // Check to see if IncludedObjectVersions property is set
        internal bool IsSetIncludedObjectVersions()
        {
            return this._includedObjectVersions != null;
        }

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Specifies whether the inventory is enabled or disabled. If set to <c>True</c>, an
        /// inventory list is generated. If set to <c>False</c>, no inventory list is generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionalFields. 
        /// <para>
        /// Contains the optional fields that are included in the inventory results.
        /// </para>
        /// </summary>
        public List<string> OptionalFields
        {
            get { return this._optionalFields; }
            set { this._optionalFields = value; }
        }

        // Check to see if OptionalFields property is set
        internal bool IsSetOptionalFields()
        {
            return this._optionalFields != null && (this._optionalFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Specifies the schedule for generating inventory results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventorySchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

    }
}