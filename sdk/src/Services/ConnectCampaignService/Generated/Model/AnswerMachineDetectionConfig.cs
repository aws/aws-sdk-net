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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// Answering Machine Detection config
    /// </summary>
    public partial class AnswerMachineDetectionConfig
    {
        private bool? _enableAnswerMachineDetection;

        /// <summary>
        /// Gets and sets the property EnableAnswerMachineDetection. 
        /// <para>
        /// Enable or disable answering machine detection
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableAnswerMachineDetection
        {
            get { return this._enableAnswerMachineDetection.GetValueOrDefault(); }
            set { this._enableAnswerMachineDetection = value; }
        }

        // Check to see if EnableAnswerMachineDetection property is set
        internal bool IsSetEnableAnswerMachineDetection()
        {
            return this._enableAnswerMachineDetection.HasValue; 
        }

    }
}