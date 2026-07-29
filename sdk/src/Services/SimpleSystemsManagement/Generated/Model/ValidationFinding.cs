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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private ValidationFindingCode _code;
        private string _message;
        private string _providerMessage;
        private ValidationFindingScope _scope;
        private ValidationFindingType _type;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A code that identifies the specific validation finding.
        /// </para>
        /// </summary>
        public ValidationFindingCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes the validation finding.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderMessage. 
        /// <para>
        /// A message from the third-party cloud provider related to the validation finding.
        /// </para>
        /// </summary>
        public string ProviderMessage
        {
            get { return this._providerMessage; }
            set { this._providerMessage = value; }
        }

        // Check to see if ProviderMessage property is set
        internal bool IsSetProviderMessage()
        {
            return this._providerMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the validation finding, identifying the specific resource affected.
        /// </para>
        /// </summary>
        public ValidationFindingScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the validation finding.
        /// </para>
        /// </summary>
        public ValidationFindingType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}