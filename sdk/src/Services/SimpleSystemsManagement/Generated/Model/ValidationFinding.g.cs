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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A validation finding from a cloud connector validation check.
    /// </summary>
    public partial class ValidationFinding
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A code that identifies the specific validation finding.
        /// </para>
        /// </summary>
        public ValidationFindingCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes the validation finding.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ProviderMessage. 
        /// <para>
        /// A message from the third-party cloud provider related to the validation finding.
        /// </para>
        /// </summary>
        public string ProviderMessage { get; set; }

        /// <summary>
        /// Checks to see if the ProviderMessage property is set.
        /// </summary>
        internal bool IsSetProviderMessage() => this.ProviderMessage != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the validation finding, identifying the specific resource affected.
        /// </para>
        /// </summary>
        public ValidationFindingScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the validation finding.
        /// </para>
        /// </summary>
        public ValidationFindingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
