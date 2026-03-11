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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
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
    /// Defines the visual representation settings for widget data, including the visualization
    /// type, styling options, and display preferences for different metric types.
    /// </summary>
    public partial class GraphDisplayConfig
    {
        private VisualType _visualType;

        /// <summary>
        /// Gets and sets the property VisualType. 
        /// <para>
        /// The type of visualization to use for the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisualType VisualType
        {
            get { return this._visualType; }
            set { this._visualType = value; }
        }

        // Check to see if VisualType property is set
        internal bool IsSetVisualType()
        {
            return this._visualType != null;
        }

    }
}