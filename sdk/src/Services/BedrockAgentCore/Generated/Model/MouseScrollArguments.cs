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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Arguments for a mouse scroll action.
    /// </summary>
    public partial class MouseScrollArguments
    {
        private int? _deltax;
        private int? _deltay;
        private int? _x;
        private int? _y;

        /// <summary>
        /// Gets and sets the property DeltaX. 
        /// <para>
        /// The horizontal scroll delta. Valid range: -1000 to 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1000, Max=1000)]
        public int? DeltaX
        {
            get { return this._deltax; }
            set { this._deltax = value; }
        }

        // Check to see if DeltaX property is set
        internal bool IsSetDeltaX()
        {
            return this._deltax.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeltaY. 
        /// <para>
        /// The vertical scroll delta. Valid range: -1000 to 1000. Negative values scroll down.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1000, Max=1000)]
        public int? DeltaY
        {
            get { return this._deltay; }
            set { this._deltay = value; }
        }

        // Check to see if DeltaY property is set
        internal bool IsSetDeltaY()
        {
            return this._deltay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The X coordinate on screen where the scroll occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        // Check to see if X property is set
        internal bool IsSetX()
        {
            return this._x.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The Y coordinate on screen where the scroll occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        // Check to see if Y property is set
        internal bool IsSetY()
        {
            return this._y.HasValue; 
        }

    }
}