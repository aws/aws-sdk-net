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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS number filter.
    /// </summary>
    public partial class CisNumberFilter
    {
        private int? _lowerInclusive;
        private int? _upperInclusive;

        /// <summary>
        /// Gets and sets the property LowerInclusive. 
        /// <para>
        /// The CIS number filter's lower inclusive.
        /// </para>
        /// </summary>
        public int? LowerInclusive
        {
            get { return this._lowerInclusive; }
            set { this._lowerInclusive = value; }
        }

        // Check to see if LowerInclusive property is set
        internal bool IsSetLowerInclusive()
        {
            return this._lowerInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperInclusive. 
        /// <para>
        /// The CIS number filter's upper inclusive.
        /// </para>
        /// </summary>
        public int? UpperInclusive
        {
            get { return this._upperInclusive; }
            set { this._upperInclusive = value; }
        }

        // Check to see if UpperInclusive property is set
        internal bool IsSetUpperInclusive()
        {
            return this._upperInclusive.HasValue; 
        }

    }
}