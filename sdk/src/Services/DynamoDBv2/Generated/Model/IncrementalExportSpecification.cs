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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Optional object containing the parameters specific to an incremental export.
    /// </summary>
    public partial class IncrementalExportSpecification
    {
        private DateTime? _exportFromTime;
        private DateTime? _exportToTime;
        private ExportViewType _exportViewType;

        /// <summary>
        /// Gets and sets the property ExportFromTime. 
        /// <para>
        /// Time in the past which provides the inclusive start range for the export table's data,
        /// counted in seconds from the start of the Unix epoch. The incremental export will reflect
        /// the table's state including and after this point in time.
        /// </para>
        /// </summary>
        public DateTime? ExportFromTime
        {
            get { return this._exportFromTime; }
            set { this._exportFromTime = value; }
        }

        // Check to see if ExportFromTime property is set
        internal bool IsSetExportFromTime()
        {
            return this._exportFromTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportToTime. 
        /// <para>
        /// Time in the past which provides the exclusive end range for the export table's data,
        /// counted in seconds from the start of the Unix epoch. The incremental export will reflect
        /// the table's state just prior to this point in time. If this is not provided, the latest
        /// time with data available will be used.
        /// </para>
        /// </summary>
        public DateTime? ExportToTime
        {
            get { return this._exportToTime; }
            set { this._exportToTime = value; }
        }

        // Check to see if ExportToTime property is set
        internal bool IsSetExportToTime()
        {
            return this._exportToTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportViewType. 
        /// <para>
        /// The view type that was chosen for the export. Valid values are <c>NEW_AND_OLD_IMAGES</c>
        /// and <c>NEW_IMAGES</c>. The default value is <c>NEW_AND_OLD_IMAGES</c>.
        /// </para>
        /// </summary>
        public ExportViewType ExportViewType
        {
            get { return this._exportViewType; }
            set { this._exportViewType = value; }
        }

        // Check to see if ExportViewType property is set
        internal bool IsSetExportViewType()
        {
            return this._exportViewType != null;
        }

    }
}