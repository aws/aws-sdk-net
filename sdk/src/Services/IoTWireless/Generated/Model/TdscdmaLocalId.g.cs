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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// TD-SCDMA local identification (local Id) information.
    /// </summary>
    public partial class TdscdmaLocalId
    {
        /// <summary>
        /// Gets and sets the property CellParams. 
        /// <para>
        /// Cell parameters for TD-SCDMA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 127)]
        public int? CellParams { get; set; }

        /// <summary>
        /// Checks to see if the CellParams property is set.
        /// </summary>
        internal bool IsSetCellParams() => this.CellParams.HasValue;

        /// <summary>
        /// Gets and sets the property Uarfcn. 
        /// <para>
        /// TD-SCDMA UTRA (Universal Terrestrial Radio Access Network) absolute RF channel number
        /// (UARFCN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 16383)]
        public int? Uarfcn { get; set; }

        /// <summary>
        /// Checks to see if the Uarfcn property is set.
        /// </summary>
        internal bool IsSetUarfcn() => this.Uarfcn.HasValue;
    }
}
