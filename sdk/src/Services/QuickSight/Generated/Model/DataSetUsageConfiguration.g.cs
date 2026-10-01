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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The usage configuration to apply to child datasets that reference this dataset as
    /// a source.
    /// </summary>
    public partial class DataSetUsageConfiguration
    {
        /// <summary>
        /// Gets and sets the property DisableUseAsDirectQuerySource. 
        /// <para>
        /// An option that controls whether a child dataset of a direct query can use this dataset
        /// as a source.
        /// </para>
        /// </summary>
        public bool? DisableUseAsDirectQuerySource { get; set; }

        /// <summary>
        /// Checks to see if the DisableUseAsDirectQuerySource property is set.
        /// </summary>
        internal bool IsSetDisableUseAsDirectQuerySource() => this.DisableUseAsDirectQuerySource.HasValue;

        /// <summary>
        /// Gets and sets the property DisableUseAsImportedSource. 
        /// <para>
        /// An option that controls whether a child dataset that's stored in Quick Sight can use
        /// this dataset as a source.
        /// </para>
        /// </summary>
        public bool? DisableUseAsImportedSource { get; set; }

        /// <summary>
        /// Checks to see if the DisableUseAsImportedSource property is set.
        /// </summary>
        internal bool IsSetDisableUseAsImportedSource() => this.DisableUseAsImportedSource.HasValue;
    }
}
