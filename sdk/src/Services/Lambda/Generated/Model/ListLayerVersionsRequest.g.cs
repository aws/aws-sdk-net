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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListLayerVersions operation. Lists the versions
    /// of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>. Versions that have been deleted aren't listed. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
    /// identifier</a> to list only versions that indicate that they're compatible with that
    /// runtime. Specify a compatible architecture to include only layer versions that are
    /// compatible with that architecture.
    /// </summary>
    public partial class ListLayerVersionsRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CompatibleArchitecture. 
        /// <para>
        /// The compatible <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architecture</a>.
        /// </para>
        /// </summary>
        public Architecture CompatibleArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the CompatibleArchitecture property is set.
        /// </summary>
        internal bool IsSetCompatibleArchitecture() => this.CompatibleArchitecture != null;

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
        public Runtime CompatibleRuntime { get; set; }

        /// <summary>
        /// Checks to see if the CompatibleRuntime property is set.
        /// </summary>
        internal bool IsSetCompatibleRuntime() => this.CompatibleRuntime != null;

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string LayerName { get; set; }

        /// <summary>
        /// Checks to see if the LayerName property is set.
        /// </summary>
        internal bool IsSetLayerName() => this.LayerName != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A pagination token returned by a previous call.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of versions to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;
    }
}
