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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
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
namespace Amazon.Sustainability.Model
{
    /// <summary>
    /// Represents a dimension and its corresponding value.
    /// </summary>
    public partial class DimensionEntry
    {
        private Dimension _dimension;
        private string _value;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The dimension type that categorizes this entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dimension Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value for the specified dimension. Valid values vary based on the dimension type
        /// (e.g., <c>us-east-1</c> for the <c>REGION</c> dimension, <c>AmazonEC2</c> for the
        /// <c>SERVICE</c> dimension). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}