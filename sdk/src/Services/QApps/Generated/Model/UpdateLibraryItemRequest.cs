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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLibraryItem operation.
    /// Updates the library item for an Amazon Q App.
    /// </summary>
    public partial class UpdateLibraryItemRequest : AmazonQAppsRequest
    {
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceId;
        private string _libraryItemId;
        private LibraryItemStatus _status;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The new categories to associate with the library item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application environment instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryItemId. 
        /// <para>
        /// The unique identifier of the library item to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LibraryItemId
        {
            get { return this._libraryItemId; }
            set { this._libraryItemId = value; }
        }

        // Check to see if LibraryItemId property is set
        internal bool IsSetLibraryItemId()
        {
            return this._libraryItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status to set for the library item, such as "Published" or "Hidden".
        /// </para>
        /// </summary>
        public LibraryItemStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}