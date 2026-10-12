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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// A JSON object that contains a mocked <c>result</c> or <c>errorOutput</c>.
    /// </summary>
    public partial class MockInput
    {
        /// <summary>
        /// Gets and sets the property ErrorOutput. 
        /// <para>
        /// The mocked error output when calling TestState. When specified, the mocked response
        /// is returned as a JSON object that contains an <c>error</c> and <c>cause</c> field.
        /// </para>
        /// </summary>
        public MockErrorOutput ErrorOutput { get; set; }

        /// <summary>
        /// Checks to see if the ErrorOutput property is set.
        /// </summary>
        internal bool IsSetErrorOutput() => this.ErrorOutput != null;

        /// <summary>
        /// Gets and sets the property FieldValidationMode. 
        /// <para>
        /// Determines the level of strictness when validating mocked results against their respective
        /// API models. Values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STRICT</c>: All required fields must be present, and all present fields must conform
        /// to the API's schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRESENT</c>: All present fields must conform to the API's schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: No validation is performed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no value is specified, the default value is <c>STRICT</c>.
        /// </para>
        /// </summary>
        public MockResponseValidationMode FieldValidationMode { get; set; }

        /// <summary>
        /// Checks to see if the FieldValidationMode property is set.
        /// </summary>
        internal bool IsSetFieldValidationMode() => this.FieldValidationMode != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// A JSON string containing the mocked result of the state invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;
    }
}
