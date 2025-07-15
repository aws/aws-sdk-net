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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The inventory table configuration for an S3 Metadata configuration.
    /// </summary>
    public partial class InventoryTableConfigurationResult
    {
        private InventoryConfigurationState _configurationState;
        private ErrorDetails _error;
        private string _tableArn;
        private string _tableName;
        private string _tableStatus;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        ///  The configuration state of the inventory table, indicating whether the inventory table is enabled or disabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryConfigurationState ConfigurationState
        {
            get { return this._configurationState; }
            set { this._configurationState = value; }
        }

        // Check to see if ConfigurationState property is set
        internal bool IsSetConfigurationState()
        {
            return this._configurationState != null;
        }

        /// <summary>
        /// Gets and sets the property Error.
        /// </summary>
        public ErrorDetails Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the inventory table. 
        /// </para>
        /// </summary>
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name of the inventory table. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TableStatus. 
        /// <para>
        ///  The status of the inventory table. The status values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The inventory table is in the process of being created in the
        /// specified Amazon Web Services managed table bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BACKFILLING</c> - The inventory table is in the process of being backfilled.
        /// When you enable the inventory table for your metadata configuration, the table goes
        /// through a process known as backfilling, during which Amazon S3 scans your general
        /// purpose bucket to retrieve the initial metadata for all objects in the bucket. Depending
        /// on the number of objects in your bucket, this process can take several hours. When
        /// the backfilling process is finished, the status of your inventory table changes from
        /// <c>BACKFILLING</c> to <c>ACTIVE</c>. After backfilling is completed, updates to your
        /// objects are reflected in the inventory table within one hour.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The inventory table has been created successfully, and records are
        /// being delivered to the table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon S3 is unable to create the inventory table, or Amazon S3
        /// is unable to deliver records.
        /// </para>
        ///  </li> </ul> 
        /// </summary>
        public string TableStatus
        {
            get { return this._tableStatus; }
            set { this._tableStatus = value; }
        }

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this._tableStatus != null;
        }

    }
}