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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Object specifying the acceptable range of challenge versions.
    /// </summary>
    public partial class Versions
    {
        private string _maximum;
        private string _minimum;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The desired maximum version for the challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=11)]
        public string Maximum
        {
            get { return this._maximum; }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum != null;
        }

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The desired minimum version for the challenge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=11)]
        public string Minimum
        {
            get { return this._minimum; }
            set { this._minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this._minimum != null;
        }

    }
}