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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of adding parameters in action.
    /// </summary>
    public partial class SetParameterValueConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationParameterName. 
        /// <para>
        /// The destination parameter name of the <c>SetParameterValueConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DestinationParameterName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationParameterName property is set.
        /// </summary>
        internal bool IsSetDestinationParameterName() => this.DestinationParameterName != null;

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationParameterValueConfiguration Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
