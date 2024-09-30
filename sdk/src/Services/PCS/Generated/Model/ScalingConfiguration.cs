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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// Specifies the boundaries of the compute node group auto scaling.
    /// </summary>
    public partial class ScalingConfiguration
    {
        private int? _maxInstanceCount;
        private int? _minInstanceCount;

        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The upper bound of the number of instances allowed in the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? MaxInstanceCount
        {
            get { return this._maxInstanceCount; }
            set { this._maxInstanceCount = value; }
        }

        // Check to see if MaxInstanceCount property is set
        internal bool IsSetMaxInstanceCount()
        {
            return this._maxInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinInstanceCount. 
        /// <para>
        /// The lower bound of the number of instances allowed in the compute fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? MinInstanceCount
        {
            get { return this._minInstanceCount; }
            set { this._minInstanceCount = value; }
        }

        // Check to see if MinInstanceCount property is set
        internal bool IsSetMinInstanceCount()
        {
            return this._minInstanceCount.HasValue; 
        }

    }
}