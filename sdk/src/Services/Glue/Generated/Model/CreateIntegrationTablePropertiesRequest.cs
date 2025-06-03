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
    /// Container for the parameters to the CreateIntegrationTableProperties operation.
    /// This API is used to provide optional override properties for the the tables that need
    /// to be replicated. These properties can include properties for filtering and partitioning
    /// for the source and target tables. To set both source and target properties the same
    /// API need to be invoked with the Glue connection ARN as <c>ResourceArn</c> with <c>SourceTableConfig</c>,
    /// and the Glue database ARN as <c>ResourceArn</c> with <c>TargetTableConfig</c> respectively.
    /// </summary>
    public partial class CreateIntegrationTablePropertiesRequest : AmazonGlueRequest
    {
        private string _resourceArn;
        private SourceTableConfig _sourceTableConfig;
        private string _tableName;
        private TargetTableConfig _targetTableConfig;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target table for which to create integration
        /// table properties. Currently, this API only supports creating integration table properties
        /// for target tables, and the provided ARN should be the ARN of the target table in the
        /// Glue Data Catalog. Support for creating integration table properties for source connections
        /// (using the connection ARN) is not yet implemented and will be added in a future release.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTableConfig. 
        /// <para>
        /// A structure for the source table configuration. See the <c>SourceTableConfig</c> structure
        /// to see list of supported source properties.
        /// </para>
        /// </summary>
        public SourceTableConfig SourceTableConfig
        {
            get { return this._sourceTableConfig; }
            set { this._sourceTableConfig = value; }
        }

        // Check to see if SourceTableConfig property is set
        internal bool IsSetSourceTableConfig()
        {
            return this._sourceTableConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to be replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property TargetTableConfig. 
        /// <para>
        /// A structure for the target table configuration.
        /// </para>
        /// </summary>
        public TargetTableConfig TargetTableConfig
        {
            get { return this._targetTableConfig; }
            set { this._targetTableConfig = value; }
        }

        // Check to see if TargetTableConfig property is set
        internal bool IsSetTargetTableConfig()
        {
            return this._targetTableConfig != null;
        }

    }
}