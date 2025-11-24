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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents what rule type should take place, under what conditions. In the Amazon
    /// Connect admin website, case rules are known as <i>case field conditions</i>. For more
    /// information about case field conditions, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class CaseRuleDetails
    {
        private FieldOptionsCaseRule _fieldOptions;
        private HiddenCaseRule _hidden;
        private RequiredCaseRule _required;

        /// <summary>
        /// Gets and sets the property FieldOptions. 
        /// <para>
        /// Which options are available in a child field based on the selected value in a parent
        /// field.
        /// </para>
        /// </summary>
        public FieldOptionsCaseRule FieldOptions
        {
            get { return this._fieldOptions; }
            set { this._fieldOptions = value; }
        }

        // Check to see if FieldOptions property is set
        internal bool IsSetFieldOptions()
        {
            return this._fieldOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Hidden. 
        /// <para>
        /// Whether a field is visible, based on values in other fields.
        /// </para>
        /// </summary>
        public HiddenCaseRule Hidden
        {
            get { return this._hidden; }
            set { this._hidden = value; }
        }

        // Check to see if Hidden property is set
        internal bool IsSetHidden()
        {
            return this._hidden != null;
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Required rule type, used to indicate whether a field is required.
        /// </para>
        /// </summary>
        public RequiredCaseRule Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required != null;
        }

    }
}