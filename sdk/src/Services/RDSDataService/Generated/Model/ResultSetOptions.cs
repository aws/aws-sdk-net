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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Options that control how the result set is returned.
    /// </summary>
    public partial class ResultSetOptions
    {
        private DecimalReturnType _decimalReturnType;
        private LongReturnType _longReturnType;

        /// <summary>
        /// Gets and sets the property DecimalReturnType. 
        /// <para>
        /// A value that indicates how a field of <code>DECIMAL</code> type is represented in
        /// the response. The value of <code>STRING</code>, the default, specifies that it is
        /// converted to a String value. The value of <code>DOUBLE_OR_LONG</code> specifies that
        /// it is converted to a Long value if its scale is 0, or to a Double value otherwise.
        /// </para>
        ///  <note> 
        /// <para>
        /// Conversion to Double or Long can result in roundoff errors due to precision loss.
        /// We recommend converting to String, especially when working with currency values.
        /// </para>
        ///  </note>
        /// </summary>
        public DecimalReturnType DecimalReturnType
        {
            get { return this._decimalReturnType; }
            set { this._decimalReturnType = value; }
        }

        // Check to see if DecimalReturnType property is set
        internal bool IsSetDecimalReturnType()
        {
            return this._decimalReturnType != null;
        }

        /// <summary>
        /// Gets and sets the property LongReturnType. 
        /// <para>
        /// A value that indicates how a field of <code>LONG</code> type is represented. Allowed
        /// values are <code>LONG</code> and <code>STRING</code>. The default is <code>LONG</code>.
        /// Specify <code>STRING</code> if the length or precision of numeric values might cause
        /// truncation or rounding errors. 
        /// </para>
        /// </summary>
        public LongReturnType LongReturnType
        {
            get { return this._longReturnType; }
            set { this._longReturnType = value; }
        }

        // Check to see if LongReturnType property is set
        internal bool IsSetLongReturnType()
        {
            return this._longReturnType != null;
        }

    }
}