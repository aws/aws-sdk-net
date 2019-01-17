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
    /// Container for the parameters to the GetLayerVersionPolicy operation.
    /// Returns the permission policy for a version of an <a href="http://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">AWS
    /// Lambda layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
    /// </summary>
    public partial class GetLayerVersionPolicyRequest : AmazonLambdaRequest
    {
        private string _layerName;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property LayerName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the layer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}