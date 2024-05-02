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
    /// Specifies the details for the EDI standard that is being used for the transformer.
    /// Currently, only X12 is supported. X12 is a set of standards and corresponding messages
    /// that define specific business documents.
    /// </summary>
    public partial class EdiType
    {
        private X12Details _x12Details;

        /// <summary>
        /// Gets and sets the property X12Details. 
        /// <para>
        /// Returns the details for the EDI standard that is being used for the transformer. Currently,
        /// only X12 is supported. X12 is a set of standards and corresponding messages that define
        /// specific business documents.
        /// </para>
        /// </summary>
        public X12Details X12Details
        {
            get { return this._x12Details; }
            set { this._x12Details = value; }
        }

        // Check to see if X12Details property is set
        internal bool IsSetX12Details()
        {
            return this._x12Details != null;
        }

    }
}