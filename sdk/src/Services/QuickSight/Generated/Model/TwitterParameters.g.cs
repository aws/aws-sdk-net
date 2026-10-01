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
    /// The parameters for Twitter.
    /// </summary>
    public partial class TwitterParameters
    {
        /// <summary>
        /// Gets and sets the property MaxRows. 
        /// <para>
        /// Maximum number of rows to query Twitter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MaxRows { get; set; }

        /// <summary>
        /// Checks to see if the MaxRows property is set.
        /// </summary>
        internal bool IsSetMaxRows() => this.MaxRows.HasValue;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// Twitter query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;
    }
}
