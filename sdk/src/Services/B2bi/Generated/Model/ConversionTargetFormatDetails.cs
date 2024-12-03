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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains a structure describing the X12 details for the conversion target.
    /// </summary>
    public partial class ConversionTargetFormatDetails
    {
        private X12Details _x12;

        /// <summary>
        /// Gets and sets the property X12.
        /// </summary>
        public X12Details X12
        {
            get { return this._x12; }
            set { this._x12 = value; }
        }

        // Check to see if X12 property is set
        internal bool IsSetX12()
        {
            return this._x12 != null;
        }

    }
}