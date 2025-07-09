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
    /// Contains options for splitting X12 EDI files into smaller units. This is useful for
    /// processing large EDI files more efficiently.
    /// </summary>
    public partial class X12SplitOptions
    {
        private X12SplitBy _splitBy;

        /// <summary>
        /// Gets and sets the property SplitBy. 
        /// <para>
        /// Specifies the method used to split X12 EDI files. Valid values include <c>TRANSACTION</c>
        /// (split by individual transaction sets), or <c>NONE</c> (no splitting).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public X12SplitBy SplitBy
        {
            get { return this._splitBy; }
            set { this._splitBy = value; }
        }

        // Check to see if SplitBy property is set
        internal bool IsSetSplitBy()
        {
            return this._splitBy != null;
        }

    }
}