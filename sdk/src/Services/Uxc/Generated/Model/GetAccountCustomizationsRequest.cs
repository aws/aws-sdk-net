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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
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
namespace Amazon.Uxc.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountCustomizations operation.
    /// Returns the current account customization settings, including account color, visible
    /// services, and visible Regions. Settings that you have not configured return their
    /// default values: visible Regions and visible services return `null`, and account color
    /// returns `none`.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>visibleServices</c> and <c>visibleRegions</c> settings control only the appearance
    /// of services and Regions in the Amazon Web Services Management Console. They do not
    /// restrict access through the CLI, SDKs, or other APIs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetAccountCustomizationsRequest : AmazonUxcRequest
    {

    }
}