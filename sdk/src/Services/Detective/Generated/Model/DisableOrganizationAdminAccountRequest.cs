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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the DisableOrganizationAdminAccount operation.
    /// Removes the Detective administrator account in the current Region. Deletes the organization
    /// behavior graph.
    /// 
    ///  
    /// <para>
    /// Can only be called by the organization management account.
    /// </para>
    ///  
    /// <para>
    /// Removing the Detective administrator account does not affect the delegated administrator
    /// account for Detective in Organizations.
    /// </para>
    ///  
    /// <para>
    /// To remove the delegated administrator account in Organizations, use the Organizations
    /// API. Removing the delegated administrator account also removes the Detective administrator
    /// account in all Regions, except for Regions where the Detective administrator account
    /// is the organization management account.
    /// </para>
    /// </summary>
    public partial class DisableOrganizationAdminAccountRequest : AmazonDetectiveRequest
    {

    }
}