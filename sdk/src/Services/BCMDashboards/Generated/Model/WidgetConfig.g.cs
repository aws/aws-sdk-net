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

namespace Amazon.BCMDashboards.Model
{
    /// <summary>
    /// Defines the complete configuration for a widget, including data retrieval settings
    /// and visualization preferences.
    /// </summary>
    public partial class WidgetConfig
    {
        /// <summary>
        /// Gets and sets the property DisplayConfig. 
        /// <para>
        /// The configuration that determines how the retrieved data should be visualized in the
        /// widget.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DisplayConfig DisplayConfig { get; set; }

        /// <summary>
        /// Checks to see if the DisplayConfig property is set.
        /// </summary>
        internal bool IsSetDisplayConfig() => this.DisplayConfig != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        /// The parameters that define what data the widget should retrieve and how it should
        /// be filtered or grouped.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryParameters QueryParameters { get; set; }

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null;
    }
}
