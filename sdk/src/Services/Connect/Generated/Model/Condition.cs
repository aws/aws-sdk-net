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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A leaf node condition which can be used to specify a ProficiencyName, ProficiencyValue
    /// and ProficiencyLimit.
    /// </summary>
    public partial class Condition
    {
        private NumberCondition _numberCondition;
        private StringCondition _stringCondition;

        /// <summary>
        /// Gets and sets the property NumberCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a numeric condition.
        /// </para>
        /// </summary>
        public NumberCondition NumberCondition
        {
            get { return this._numberCondition; }
            set { this._numberCondition = value; }
        }

        // Check to see if NumberCondition property is set
        internal bool IsSetNumberCondition()
        {
            return this._numberCondition != null;
        }

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a string condition.
        /// </para>
        ///  <note> 
        /// <para>
        /// The currently supported values for <c>FieldName</c> are <c>name</c> and&#x2028; <c>value</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public StringCondition StringCondition
        {
            get { return this._stringCondition; }
            set { this._stringCondition = value; }
        }

        // Check to see if StringCondition property is set
        internal bool IsSetStringCondition()
        {
            return this._stringCondition != null;
        }

    }
}