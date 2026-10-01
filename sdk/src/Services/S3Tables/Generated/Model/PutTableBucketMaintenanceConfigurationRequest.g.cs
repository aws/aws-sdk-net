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
    /// Container for the parameters to the PutTableBucketMaintenanceConfiguration operation.
    /// Creates a new maintenance configuration or replaces an existing maintenance configuration
    /// for a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
    /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3tables:PutTableBucketMaintenanceConfiguration</c>
    /// permission to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class PutTableBucketMaintenanceConfigurationRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket associated with the maintenance
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the maintenance configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableBucketMaintenanceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Defines the values of the maintenance configuration for the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableBucketMaintenanceConfigurationValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
