/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountSettings operation.
    /// Returns a customer's account settings.
    /// 
    ///  
    /// <para>
    /// You can use this operation to retrieve Lambda limit information such as code size
    /// and concurrency limits. For more information on limits, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/limits.html">AWS
    /// Lambda Limits</a>. You can also retrieve resource usage statistics such as code storage
    /// usage and function count.
    /// </para>
    /// </summary>
    public partial class GetAccountSettingsRequest : AmazonLambdaRequest
    {

    }
}