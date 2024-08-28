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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListLayerVersions operation.
    /// Lists the versions of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>. Versions that have been deleted aren't listed. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
    /// identifier</a> to list only versions that indicate that they're compatible with that
    /// runtime. Specify a compatible architecture to include only layer versions that are
    /// compatible with that architecture.
    /// </summary>
    public partial class ListLayerVersionsRequest : AmazonLambdaRequest
    {
        private Architecture _compatibleArchitecture;
        private Runtime _compatibleRuntime;
        private string _layerName;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property CompatibleArchitecture. 
        /// <para>
        /// The compatible <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architecture</a>.
        /// </para>
        /// </summary>
        public Architecture CompatibleArchitecture
        {
            get { return this._compatibleArchitecture; }
            set { this._compatibleArchitecture = value; }
        }

        // Check to see if CompatibleArchitecture property is set
        internal bool IsSetCompatibleArchitecture()
        {
            return this._compatibleArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property CompatibleRuntime. 
        /// <para>
        /// A runtime identifier.
        /// </para>
        ///  
        /// <para>
        /// The following list includes deprecated runtimes. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-deprecation-levels">Runtime
        /// use after deprecation</a>.
        /// </para>
        ///  
        /// <para>
        /// For a list of all currently supported runtimes, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtimes-supported">Supported
        /// runtimes</a>.
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
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string LayerName
        {
            get { return this._layerName; }
            set { this._layerName = value; }
        }

        // Check to see if LayerName property is set
        internal bool IsSetLayerName()
        {
            return this._layerName != null;
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
        /// The maximum number of versions to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}