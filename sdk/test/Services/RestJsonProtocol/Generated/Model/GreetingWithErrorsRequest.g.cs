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
    /// Container for the parameters to the GreetingWithErrors operation. This operation has
    /// four possible return values: 1. A successful response in the form of GreetingWithErrorsOutput
    /// 2. An InvalidGreeting error. 3. A BadRequest error. 4. A FooError. Implementations
    /// must be able to successfully take a response and properly (de)serialize successful
    /// and error responses based on the the presence of the
    /// </summary>
    public partial class GreetingWithErrorsRequest : AmazonRestJsonProtocolRequest
    {
    }
}
