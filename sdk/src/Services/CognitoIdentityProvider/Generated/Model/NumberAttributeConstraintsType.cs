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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The minimum and maximum values of an attribute that is of the number type, for example
    /// <c>custom:age</c>.
    /// </summary>
    public partial class NumberAttributeConstraintsType
    {
        private string _maxValue;
        private string _minValue;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum length of a number attribute value. Must be a number less than or equal
        /// to <c>2^1023</c>, represented as a string with a length of 131072 characters or fewer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue != null;
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum value of an attribute that is of the number data type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue != null;
        }

    }
}