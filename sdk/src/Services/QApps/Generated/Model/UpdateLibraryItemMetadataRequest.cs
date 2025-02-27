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
    /// Container for the parameters to the UpdateLibraryItemMetadata operation.
    /// Updates the verification status of a library item for an Amazon Q App.
    /// </summary>
    public partial class UpdateLibraryItemMetadataRequest : AmazonQAppsRequest
    {
        private string _instanceId;
        private bool? _isVerified;
        private string _libraryItemId;

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
        /// Gets and sets the property IsVerified. 
        /// <para>
        /// The verification status of the library item
        /// </para>
        /// </summary>
        public bool? IsVerified
        {
            get { return this._isVerified; }
            set { this._isVerified = value; }
        }

        // Check to see if IsVerified property is set
        internal bool IsSetIsVerified()
        {
            return this._isVerified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LibraryItemId. 
        /// <para>
        /// The unique identifier of the updated library item.
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

    }
}