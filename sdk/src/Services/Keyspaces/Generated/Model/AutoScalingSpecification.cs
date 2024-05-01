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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The optional auto scaling capacity settings for a table in provisioned capacity mode.
    /// </summary>
    public partial class AutoScalingSpecification
    {
        private AutoScalingSettings _readCapacityAutoScaling;
        private AutoScalingSettings _writeCapacityAutoScaling;

        /// <summary>
        /// Gets and sets the property ReadCapacityAutoScaling. 
        /// <para>
        /// The auto scaling settings for the table's read capacity.
        /// </para>
        /// </summary>
        public AutoScalingSettings ReadCapacityAutoScaling
        {
            get { return this._readCapacityAutoScaling; }
            set { this._readCapacityAutoScaling = value; }
        }

        // Check to see if ReadCapacityAutoScaling property is set
        internal bool IsSetReadCapacityAutoScaling()
        {
            return this._readCapacityAutoScaling != null;
        }

        /// <summary>
        /// Gets and sets the property WriteCapacityAutoScaling. 
        /// <para>
        /// The auto scaling settings for the table's write capacity.
        /// </para>
        /// </summary>
        public AutoScalingSettings WriteCapacityAutoScaling
        {
            get { return this._writeCapacityAutoScaling; }
            set { this._writeCapacityAutoScaling = value; }
        }

        // Check to see if WriteCapacityAutoScaling property is set
        internal bool IsSetWriteCapacityAutoScaling()
        {
            return this._writeCapacityAutoScaling != null;
        }

    }
}