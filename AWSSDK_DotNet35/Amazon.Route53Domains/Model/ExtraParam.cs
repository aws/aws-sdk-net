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
        /// Name of the additional parameter required by the top-level domain.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>DUNS_NUMBER</code> | <code>BRAND_NUMBER</code> | <code>BIRTH_DEPARTMENT</code>
        /// | <code>BIRTH_DATE_IN_YYYY_MM_DD</code> | <code>BIRTH_COUNTRY</code> | <code>BIRTH_CITY</code>
        /// | <code>DOCUMENT_NUMBER</code> | <code>AU_ID_NUMBER</code> | <code>AU_ID_TYPE</code>
        /// | <code>CA_LEGAL_TYPE</code> | <code>FI_BUSINESS_NUMBER</code> | <code>FI_ID_NUMBER</code>
        /// | <code>IT_PIN</code> | <code>RU_PASSPORT_DATA</code> | <code>SE_ID_NUMBER</code>
        /// | <code>SG_ID_NUMBER</code> | <code>VAT_NUMBER</code>
        /// </para>
        ///  
        /// <para>
        /// Parent: <code>ExtraParams</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 2048 characters.
        /// </para>
        ///  
        /// <para>
        /// Parent: <code>ExtraParams</code>
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
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