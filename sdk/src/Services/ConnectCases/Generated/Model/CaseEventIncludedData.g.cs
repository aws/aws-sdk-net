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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Details of what case data is published through the case event stream. Use <c>fields</c>
    /// to include a specific list of fields, and use <c>autoIncludeFields</c> to automatically
    /// include a category of fields. When both are set, the effective field set is the union
    /// of the two.
    /// </summary>
    public partial class CaseEventIncludedData
    {
        /// <summary>
        /// Gets and sets the property AutoIncludeFields. 
        /// <para>
        /// Automatically include a category of fields in case event data, combined as a union
        /// with any fields specified in <c>fields</c>. Valid values are <c>All</c> (include all
        /// fields on the case), <c>System</c> (include all system fields), and <c>Custom</c>
        /// (include all custom fields). When this attribute is set, new fields added to the domain
        /// are picked up automatically without another call to PutCaseEventConfiguration. For
        /// the full behavior matrix and IAM requirements, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-event-streams.html">Case
        /// event streams in Connect Customer Cases</a> in the <i>Connect Customer Administrator
        /// Guide</i>.
        /// </para>
        /// </summary>
        public AutoIncludeFields AutoIncludeFields { get; set; }

        /// <summary>
        /// Checks to see if the AutoIncludeFields property is set.
        /// </summary>
        internal bool IsSetAutoIncludeFields() => this.AutoIncludeFields != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// List of field identifiers to include in case event data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 400)]
        public List<FieldIdentifier> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
