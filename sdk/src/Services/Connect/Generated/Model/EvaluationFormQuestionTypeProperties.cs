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
    /// Information about properties for a question in an evaluation form. The question type
    /// properties must be either for a numeric question or a single select question.
    /// </summary>
    public partial class EvaluationFormQuestionTypeProperties
    {
        private EvaluationFormNumericQuestionProperties _numeric;
        private EvaluationFormSingleSelectQuestionProperties _singleSelect;

        /// <summary>
        /// Gets and sets the property Numeric. 
        /// <para>
        /// The properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormNumericQuestionProperties Numeric
        {
            get { return this._numeric; }
            set { this._numeric = value; }
        }

        // Check to see if Numeric property is set
        internal bool IsSetNumeric()
        {
            return this._numeric != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSelect. 
        /// <para>
        /// The properties of the numeric question.
        /// </para>
        /// </summary>
        public EvaluationFormSingleSelectQuestionProperties SingleSelect
        {
            get { return this._singleSelect; }
            set { this._singleSelect = value; }
        }

        // Check to see if SingleSelect property is set
        internal bool IsSetSingleSelect()
        {
            return this._singleSelect != null;
        }

    }
}