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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Defines the value for one rating in a custom metric rating scale.
    /// </summary>
    public partial class RatingScaleItemValue
    {
        private float? _floatValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property FloatValue. 
        /// <para>
        /// A floating point number representing the value for a rating in a custom metric rating
        /// scale.
        /// </para>
        /// </summary>
        public float? FloatValue
        {
            get { return this._floatValue; }
            set { this._floatValue = value; }
        }

        // Check to see if FloatValue property is set
        internal bool IsSetFloatValue()
        {
            return this._floatValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string representing the value for a rating in a custom metric rating scale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}