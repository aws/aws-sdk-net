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
    /// Container for the parameters to the UpdateTable operation. Modifies the retention
    /// duration of the memory store and magnetic store for your Timestream table. Note that
    /// the change in retention duration takes effect immediately. For example, if the retention
    /// period of the memory store was initially set to 2 hours and then changed to 24 hours,
    /// the memory store will be capable of holding 24 hours of data, but will be populated
    /// with 24 hours of data 22 hours after this change was made. Timestream does not retrieve
    /// data from the magnetic store to populate the memory store. <para> See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.update-table.html">code
    /// sample</a> for details. </para>
    /// </summary>
    public partial class UpdateTableRequest : AmazonTimestreamWriteRequest
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

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
        /// The retention duration of the memory store and the magnetic store.
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
        [AWSProperty(Required = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
