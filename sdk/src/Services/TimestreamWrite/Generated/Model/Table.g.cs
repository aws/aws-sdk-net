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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents a database table in Timestream. Tables contain one or more related time
    /// series. You can modify the retention duration of the memory store and the magnetic
    /// store for a table.
    /// </summary>
    public partial class Table
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name that uniquely identifies this table.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the Timestream table was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Timestream database that contains this table.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Timestream table was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MagneticStoreWriteProperties. 
        /// <para>
        /// Contains properties to set on the table when enabling magnetic store writes.
        /// </para>
        /// </summary>
        public MagneticStoreWriteProperties MagneticStoreWriteProperties { get; set; }

        /// <summary>
        /// Checks to see if the MagneticStoreWriteProperties property is set.
        /// </summary>
        internal bool IsSetMagneticStoreWriteProperties() => this.MagneticStoreWriteProperties != null;

        /// <summary>
        /// Gets and sets the property RetentionProperties. 
        /// <para>
        /// The retention duration for the memory store and magnetic store.
        /// </para>
        /// </summary>
        public RetentionProperties RetentionProperties { get; set; }

        /// <summary>
        /// Checks to see if the RetentionProperties property is set.
        /// </summary>
        internal bool IsSetRetentionProperties() => this.RetentionProperties != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        ///  The schema of the table. 
        /// </para>
        /// </summary>
        public Schema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the Timestream table.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableStatus. 
        /// <para>
        /// The current state of the table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETING</c> - The table is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The table is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TableStatus TableStatus { get; set; }

        /// <summary>
        /// Checks to see if the TableStatus property is set.
        /// </summary>
        internal bool IsSetTableStatus() => this.TableStatus != null;
    }
}
