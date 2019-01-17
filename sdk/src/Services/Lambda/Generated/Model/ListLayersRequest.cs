/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListLayers operation.
    /// Lists <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
    /// Lambda layers</a> and shows information about the latest version of each. Specify
    /// a <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
    /// identifier</a> to list only layers that indicate that they're compatible with that
    /// runtime.
    /// </summary>
    public partial class ListLayersRequest : AmazonLambdaRequest
    {
        private Runtime _compatibleRuntime;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property CompatibleRuntime. 
        /// <para>
        /// A runtime identifier. For example, <code>go1.x</code>.
        /// </para>
        /// </summary>
        public Runtime CompatibleRuntime
        {
            get { return this._compatibleRuntime; }
            set { this._compatibleRuntime = value; }
        }

        // Check to see if CompatibleRuntime property is set
        internal bool IsSetCompatibleRuntime()
        {
            return this._compatibleRuntime != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token returned by a previous call.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of layers to return.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}