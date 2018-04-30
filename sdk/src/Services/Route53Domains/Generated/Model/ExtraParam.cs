/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// ExtraParam includes the following elements.
    /// </summary>
    public partial class ExtraParam
    {
        private ExtraParamName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the additional parameter required by the top-level domain. Here are the top-level
        /// domains that require additional parameters and which parameters they require:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>.com.au and .net.au:</b> <code>AU_ID_NUMBER</code> and <code>AU_ID_TYPE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.ca:</b> <code>BRAND_NUMBER</code>, <code>CA_LEGAL_TYPE</code>, and <code>CA_BUSINESS_ENTITY_TYPE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.es:</b> <code>ES_IDENTIFICATION</code>, <code>ES_IDENTIFICATION_TYPE</code>,
        /// and <code>ES_LEGAL_FORM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.fi:</b> <code>BIRTH_DATE_IN_YYYY_MM_DD</code>, <code>FI_BUSINESS_NUMBER</code>,
        /// <code>FI_ID_NUMBER</code>, <code>FI_NATIONALITY</code>, and <code>FI_ORGANIZATION_TYPE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.fr:</b> <code>BRAND_NUMBER</code>, <code>BIRTH_DEPARTMENT</code>, <code>BIRTH_DATE_IN_YYYY_MM_DD</code>,
        /// <code>BIRTH_COUNTRY</code>, and <code>BIRTH_CITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.it:</b> <code>BIRTH_COUNTRY</code>, <code>IT_PIN</code>, and <code>IT_REGISTRANT_ENTITY_TYPE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.ru:</b> <code>BIRTH_DATE_IN_YYYY_MM_DD</code> and <code>RU_PASSPORT_DATA</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.se:</b> <code>BIRTH_COUNTRY</code> and <code>SE_ID_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.sg:</b> <code>SG_ID_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>.co.uk, .me.uk, and .org.uk:</b> <code>UK_CONTACT_TYPE</code> and <code>UK_COMPANY_NUMBER</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In addition, many TLDs require <code>VAT_NUMBER</code>.
        /// </para>
        /// </summary>
        public ExtraParamName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Values corresponding to the additional parameter names required by some top-level
        /// domains.
        /// </para>
        /// </summary>
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