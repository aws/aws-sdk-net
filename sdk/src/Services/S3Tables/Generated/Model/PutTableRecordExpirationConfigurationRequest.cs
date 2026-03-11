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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the PutTableRecordExpirationConfiguration operation.
    /// Creates or updates the expiration configuration settings for records in a table, including
    /// the status of the configuration. If you enable record expiration for a table, records
    /// expire and are automatically removed from the table after the number of days that
    /// you specify.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:PutTableRecordExpirationConfiguration</c> permission
    /// to use this operation.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class PutTableRecordExpirationConfigurationRequest : AmazonS3TablesRequest
    {
        private string _tableArn;
        private TableRecordExpirationConfigurationValue _value;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The record expiration configuration to apply to the table, including the status (<c>enabled</c>
        /// or <c>disabled</c>) and retention period in days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableRecordExpirationConfigurationValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}