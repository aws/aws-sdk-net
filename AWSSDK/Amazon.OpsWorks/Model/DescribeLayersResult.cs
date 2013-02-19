/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeLayers</c> request.</para>
    /// </summary>
    public class DescribeLayersResult
    {
        
        private List<Layer> layers = new List<Layer>();

        /// <summary>
        /// An array of <c>Layer</c> objects that describe the layers.
        ///  
        /// </summary>
        public List<Layer> Layers
        {
            get { return this.layers; }
            set { this.layers = value; }
        }
        /// <summary>
        /// Adds elements to the Layers collection
        /// </summary>
        /// <param name="layers">The values to add to the Layers collection </param>
        /// <returns>this instance</returns>
        public DescribeLayersResult WithLayers(params Layer[] layers)
        {
            foreach (Layer element in layers)
            {
                this.layers.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Layers collection
        /// </summary>
        /// <param name="layers">The values to add to the Layers collection </param>
        /// <returns>this instance</returns>
        public DescribeLayersResult WithLayers(IEnumerable<Layer> layers)
        {
            foreach (Layer element in layers)
            {
                this.layers.Add(element);
            }

            return this;
        }

        // Check to see if Layers property is set
        internal bool IsSetLayers()
        {
            return this.layers.Count > 0;
        }
    }
}
