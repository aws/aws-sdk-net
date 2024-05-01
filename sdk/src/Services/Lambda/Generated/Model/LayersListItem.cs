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
    /// Details about an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>.
    /// </summary>
    public partial class LayersListItem
    {
        private LayerVersionsListItem _latestMatchingVersion;
        private string _layerArn;
        private string _layerName;

        /// <summary>
        /// Gets and sets the property LatestMatchingVersion. 
        /// <para>
        /// The newest version of the layer.
        /// </para>
        /// </summary>
        public LayerVersionsListItem LatestMatchingVersion
        {
            get { return this._latestMatchingVersion; }
            set { this._latestMatchingVersion = value; }
        }

        // Check to see if LatestMatchingVersion property is set
        internal bool IsSetLatestMatchingVersion()
        {
            return this._latestMatchingVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LayerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
        public string LayerArn
        {
            get { return this._layerArn; }
            set { this._layerArn = value; }
        }

        // Check to see if LayerArn property is set
        internal bool IsSetLayerArn()
        {
            return this._layerArn != null;
        }

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name of the layer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=140)]
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

    }
}