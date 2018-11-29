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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing a target and its relative weight. Traffic is distributed across
    ///         targets according to their relative weight. For example, a weighted target
    /// with a relative         weight of 50 receives five times as much traffic as one with
    /// a relative weight of         10.
    /// </summary>
    public partial class WeightedTarget
    {
        private string _virtualNode;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property VirtualNode. 
        /// <para>
        /// The virtual node to associate with the weighted target.
        /// </para>
        /// </summary>
        public string VirtualNode
        {
            get { return this._virtualNode; }
            set { this._virtualNode = value; }
        }

        // Check to see if VirtualNode property is set
        internal bool IsSetVirtualNode()
        {
            return this._virtualNode != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The relative weight of the weighted target.
        /// </para>
        /// </summary>
        public int Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}