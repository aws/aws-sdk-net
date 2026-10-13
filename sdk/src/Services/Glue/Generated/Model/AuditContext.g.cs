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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing the Lake Formation audit context.
    /// </summary>
    public partial class AuditContext
    {
        /// <summary>
        /// Gets and sets the property AdditionalAuditContext. 
        /// <para>
        /// A string containing the additional audit context information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AdditionalAuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAuditContext property is set.
        /// </summary>
        internal bool IsSetAdditionalAuditContext() => this.AdditionalAuditContext != null;

        /// <summary>
        /// Gets and sets the property AllColumnsRequested. 
        /// <para>
        /// All columns request for audit.
        /// </para>
        /// </summary>
        public bool? AllColumnsRequested { get; set; }

        /// <summary>
        /// Checks to see if the AllColumnsRequested property is set.
        /// </summary>
        internal bool IsSetAllColumnsRequested() => this.AllColumnsRequested.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedColumns. 
        /// <para>
        /// The requested columns for audit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedColumns property is set.
        /// </summary>
        internal bool IsSetRequestedColumns() => this.RequestedColumns != null && (this.RequestedColumns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
