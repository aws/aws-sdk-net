/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The type of constraints associated with an attribute of the string type.
    /// </summary>
    public partial class StringAttributeConstraintsType
    {
        private string _maxLength;
        private string _minLength;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length of an attribute value of the string type.
        /// </para>
        /// </summary>
        public string MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength != null;
        }

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum length of an attribute value of the string type.
        /// </para>
        /// </summary>
        public string MinLength
        {
            get { return this._minLength; }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength != null;
        }

    }
}