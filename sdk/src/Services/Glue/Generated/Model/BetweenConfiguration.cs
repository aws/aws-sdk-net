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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _highBoundKey;
        private string _lowBoundKey;
        private string _template;

        /// <summary>
        /// Gets and sets the property HighBoundKey. 
        /// <para>
        /// The parameter name used for the upper bound value in a BETWEEN filter operation.
        /// </para>
        /// </summary>
        public string HighBoundKey
        {
            get { return this._highBoundKey; }
            set { this._highBoundKey = value; }
        }

        // Check to see if HighBoundKey property is set
        internal bool IsSetHighBoundKey()
        {
            return this._highBoundKey != null;
        }

        /// <summary>
        /// Gets and sets the property LowBoundKey. 
        /// <para>
        /// The parameter name used for the lower bound value in a BETWEEN filter operation.
        /// </para>
        /// </summary>
        public string LowBoundKey
        {
            get { return this._lowBoundKey; }
            set { this._lowBoundKey = value; }
        }

        // Check to see if LowBoundKey property is set
        internal bool IsSetLowBoundKey()
        {
            return this._lowBoundKey != null;
        }

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// A template string for constructing the BETWEEN filter expression.
        /// </para>
        /// </summary>
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}