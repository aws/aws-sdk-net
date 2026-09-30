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
    /// The expiration configuration settings for records in a table, and the status of the
    /// configuration. If the status of the configuration is enabled, records expire and are
    /// automatically removed after the number of days specified in the record expiration
    /// settings for the table.
    /// </summary>
    public partial class TableRecordExpirationConfigurationValue
    {
        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The expiration settings for records in the table.
        /// </para>
        /// </summary>
        public TableRecordExpirationSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the expiration settings for records in the table.
        /// </para>
        /// </summary>
        public TableRecordExpirationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
