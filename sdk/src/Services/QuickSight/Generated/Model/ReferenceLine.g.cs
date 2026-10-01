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
    /// The reference line visual display options.
    /// </summary>
    public partial class ReferenceLine
    {
        /// <summary>
        /// Gets and sets the property DataConfiguration. 
        /// <para>
        /// The data configuration of the reference line.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReferenceLineDataConfiguration DataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataConfiguration property is set.
        /// </summary>
        internal bool IsSetDataConfiguration() => this.DataConfiguration != null;

        /// <summary>
        /// Gets and sets the property LabelConfiguration. 
        /// <para>
        /// The label configuration of the reference line.
        /// </para>
        /// </summary>
        public ReferenceLineLabelConfiguration LabelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelConfiguration() => this.LabelConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the reference line. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WidgetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StyleConfiguration. 
        /// <para>
        /// The style configuration of the reference line.
        /// </para>
        /// </summary>
        public ReferenceLineStyleConfiguration StyleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StyleConfiguration property is set.
        /// </summary>
        internal bool IsSetStyleConfiguration() => this.StyleConfiguration != null;
    }
}
