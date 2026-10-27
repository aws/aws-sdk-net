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
    /// Details about an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>.
    /// </summary>
    public partial class LayersListItem
    {
        /// <summary>
        /// Gets and sets the property LatestMatchingVersion. 
        /// <para>
        /// The newest version of the layer.
        /// </para>
        /// </summary>
        public LayerVersionsListItem LatestMatchingVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestMatchingVersion property is set.
        /// </summary>
        internal bool IsSetLatestMatchingVersion() => this.LatestMatchingVersion != null;

        /// <summary>
        /// Gets and sets the property LayerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LayerArn { get; set; }

        /// <summary>
        /// Checks to see if the LayerArn property is set.
        /// </summary>
        internal bool IsSetLayerArn() => this.LayerArn != null;

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string LayerName { get; set; }

        /// <summary>
        /// Checks to see if the LayerName property is set.
        /// </summary>
        internal bool IsSetLayerName() => this.LayerName != null;
    }
}
