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
    /// The messages that are displayed on a visual under specific conditions, such as when
    /// the visual returns no data.
    /// </summary>
    public partial class VisualMessages
    {
        /// <summary>
        /// Gets and sets the property NoDataMessage. 
        /// <para>
        /// The message that is displayed on a visual when there is no data to display.
        /// </para>
        /// </summary>
        public VisualMessageConfiguration NoDataMessage { get; set; }

        /// <summary>
        /// Checks to see if the NoDataMessage property is set.
        /// </summary>
        internal bool IsSetNoDataMessage() => this.NoDataMessage != null;
    }
}
