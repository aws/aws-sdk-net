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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains storage metrics for the Neptune undo logs, including the total size in bytes
    /// and the number of entries in the undo log list.
    /// </summary>
    public partial class UndoLogsMetrics
    {
        /// <summary>
        /// Gets and sets the property ListSize. 
        /// <para>
        /// The number of entries in the undo log list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ListSize { get; set; }

        /// <summary>
        /// Checks to see if the ListSize property is set.
        /// </summary>
        internal bool IsSetListSize() => this.ListSize.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The total size of the undo logs in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;
    }
}
