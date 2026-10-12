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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the TestConversion operation. This operation mimics
    /// the latter half of a typical Outbound EDI request. It takes an input JSON/XML in the
    /// B2Bi shape as input, converts it to an X12 EDI string, and return that string.
    /// </summary>
    public partial class TestConversionRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Specify the source file for an outbound EDI request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConversionSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Specify the format (X12 is the only currently supported format), and other details
        /// for the conversion target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConversionTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
