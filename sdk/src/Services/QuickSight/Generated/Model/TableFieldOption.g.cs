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
    /// The options for a table field.
    /// </summary>
    public partial class TableFieldOption
    {
        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The custom label for a table field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomLabel { get; set; }

        /// <summary>
        /// Checks to see if the CustomLabel property is set.
        /// </summary>
        internal bool IsSetCustomLabel() => this.CustomLabel != null;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID for a table field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property URLStyling. 
        /// <para>
        /// The URL configuration for a table field.
        /// </para>
        /// </summary>
        public TableFieldURLConfiguration URLStyling { get; set; }

        /// <summary>
        /// Checks to see if the URLStyling property is set.
        /// </summary>
        internal bool IsSetURLStyling() => this.URLStyling != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of a table field.
        /// </para>
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width for a table field.
        /// </para>
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width != null;
    }
}
