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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Object to store union of Field values.
    /// </summary>
    public partial class AuditEventFieldValueUnion
    {
        private bool? _booleanValue;
        private double? _doubleValue;
        private EmptyFieldValue _emptyValue;
        private string _stringValue;
        private string _userArnValue;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// Can be either null, or have a Boolean value type. Only one value can be provided.
        /// </para>
        /// </summary>
        public bool? BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// Can be either null, or have a Double value type. Only one value can be provided.
        /// </para>
        /// </summary>
        public double? DoubleValue
        {
            get { return this._doubleValue; }
            set { this._doubleValue = value; }
        }

        // Check to see if DoubleValue property is set
        internal bool IsSetDoubleValue()
        {
            return this._doubleValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmptyValue.
        /// </summary>
        public EmptyFieldValue EmptyValue
        {
            get { return this._emptyValue; }
            set { this._emptyValue = value; }
        }

        // Check to see if EmptyValue property is set
        internal bool IsSetEmptyValue()
        {
            return this._emptyValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// Can be either null, or have a String value type. Only one value can be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

        /// <summary>
        /// Gets and sets the property UserArnValue. 
        /// <para>
        /// Can be either null, or have a String value type formatted as an ARN. Only one value
        /// can be provided.
        /// </para>
        /// </summary>
        public string UserArnValue
        {
            get { return this._userArnValue; }
            set { this._userArnValue = value; }
        }

        // Check to see if UserArnValue property is set
        internal bool IsSetUserArnValue()
        {
            return this._userArnValue != null;
        }

    }
}