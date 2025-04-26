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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Defines what initiates a highlight operation on a visual, such as a click or hover.
    /// </summary>
    public partial class VisualHighlightOperation
    {
        private VisualHighlightTrigger _trigger;

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// Specifies whether a highlight operation is initiated by a click or hover, or whether
        /// it's disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisualHighlightTrigger Trigger
        {
            get { return this._trigger; }
            set { this._trigger = value; }
        }

        // Check to see if Trigger property is set
        internal bool IsSetTrigger()
        {
            return this._trigger != null;
        }

    }
}