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
    /// The target dataset details for a DATASET event type.
    /// </summary>
    public partial class DataIntegrationEventDatasetTargetDetails
    {
        private string _datasetIdentifier;
        private DataIntegrationEventDatasetLoadExecutionDetails _datasetLoadExecution;
        private DataIntegrationEventDatasetOperationType _operationType;

        /// <summary>
        /// Gets and sets the property DatasetIdentifier. 
        /// <para>
        /// The datalake dataset ARN identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string DatasetIdentifier
        {
            get { return this._datasetIdentifier; }
            set { this._datasetIdentifier = value; }
        }

        // Check to see if DatasetIdentifier property is set
        internal bool IsSetDatasetIdentifier()
        {
            return this._datasetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetLoadExecution. 
        /// <para>
        /// The target dataset load execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationEventDatasetLoadExecutionDetails DatasetLoadExecution
        {
            get { return this._datasetLoadExecution; }
            set { this._datasetLoadExecution = value; }
        }

        // Check to see if DatasetLoadExecution property is set
        internal bool IsSetDatasetLoadExecution()
        {
            return this._datasetLoadExecution != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The target dataset load operation type. The available options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>APPEND</b> - Add new records to the dataset. Noted that this operation type will
        /// just try to append records as-is without any primary key or partition constraints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPSERT</b> - Modify existing records in the dataset with primary key configured,
        /// events for datasets without primary keys are not allowed. If event data contains primary
        /// keys that match records in the dataset within same partition, then those existing
        /// records (in that partition) will be updated. If primary keys do not match, new records
        /// will be added. Note that if dataset contain records with duplicate primary key values
        /// in the same partition, those duplicate records will be deduped into one updated record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETE</b> - Remove existing records in the dataset with primary key configured,
        /// events for datasets without primary keys are not allowed. If event data contains primary
        /// keys that match records in the dataset within same partition, then those existing
        /// records (in that partition) will be deleted. If primary keys do not match, no actions
        /// will be done. Note that if dataset contain records with duplicate primary key values
        /// in the same partition, all those duplicates will be removed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationEventDatasetOperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

    }
}