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
    /// A container for the selection criteria used by the S3 Storage Lens Amazon Web Services
    /// Cost and Usage Reports (Amazon Web Services CUR) publish configuration. The selection
    /// criteria specifies the minimum and maximum prefix depth (both inclusive) for which
    /// cost data is published to Amazon Web Services CUR. You must provide both <c>MinDepth</c>
    /// and <c>MaxDepth</c> together, or neither; <c>MinDepth</c> must be less than or equal
    /// to <c>MaxDepth</c>, and the difference must not exceed 4. If neither is provided,
    /// <c>MinDepth</c> defaults to <c>1</c> and <c>MaxDepth</c> defaults to <c>3</c>.
    /// </summary>
    public partial class StorageLensCostAndUsageReportsSelectionCriteria
    {
        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        /// The maximum prefix depth (inclusive) for which cost data is published to Amazon Web
        /// Services CUR. You must provide both <c>MinDepth</c> and <c>MaxDepth</c> together,
        /// or neither. If neither is provided, <c>MaxDepth</c> defaults to <c>3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxDepth property is set.
        /// </summary>
        internal bool IsSetMaxDepth() => this.MaxDepth.HasValue;

        /// <summary>
        /// Gets and sets the property MinDepth. 
        /// <para>
        /// The minimum prefix depth (inclusive) for which cost data is published to Amazon Web
        /// Services CUR. You must provide both <c>MinDepth</c> and <c>MaxDepth</c> together,
        /// or neither. If neither is provided, <c>MinDepth</c> defaults to <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public int? MinDepth { get; set; }

        /// <summary>
        /// Checks to see if the MinDepth property is set.
        /// </summary>
        internal bool IsSetMinDepth() => this.MinDepth.HasValue;
    }
}
