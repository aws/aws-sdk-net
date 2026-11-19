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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the prefix-level configuration that determines the prefixes for which
    /// S3 Storage Lens publishes cost data to Amazon Web Services Cost and Usage Reports
    /// (Amazon Web Services CUR).
    /// </summary>
    public partial class StorageLensCostAndUsageReportsPrefixLevel
    {
        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether prefix-level cost data publishing to Amazon Web Services CUR is
        /// enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SelectionCriteria. 
        /// <para>
        /// A container for the selection criteria that determines the prefix depths for which
        /// cost data is published to Amazon Web Services CUR.
        /// </para>
        /// </summary>
        public StorageLensCostAndUsageReportsSelectionCriteria SelectionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SelectionCriteria property is set.
        /// </summary>
        internal bool IsSetSelectionCriteria() => this.SelectionCriteria != null;
    }
}
