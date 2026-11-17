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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// A target that invokes nothing. Elemental Inference evaluates your request expression,
    /// then evaluates your response expression against that result. If the function has no
    /// response expression, Elemental Inference stores the result of the request expression.
    /// 
    /// 
    ///  
    /// <para>
    /// A passthrough function can't reference media.frames. It also needs no access role
    /// on the feed. 
    /// </para>
    /// </summary>
    public partial class PassthroughFunctionTarget
    {
    }
}
