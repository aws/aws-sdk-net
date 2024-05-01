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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the DisableSecurityHub operation.
    /// Disables Security Hub in your account only in the current Amazon Web Services Region.
    /// To disable Security Hub in all Regions, you must submit one request per Region where
    /// you have enabled Security Hub.
    /// 
    ///  
    /// <para>
    /// You can't disable Security Hub in an account that is currently the Security Hub administrator.
    /// </para>
    ///  
    /// <para>
    /// When you disable Security Hub, your existing findings and insights and any Security
    /// Hub configuration settings are deleted after 90 days and cannot be recovered. Any
    /// standards that were enabled are disabled, and your administrator and member account
    /// associations are removed.
    /// </para>
    ///  
    /// <para>
    /// If you want to save your existing findings, you must export them before you disable
    /// Security Hub.
    /// </para>
    /// </summary>
    public partial class DisableSecurityHubRequest : AmazonSecurityHubRequest
    {

    }
}