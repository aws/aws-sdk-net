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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Validation rules for extracted metadata values. Only one type can be specified, matching
    /// the field's data type.
    /// </summary>
    public partial class Validation
    {
        private NumberValidation _numberValidation;
        private StringListValidation _stringListValidation;
        private StringValidation _stringValidation;

        /// <summary>
        /// Gets and sets the property NumberValidation.
        /// </summary>
        public NumberValidation NumberValidation
        {
            get { return this._numberValidation; }
            set { this._numberValidation = value; }
        }

        // Check to see if NumberValidation property is set
        internal bool IsSetNumberValidation()
        {
            return this._numberValidation != null;
        }

        /// <summary>
        /// Gets and sets the property StringListValidation.
        /// </summary>
        public StringListValidation StringListValidation
        {
            get { return this._stringListValidation; }
            set { this._stringListValidation = value; }
        }

        // Check to see if StringListValidation property is set
        internal bool IsSetStringListValidation()
        {
            return this._stringListValidation != null;
        }

        /// <summary>
        /// Gets and sets the property StringValidation.
        /// </summary>
        public StringValidation StringValidation
        {
            get { return this._stringValidation; }
            set { this._stringValidation = value; }
        }

        // Check to see if StringValidation property is set
        internal bool IsSetStringValidation()
        {
            return this._stringValidation != null;
        }

    }
}