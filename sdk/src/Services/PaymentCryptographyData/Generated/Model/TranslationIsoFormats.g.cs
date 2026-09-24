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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters that are required for translation between ISO9564 PIN block formats 0,1,3,4.
    /// </summary>
    public partial class TranslationIsoFormats
    {
        /// <summary>
        /// Gets and sets the property As2805Format0. 
        /// <para>
        /// Parameters that are required for AS2805 PIN format 0 translation.
        /// </para>
        /// </summary>
        public TranslationPinDataAs2805Format0 As2805Format0 { get; set; }

        /// <summary>
        /// Checks to see if the As2805Format0 property is set.
        /// </summary>
        internal bool IsSetAs2805Format0() => this.As2805Format0 != null;

        /// <summary>
        /// Gets and sets the property IsoFormat0. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 0 translation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat0 { get; set; }

        /// <summary>
        /// Checks to see if the IsoFormat0 property is set.
        /// </summary>
        internal bool IsSetIsoFormat0() => this.IsoFormat0 != null;

        /// <summary>
        /// Gets and sets the property IsoFormat1. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 1 translation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat1 IsoFormat1 { get; set; }

        /// <summary>
        /// Checks to see if the IsoFormat1 property is set.
        /// </summary>
        internal bool IsSetIsoFormat1() => this.IsoFormat1 != null;

        /// <summary>
        /// Gets and sets the property IsoFormat3. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 3 translation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat3 { get; set; }

        /// <summary>
        /// Checks to see if the IsoFormat3 property is set.
        /// </summary>
        internal bool IsSetIsoFormat3() => this.IsoFormat3 != null;

        /// <summary>
        /// Gets and sets the property IsoFormat4. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 4 translation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat4 { get; set; }

        /// <summary>
        /// Checks to see if the IsoFormat4 property is set.
        /// </summary>
        internal bool IsSetIsoFormat4() => this.IsoFormat4 != null;
    }
}
