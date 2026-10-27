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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the GetInvestigation operation. This API is currently
    /// available as a preview. This feature is available in the following Amazon Web Services
    /// Regions: US East (N. Virginia), US East (Ohio), US West (Oregon), Canada (Central),
    /// Europe (Frankfurt), Europe (Ireland), Europe (London), Europe (Paris), Europe (Stockholm),
    /// and Asia Pacific (Tokyo). <para> Retrieves the results and status of a specific GuardDuty
    /// investigation. </para> <para> An administrator account can retrieve any investigation
    /// within the organization. Member accounts can only retrieve investigations that belong
    /// to them. </para>
    /// </summary>
    public partial class GetInvestigationRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with the investigation.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier of the investigation to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;
    }
}
