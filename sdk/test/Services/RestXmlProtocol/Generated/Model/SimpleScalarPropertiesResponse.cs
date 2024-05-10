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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// This is the response object from the SimpleScalarProperties operation.
    /// </summary>
    public partial class SimpleScalarPropertiesResponse : AmazonWebServiceResponse
    {
        private int? _byteValue;
        private double? _doubleValue;
        private bool? _falseBooleanValue;
        private float? _floatValue;
        private string _foo;
        private int? _integerValue;
        private long? _longValue;
        private int? _shortValue;
        private string _stringValue;
        private bool? _trueBooleanValue;

        /// <summary>
        /// Gets and sets the property ByteValue.
        /// </summary>
        public int? ByteValue
        {
            get { return this._byteValue; }
            set { this._byteValue = value; }
        }

        // Check to see if ByteValue property is set
        internal bool IsSetByteValue()
        {
            return this._byteValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DoubleValue.
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
        /// Gets and sets the property FalseBooleanValue.
        /// </summary>
        public bool? FalseBooleanValue
        {
            get { return this._falseBooleanValue; }
            set { this._falseBooleanValue = value; }
        }

        // Check to see if FalseBooleanValue property is set
        internal bool IsSetFalseBooleanValue()
        {
            return this._falseBooleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FloatValue.
        /// </summary>
        public float? FloatValue
        {
            get { return this._floatValue; }
            set { this._floatValue = value; }
        }

        // Check to see if FloatValue property is set
        internal bool IsSetFloatValue()
        {
            return this._floatValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Foo.
        /// </summary>
        public string Foo
        {
            get { return this._foo; }
            set { this._foo = value; }
        }

        // Check to see if Foo property is set
        internal bool IsSetFoo()
        {
            return this._foo != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerValue.
        /// </summary>
        public int? IntegerValue
        {
            get { return this._integerValue; }
            set { this._integerValue = value; }
        }

        // Check to see if IntegerValue property is set
        internal bool IsSetIntegerValue()
        {
            return this._integerValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongValue.
        /// </summary>
        public long? LongValue
        {
            get { return this._longValue; }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShortValue.
        /// </summary>
        public int? ShortValue
        {
            get { return this._shortValue; }
            set { this._shortValue = value; }
        }

        // Check to see if ShortValue property is set
        internal bool IsSetShortValue()
        {
            return this._shortValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringValue.
        /// </summary>
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
        /// Gets and sets the property TrueBooleanValue.
        /// </summary>
        public bool? TrueBooleanValue
        {
            get { return this._trueBooleanValue; }
            set { this._trueBooleanValue = value; }
        }

        // Check to see if TrueBooleanValue property is set
        internal bool IsSetTrueBooleanValue()
        {
            return this._trueBooleanValue.HasValue; 
        }

    }
}