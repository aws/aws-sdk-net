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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Detailed information about the bad request exception error when creating a hosted
    /// configuration version.
    /// </summary>
    public partial class InvalidConfigurationDetail
    {
        private string _constraint;
        private string _location;
        private string _reason;
        private string _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Constraint. 
        /// <para>
        /// The invalid or out-of-range validation constraint in your JSON schema that failed
        /// validation.
        /// </para>
        /// </summary>
        public string Constraint
        {
            get { return this._constraint; }
            set { this._constraint = value; }
        }

        // Check to see if Constraint property is set
        internal bool IsSetConstraint()
        {
            return this._constraint != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Location of the validation constraint in the configuration JSON schema that failed
        /// validation.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for an invalid configuration error.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of error for an invalid configuration.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Details about an error with Lambda when a synchronous extension experiences an error
        /// during an invocation.
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