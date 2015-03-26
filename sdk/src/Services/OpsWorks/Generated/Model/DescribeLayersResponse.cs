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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeLayers</code> request.
    /// </summary>
    public partial class DescribeLayersResponse : AmazonWebServiceResponse
    {
        private List<Layer> _layers = new List<Layer>();

        /// <summary>
        /// Gets and sets the property Layers. 
        /// <para>
        /// An array of <code>Layer</code> objects that describe the layers.
        /// </para>
        /// </summary>
        public List<Layer> Layers
        {
            get { return this._layers; }
            set { this._layers = value; }
        }

        // Check to see if Layers property is set
        internal bool IsSetLayers()
        {
            return this._layers != null && this._layers.Count > 0; 
        }

    }
}