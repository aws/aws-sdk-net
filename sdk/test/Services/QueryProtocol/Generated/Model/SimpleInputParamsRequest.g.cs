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

namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the SimpleInputParams operation. This test serializes
    /// strings, numbers, and boolean values.
    /// </summary>
    public partial class SimpleInputParamsRequest : AmazonQueryProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property Bam.
        /// </summary>
        public int? Bam { get; set; }

        /// <summary>
        /// Checks to see if the Bam property is set.
        /// </summary>
        internal bool IsSetBam() => this.Bam.HasValue;

        /// <summary>
        /// Gets and sets the property Bar.
        /// </summary>
        public string Bar { get; set; }

        /// <summary>
        /// Checks to see if the Bar property is set.
        /// </summary>
        internal bool IsSetBar() => this.Bar != null;

        /// <summary>
        /// Gets and sets the property Baz.
        /// </summary>
        public bool? Baz { get; set; }

        /// <summary>
        /// Checks to see if the Baz property is set.
        /// </summary>
        internal bool IsSetBaz() => this.Baz.HasValue;

        /// <summary>
        /// Gets and sets the property Boo.
        /// </summary>
        public double? Boo { get; set; }

        /// <summary>
        /// Checks to see if the Boo property is set.
        /// </summary>
        internal bool IsSetBoo() => this.Boo.HasValue;

        /// <summary>
        /// Gets and sets the property FloatValue.
        /// </summary>
        public float? FloatValue { get; set; }

        /// <summary>
        /// Checks to see if the FloatValue property is set.
        /// </summary>
        internal bool IsSetFloatValue() => this.FloatValue.HasValue;

        /// <summary>
        /// Gets and sets the property Foo.
        /// </summary>
        public string Foo { get; set; }

        /// <summary>
        /// Checks to see if the Foo property is set.
        /// </summary>
        internal bool IsSetFoo() => this.Foo != null;

        /// <summary>
        /// Gets and sets the property FooEnum.
        /// </summary>
        public FooEnum FooEnum { get; set; }

        /// <summary>
        /// Checks to see if the FooEnum property is set.
        /// </summary>
        internal bool IsSetFooEnum() => this.FooEnum != null;

        /// <summary>
        /// Gets and sets the property IntegerEnum.
        /// </summary>
        public int? IntegerEnum { get; set; }

        /// <summary>
        /// Checks to see if the IntegerEnum property is set.
        /// </summary>
        internal bool IsSetIntegerEnum() => this.IntegerEnum.HasValue;

        /// <summary>
        /// Gets and sets the property Qux.
        /// </summary>
        public MemoryStream Qux { get; set; }

        /// <summary>
        /// Checks to see if the Qux property is set.
        /// </summary>
        internal bool IsSetQux() => this.Qux != null;
    }
}
