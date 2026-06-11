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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Describes changes to service references.
    /// </summary>
    public partial class ServiceReferenceChanges
    {
        private List<ServiceReference> _added = AWSConfigs.InitializeCollections ? new List<ServiceReference>() : null;
        private List<ServiceReference> _removed = AWSConfigs.InitializeCollections ? new List<ServiceReference>() : null;

        /// <summary>
        /// Gets and sets the property Added. 
        /// <para>
        /// The list of service references that were added.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceReference> Added
        {
            get { return this._added; }
            set { this._added = value; }
        }

        // Check to see if Added property is set
        internal bool IsSetAdded()
        {
            return this._added != null && (this._added.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Removed. 
        /// <para>
        /// The list of service references that were removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceReference> Removed
        {
            get { return this._removed; }
            set { this._removed = value; }
        }

        // Check to see if Removed property is set
        internal bool IsSetRemoved()
        {
            return this._removed != null && (this._removed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}