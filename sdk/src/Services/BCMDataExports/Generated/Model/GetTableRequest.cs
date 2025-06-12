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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Container for the parameters to the GetTable operation.
    /// Returns the metadata for the specified table and table properties. This includes the
    /// list of columns in the table schema, their data types, and column descriptions.
    /// </summary>
    public partial class GetTableRequest : AmazonBCMDataExportsRequest
    {
        private string _tableName;
        private Dictionary<string, string> _tableProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableProperties. 
        /// <para>
        /// TableProperties are additional configurations you can provide to change the data and
        /// schema of a table. Each table can have different TableProperties. Tables are not required
        /// to have any TableProperties. Each table property has a default value that it assumes
        /// if not specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TableProperties
        {
            get { return this._tableProperties; }
            set { this._tableProperties = value; }
        }

        // Check to see if TableProperties property is set
        internal bool IsSetTableProperties()
        {
            return this._tableProperties != null && (this._tableProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}