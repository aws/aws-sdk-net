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
    /// Container for the parameters to the OmitsNullSerializesEmptyString operation. Omits
    /// null, but serializes empty string value.
    /// </summary>
    public partial class OmitsNullSerializesEmptyStringRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property EmptyString.
        /// </summary>
        public string EmptyString { get; set; }

        /// <summary>
        /// Checks to see if the EmptyString property is set.
        /// </summary>
        internal bool IsSetEmptyString() => this.EmptyString != null;

        /// <summary>
        /// Gets and sets the property NullValue.
        /// </summary>
        public string NullValue { get; set; }

        /// <summary>
        /// Checks to see if the NullValue property is set.
        /// </summary>
        internal bool IsSetNullValue() => this.NullValue != null;
    }
}
