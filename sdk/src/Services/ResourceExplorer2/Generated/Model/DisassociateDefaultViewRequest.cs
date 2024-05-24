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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateDefaultView operation.
    /// After you call this operation, the affected Amazon Web Services Region no longer has
    /// a default view. All <a>Search</a> operations in that Region must explicitly specify
    /// a view or the operation fails. You can configure a new default by calling the <a>AssociateDefaultView</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// If an Amazon Web Services Region doesn't have a default view configured, then users
    /// must explicitly specify a view with every <c>Search</c> operation performed in that
    /// Region.
    /// </para>
    /// </summary>
    public partial class DisassociateDefaultViewRequest : AmazonResourceExplorer2Request
    {

    }
}