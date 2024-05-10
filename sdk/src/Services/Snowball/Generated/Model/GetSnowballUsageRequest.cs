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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the GetSnowballUsage operation.
    /// Returns information about the Snow Family service limit for your account, and also
    /// the number of Snow devices your account has in use.
    /// 
    ///  
    /// <para>
    /// The default service limit for the number of Snow devices that you can have at one
    /// time is 1. If you want to increase your service limit, contact Amazon Web Services
    /// Support.
    /// </para>
    /// </summary>
    public partial class GetSnowballUsageRequest : AmazonSnowballRequest
    {

    }
}