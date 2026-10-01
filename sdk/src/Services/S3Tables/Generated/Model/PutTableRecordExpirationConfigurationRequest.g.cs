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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the PutTableRecordExpirationConfiguration operation.
    /// Creates or updates the expiration configuration settings for records in a table, including
    /// the status of the configuration. If you enable record expiration for a table, records
    /// expire and are automatically removed from the table after the number of days that
    /// you specify. <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3tables:PutTableRecordExpirationConfiguration</c>
    /// permission to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class PutTableRecordExpirationConfigurationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The record expiration configuration to apply to the table, including the status (<c>enabled</c>
        /// or <c>disabled</c>) and retention period in days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableRecordExpirationConfigurationValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
