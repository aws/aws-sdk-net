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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetAutoSnapshots operation.
    /// </summary>
    public partial class GetAutoSnapshotsResponse : AmazonWebServiceResponse
    {
        private List<AutoSnapshotDetails> _autoSnapshots = AWSConfigs.InitializeCollections ? new List<AutoSnapshotDetails>() : null;
        private string _resourceName;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AutoSnapshots. 
        /// <para>
        /// An array of objects that describe the automatic snapshots that are available for the
        /// specified source instance or disk.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoSnapshotDetails> AutoSnapshots
        {
            get { return this._autoSnapshots; }
            set { this._autoSnapshots = value; }
        }

        // Check to see if AutoSnapshots property is set
        internal bool IsSetAutoSnapshots()
        {
            return this._autoSnapshots != null && (this._autoSnapshots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the source instance or disk for the automatic snapshots.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the automatic snapshot. The possible values are <c>Instance</c>,
        /// and <c>Disk</c>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
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