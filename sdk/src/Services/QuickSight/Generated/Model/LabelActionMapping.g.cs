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
    /// Maps a sensitivity label from Microsoft Purview to an enforcement action.
    /// </summary>
    public partial class LabelActionMapping
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The enforcement action to apply when content with this sensitivity label is detected.
        /// Valid values are <c>ALLOW</c>, <c>BLOCK</c>, and <c>WARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DlpAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property LabelId. 
        /// <para>
        /// The identifier of the sensitivity label from the DLP provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string LabelId { get; set; }

        /// <summary>
        /// Checks to see if the LabelId property is set.
        /// </summary>
        internal bool IsSetLabelId() => this.LabelId != null;

        /// <summary>
        /// Gets and sets the property LabelName. 
        /// <para>
        /// The display name of the sensitivity label from the DLP provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string LabelName { get; set; }

        /// <summary>
        /// Checks to see if the LabelName property is set.
        /// </summary>
        internal bool IsSetLabelName() => this.LabelName != null;
    }
}
