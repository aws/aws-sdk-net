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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the SimpleScalarProperties operation.
    /// </summary>
    public partial class SimpleScalarPropertiesRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property ByteValue.
        /// </summary>
        public int? ByteValue { get; set; }

        /// <summary>
        /// Checks to see if the ByteValue property is set.
        /// </summary>
        internal bool IsSetByteValue() => this.ByteValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue.
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property FalseBooleanValue.
        /// </summary>
        public bool? FalseBooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the FalseBooleanValue property is set.
        /// </summary>
        internal bool IsSetFalseBooleanValue() => this.FalseBooleanValue.HasValue;

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
        /// Gets and sets the property IntegerValue.
        /// </summary>
        public int? IntegerValue { get; set; }

        /// <summary>
        /// Checks to see if the IntegerValue property is set.
        /// </summary>
        internal bool IsSetIntegerValue() => this.IntegerValue.HasValue;

        /// <summary>
        /// Gets and sets the property LongValue.
        /// </summary>
        public long? LongValue { get; set; }

        /// <summary>
        /// Checks to see if the LongValue property is set.
        /// </summary>
        internal bool IsSetLongValue() => this.LongValue.HasValue;

        /// <summary>
        /// Gets and sets the property ShortValue.
        /// </summary>
        public int? ShortValue { get; set; }

        /// <summary>
        /// Checks to see if the ShortValue property is set.
        /// </summary>
        internal bool IsSetShortValue() => this.ShortValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;

        /// <summary>
        /// Gets and sets the property TrueBooleanValue.
        /// </summary>
        public bool? TrueBooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the TrueBooleanValue property is set.
        /// </summary>
        internal bool IsSetTrueBooleanValue() => this.TrueBooleanValue.HasValue;
    }
}
