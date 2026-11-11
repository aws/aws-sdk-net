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
    /// </summary>
    public partial class SelectionCriteria
    {
        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A container for the delimiter of the selection criteria being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        /// The max depth of the selection criteria
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxDepth property is set.
        /// </summary>
        internal bool IsSetMaxDepth() => this.MaxDepth.HasValue;

        /// <summary>
        /// Gets and sets the property MinStorageBytesPercentage. 
        /// <para>
        /// The minimum percentage of total bucket storage that a prefix must hold for its metrics
        /// to be included.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public double? MinStorageBytesPercentage { get; set; }

        /// <summary>
        /// Checks to see if the MinStorageBytesPercentage property is set.
        /// </summary>
        internal bool IsSetMinStorageBytesPercentage() => this.MinStorageBytesPercentage.HasValue;
    }
}
