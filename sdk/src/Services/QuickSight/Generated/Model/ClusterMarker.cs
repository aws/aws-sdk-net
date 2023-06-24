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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The cluster marker that is a part of the cluster marker configuration.
    /// </summary>
    public partial class ClusterMarker
    {
        private SimpleClusterMarker _simpleClusterMarker;

        /// <summary>
        /// Gets and sets the property SimpleClusterMarker. 
        /// <para>
        /// The simple cluster marker of the cluster marker.
        /// </para>
        /// </summary>
        public SimpleClusterMarker SimpleClusterMarker
        {
            get { return this._simpleClusterMarker; }
            set { this._simpleClusterMarker = value; }
        }

        // Check to see if SimpleClusterMarker property is set
        internal bool IsSetSimpleClusterMarker()
        {
            return this._simpleClusterMarker != null;
        }

    }
}