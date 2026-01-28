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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Container for the parameters to the StartQuotaUtilizationReport operation.
    /// Initiates the generation of a quota utilization report for your Amazon Web Services
    /// account. This asynchronous operation analyzes your quota usage across all Amazon Web
    /// Services services and returns a unique report identifier that you can use to retrieve
    /// the results.
    /// 
    ///  
    /// <para>
    /// The report generation process may take several seconds to complete, depending on the
    /// number of quotas in your account. Use the <c>GetQuotaUtilizationReport</c> operation
    /// to check the status and retrieve the results when the report is ready.
    /// </para>
    /// </summary>
    public partial class StartQuotaUtilizationReportRequest : AmazonServiceQuotasRequest
    {

    }
}