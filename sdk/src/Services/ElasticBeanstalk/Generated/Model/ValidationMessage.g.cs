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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// An error or warning for a desired configuration option value.
    /// </summary>
    public partial class ValidationMessage
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ValidationMessage() { }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing the error or warning.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to which the option belongs.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the option.
        /// </para>
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// Checks to see if the OptionName property is set.
        /// </summary>
        internal bool IsSetOptionName() => this.OptionName != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// An indication of the severity of this message:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>error</c>: This message indicates that this is not a valid setting for an option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>warning</c>: This message is providing information you should take into account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ValidationSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
