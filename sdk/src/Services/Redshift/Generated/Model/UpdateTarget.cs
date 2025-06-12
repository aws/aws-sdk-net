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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// A maintenance track that you can switch the current track to.
    /// </summary>
    public partial class UpdateTarget
    {
        private string _databaseVersion;
        private string _maintenanceTrackName;
        private List<SupportedOperation> _supportedOperations = AWSConfigs.InitializeCollections ? new List<SupportedOperation>() : null;

        /// <summary>
        /// Gets and sets the property DatabaseVersion. 
        /// <para>
        /// The cluster version for the new maintenance track.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DatabaseVersion
        {
            get { return this._databaseVersion; }
            set { this._databaseVersion = value; }
        }

        // Check to see if DatabaseVersion property is set
        internal bool IsSetDatabaseVersion()
        {
            return this._databaseVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the new maintenance track.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string MaintenanceTrackName
        {
            get { return this._maintenanceTrackName; }
            set { this._maintenanceTrackName = value; }
        }

        // Check to see if MaintenanceTrackName property is set
        internal bool IsSetMaintenanceTrackName()
        {
            return this._maintenanceTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedOperations. 
        /// <para>
        /// A list of operations supported by the maintenance track.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SupportedOperation> SupportedOperations
        {
            get { return this._supportedOperations; }
            set { this._supportedOperations = value; }
        }

        // Check to see if SupportedOperations property is set
        internal bool IsSetSupportedOperations()
        {
            return this._supportedOperations != null && (this._supportedOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}