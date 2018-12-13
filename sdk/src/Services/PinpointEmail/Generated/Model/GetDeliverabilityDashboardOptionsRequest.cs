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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetDeliverabilityDashboardOptions operation.
    /// Show the status of the Deliverability dashboard. When the Deliverability dashboard
    /// is enabled, you gain access to reputation metrics for the domains that you use to
    /// send email using Amazon Pinpoint. You also gain the ability to perform predictive
    /// inbox placement tests.
    /// 
    ///  
    /// <para>
    /// When you use the Deliverability dashboard, you pay a monthly charge of USD$1,250.00,
    /// in addition to any other fees that you accrue by using Amazon Pinpoint. If you enable
    /// the Deliverability dashboard after the first day of a calendar month, AWS prorates
    /// the monthly charge based on how many days have elapsed in the current calendar month.
    /// </para>
    /// </summary>
    public partial class GetDeliverabilityDashboardOptionsRequest : AmazonPinpointEmailRequest
    {

    }
}