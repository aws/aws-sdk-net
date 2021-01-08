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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains a numeric value in decimal format.
    /// </summary>
    public partial class DecimalNumber
    {
        private int? _scale;
        private MemoryStream _unscaledValue;

        /// <summary>
        /// Gets and sets the property Scale. 
        /// <para>
        /// The scale that determines where the decimal point falls in the unscaled value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Scale
        {
            get { return this._scale.GetValueOrDefault(); }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnscaledValue. 
        /// <para>
        /// The unscaled numeric value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream UnscaledValue
        {
            get { return this._unscaledValue; }
            set { this._unscaledValue = value; }
        }

        // Check to see if UnscaledValue property is set
        internal bool IsSetUnscaledValue()
        {
            return this._unscaledValue != null;
        }

    }
}