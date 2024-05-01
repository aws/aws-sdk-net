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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
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
namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the SimpleInputParams operation.
    /// This test serializes strings, numbers, and boolean values.
    /// </summary>
    public partial class SimpleInputParamsRequest : AmazonQueryProtocolRequest
    {
        private int? _bam;
        private string _bar;
        private bool? _baz;
        private double? _boo;
        private float? _floatValue;
        private string _foo;
        private FooEnum _fooEnum;
        private int? _integerEnum;
        private MemoryStream _qux;

        /// <summary>
        /// Gets and sets the property Bam.
        /// </summary>
        public int? Bam
        {
            get { return this._bam; }
            set { this._bam = value; }
        }

        // Check to see if Bam property is set
        internal bool IsSetBam()
        {
            return this._bam.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Bar.
        /// </summary>
        public string Bar
        {
            get { return this._bar; }
            set { this._bar = value; }
        }

        // Check to see if Bar property is set
        internal bool IsSetBar()
        {
            return this._bar != null;
        }

        /// <summary>
        /// Gets and sets the property Baz.
        /// </summary>
        public bool? Baz
        {
            get { return this._baz; }
            set { this._baz = value; }
        }

        // Check to see if Baz property is set
        internal bool IsSetBaz()
        {
            return this._baz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Boo.
        /// </summary>
        public double? Boo
        {
            get { return this._boo; }
            set { this._boo = value; }
        }

        // Check to see if Boo property is set
        internal bool IsSetBoo()
        {
            return this._boo.HasValue; 
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
        /// Gets and sets the property FooEnum.
        /// </summary>
        public FooEnum FooEnum
        {
            get { return this._fooEnum; }
            set { this._fooEnum = value; }
        }

        // Check to see if FooEnum property is set
        internal bool IsSetFooEnum()
        {
            return this._fooEnum != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerEnum.
        /// </summary>
        public int? IntegerEnum
        {
            get { return this._integerEnum; }
            set { this._integerEnum = value; }
        }

        // Check to see if IntegerEnum property is set
        internal bool IsSetIntegerEnum()
        {
            return this._integerEnum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Qux.
        /// </summary>
        public MemoryStream Qux
        {
            get { return this._qux; }
            set { this._qux = value; }
        }

        // Check to see if Qux property is set
        internal bool IsSetQux()
        {
            return this._qux != null;
        }

    }
}