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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
        private TranslationPinDataIsoFormat034 _isoFormat0;
        private TranslationPinDataIsoFormat1 _isoFormat1;
        private TranslationPinDataIsoFormat034 _isoFormat3;
        private TranslationPinDataIsoFormat034 _isoFormat4;

        /// <summary>
        /// Gets and sets the property IsoFormat0. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 0 tranlation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat0
        {
            get { return this._isoFormat0; }
            set { this._isoFormat0 = value; }
        }

        // Check to see if IsoFormat0 property is set
        internal bool IsSetIsoFormat0()
        {
            return this._isoFormat0 != null;
        }

        /// <summary>
        /// Gets and sets the property IsoFormat1. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 1 tranlation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat1 IsoFormat1
        {
            get { return this._isoFormat1; }
            set { this._isoFormat1 = value; }
        }

        // Check to see if IsoFormat1 property is set
        internal bool IsSetIsoFormat1()
        {
            return this._isoFormat1 != null;
        }

        /// <summary>
        /// Gets and sets the property IsoFormat3. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 3 tranlation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat3
        {
            get { return this._isoFormat3; }
            set { this._isoFormat3 = value; }
        }

        // Check to see if IsoFormat3 property is set
        internal bool IsSetIsoFormat3()
        {
            return this._isoFormat3 != null;
        }

        /// <summary>
        /// Gets and sets the property IsoFormat4. 
        /// <para>
        /// Parameters that are required for ISO9564 PIN format 4 tranlation.
        /// </para>
        /// </summary>
        public TranslationPinDataIsoFormat034 IsoFormat4
        {
            get { return this._isoFormat4; }
            set { this._isoFormat4 = value; }
        }

        // Check to see if IsoFormat4 property is set
        internal bool IsSetIsoFormat4()
        {
            return this._isoFormat4 != null;
        }

    }
}