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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourcesSummary operation.
    /// Get counts of Proton resources.
    /// 
    ///  
    /// <para>
    /// For infrastructure-provisioning resources (environments, services, service instances,
    /// pipelines), the action returns staleness counts. A resource is stale when it's behind
    /// the recommended version of the Proton template that it uses and it needs an update
    /// to become current.
    /// </para>
    ///  
    /// <para>
    /// The action returns staleness counts (counts of resources that are up-to-date, behind
    /// a template major version, or behind a template minor version), the total number of
    /// resources, and the number of resources that are in a failed state, grouped by resource
    /// type. Components, environments, and service templates return less information - see
    /// the <code>components</code>, <code>environments</code>, and <code>serviceTemplates</code>
    /// field descriptions.
    /// </para>
    ///  
    /// <para>
    /// For context, the action also returns the total number of each type of Proton template
    /// in the Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/monitoring-dashboard.html">Proton
    /// dashboard</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetResourcesSummaryRequest : AmazonProtonRequest
    {

    }
}