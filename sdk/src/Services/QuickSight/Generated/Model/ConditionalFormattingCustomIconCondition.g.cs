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
    /// Determines the custom condition for an icon set.
    /// </summary>
    public partial class ConditionalFormattingCustomIconCondition
    {
        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// Determines the color of the icon.
        /// </para>
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property DisplayConfiguration. 
        /// <para>
        /// Determines the icon display configuration.
        /// </para>
        /// </summary>
        public ConditionalFormattingIconDisplayConfiguration DisplayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DisplayConfiguration property is set.
        /// </summary>
        internal bool IsSetDisplayConfiguration() => this.DisplayConfiguration != null;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that determines the condition of the icon set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property IconOptions. 
        /// <para>
        /// Custom icon options for an icon set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConditionalFormattingCustomIconOptions IconOptions { get; set; }

        /// <summary>
        /// Checks to see if the IconOptions property is set.
        /// </summary>
        internal bool IsSetIconOptions() => this.IconOptions != null;
    }
}
