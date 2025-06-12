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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The options to configure an upsert operation when writing to a Redshift target .
    /// </summary>
    public partial class UpsertRedshiftTargetOptions
    {
        private string _connectionName;
        private string _tableLocation;
        private List<string> _upsertKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to write to Redshift.
        /// </para>
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property TableLocation. 
        /// <para>
        /// The physical location of the Redshift table.
        /// </para>
        /// </summary>
        public string TableLocation
        {
            get { return this._tableLocation; }
            set { this._tableLocation = value; }
        }

        // Check to see if TableLocation property is set
        internal bool IsSetTableLocation()
        {
            return this._tableLocation != null;
        }

        /// <summary>
        /// Gets and sets the property UpsertKeys. 
        /// <para>
        /// The keys used to determine whether to perform an update or insert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UpsertKeys
        {
            get { return this._upsertKeys; }
            set { this._upsertKeys = value; }
        }

        // Check to see if UpsertKeys property is set
        internal bool IsSetUpsertKeys()
        {
            return this._upsertKeys != null && (this._upsertKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}