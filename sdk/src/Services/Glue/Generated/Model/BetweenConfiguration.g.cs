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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines how BETWEEN range filter operations are translated into
    /// REST API request parameters.
    /// </summary>
    public partial class BetweenConfiguration
    {
        /// <summary>
        /// Gets and sets the property HighBoundKey. 
        /// <para>
        /// The parameter name used for the upper bound value in a BETWEEN filter operation.
        /// </para>
        /// </summary>
        public string HighBoundKey { get; set; }

        /// <summary>
        /// Checks to see if the HighBoundKey property is set.
        /// </summary>
        internal bool IsSetHighBoundKey() => this.HighBoundKey != null;

        /// <summary>
        /// Gets and sets the property LowBoundKey. 
        /// <para>
        /// The parameter name used for the lower bound value in a BETWEEN filter operation.
        /// </para>
        /// </summary>
        public string LowBoundKey { get; set; }

        /// <summary>
        /// Checks to see if the LowBoundKey property is set.
        /// </summary>
        internal bool IsSetLowBoundKey() => this.LowBoundKey != null;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// A template string for constructing the BETWEEN filter expression.
        /// </para>
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => this.Template != null;
    }
}
