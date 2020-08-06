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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the EnableHealthServiceAccessForOrganization operation.
    /// Calling this operation enables AWS Health to work with AWS Organizations. This applies
    /// a service-linked role (SLR) to the master account in the organization. To call this
    /// operation, you must sign in as an IAM user, assume an IAM role, or sign in as the
    /// root user (not recommended) in the organization's master account.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
    /// AWS Health events</a> in the <i>AWS Health User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableHealthServiceAccessForOrganizationRequest : AmazonAWSHealthRequest
    {

    }
}