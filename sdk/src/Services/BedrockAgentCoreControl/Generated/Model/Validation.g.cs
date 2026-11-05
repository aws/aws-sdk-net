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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Validation rules for extracted metadata values. Only one type can be specified, matching
    /// the field's data type.
    /// </summary>
    public partial class Validation
    {
        /// <summary>
        /// Gets and sets the property NumberValidation.
        /// </summary>
        public NumberValidation NumberValidation { get; set; }

        /// <summary>
        /// Checks to see if the NumberValidation property is set.
        /// </summary>
        internal bool IsSetNumberValidation() => this.NumberValidation != null;

        /// <summary>
        /// Gets and sets the property StringListValidation.
        /// </summary>
        public StringListValidation StringListValidation { get; set; }

        /// <summary>
        /// Checks to see if the StringListValidation property is set.
        /// </summary>
        internal bool IsSetStringListValidation() => this.StringListValidation != null;

        /// <summary>
        /// Gets and sets the property StringValidation.
        /// </summary>
        public StringValidation StringValidation { get; set; }

        /// <summary>
        /// Checks to see if the StringValidation property is set.
        /// </summary>
        internal bool IsSetStringValidation() => this.StringValidation != null;
    }
}
