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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The schema details of the dataset. Note that for AWS Supply Chain dataset under <b>asc</b>
    /// namespace, it may have internal fields like connection_id that will be auto populated
    /// by data ingestion methods.
    /// </summary>
    public partial class DataLakeDatasetSchema
    {
        private List<DataLakeDatasetSchemaField> _fields = AWSConfigs.InitializeCollections ? new List<DataLakeDatasetSchemaField>() : null;
        private string _name;
        private List<DataLakeDatasetPrimaryKeyField> _primaryKeys = AWSConfigs.InitializeCollections ? new List<DataLakeDatasetPrimaryKeyField>() : null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of field details of the dataset schema.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<DataLakeDatasetSchemaField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the dataset schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryKeys. 
        /// <para>
        /// The list of primary key fields for the dataset. Primary keys defined can help data
        /// ingestion methods to ensure data uniqueness: CreateDataIntegrationFlow's dedupe strategy
        /// will leverage primary keys to perform records deduplication before write to dataset;
        /// SendDataIntegrationEvent's UPSERT and DELETE can only work with dataset with primary
        /// keys. For more details, refer to those data ingestion documentations.
        /// </para>
        ///  
        /// <para>
        /// Note that defining primary keys does not necessarily mean the dataset cannot have
        /// duplicate records, duplicate records can still be ingested if CreateDataIntegrationFlow's
        /// dedupe disabled or through SendDataIntegrationEvent's APPEND operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<DataLakeDatasetPrimaryKeyField> PrimaryKeys
        {
            get { return this._primaryKeys; }
            set { this._primaryKeys = value; }
        }

        // Check to see if PrimaryKeys property is set
        internal bool IsSetPrimaryKeys()
        {
            return this._primaryKeys != null && (this._primaryKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}