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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
    /// Container for the parameters to the CreateInvestigation operation.
    /// This API is currently available as a preview. During the preview, you can initiate
    /// up to 10 investigations per account per day, with a total limit of 100 investigations
    /// per account. This feature is available in the following Amazon Web Services Regions:
    /// US East (N. Virginia), US East (Ohio), US West (Oregon), Canada (Central), Europe
    /// (Frankfurt), Europe (Ireland), Europe (London), Europe (Paris), Europe (Stockholm),
    /// and Asia Pacific (Tokyo).
    /// 
    ///  
    /// <para>
    /// Initiates a GuardDuty investigation that automatically analyzes security findings,
    /// correlates related activity, performs account-level analysis, and produces a structured
    /// investigation summary with recommended next steps.
    /// </para>
    ///  
    /// <para>
    /// Only the administrator account can create an investigation. Member accounts don't
    /// have permission to create investigations from their accounts.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, the <c>AI_ANALYST</c> feature must be enabled on your detector.
    /// </para>
    ///  
    /// <para>
    /// This feature uses Amazon Bedrock models that leverage Cross-Region Inference (CRIS),
    /// which automatically selects the optimal Amazon Web Services Region within your geography
    /// to process the investigation analysis and generate the investigation report. This
    /// maximizes available compute resources, model availability, and delivers the best customer
    /// experience. Your data remains stored only in the Region where the investigation request
    /// originates, however, investigation data and summary results may be processed outside
    /// that Region. All data is transmitted encrypted across Amazon's secure network. For
    /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-investigation.html">GuardDuty
    /// Investigation</a>.
    /// </para>
    /// </summary>
    public partial class CreateInvestigationRequest : AmazonGuardDutyRequest
    {
        private string _clientToken;
        private string _detectorId;
        private string _triggerPrompt;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the create request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector for the account in which the investigation
        /// is created.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerPrompt. 
        /// <para>
        /// A natural-language description of what to investigate. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"Investigate finding 1ab2c3d4e5f6a7b8c9d0e1f2a3b4c5d6 in account 123456789012"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Analyze findings in account with id 123456789012"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"Analyze findings in my organization"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TriggerPrompt
        {
            get { return this._triggerPrompt; }
            set { this._triggerPrompt = value; }
        }

        // Check to see if TriggerPrompt property is set
        internal bool IsSetTriggerPrompt()
        {
            return this._triggerPrompt != null;
        }

    }
}