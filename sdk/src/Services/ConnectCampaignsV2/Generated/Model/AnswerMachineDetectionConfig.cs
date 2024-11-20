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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Answering Machine Detection config
    /// </summary>
    public partial class AnswerMachineDetectionConfig
    {
        private bool? _awaitAnswerMachinePrompt;
        private bool? _enableAnswerMachineDetection;

        /// <summary>
        /// Gets and sets the property AwaitAnswerMachinePrompt. 
        /// <para>
        /// Enable or disable await answer machine prompt
        /// </para>
        /// </summary>
        public bool? AwaitAnswerMachinePrompt
        {
            get { return this._awaitAnswerMachinePrompt; }
            set { this._awaitAnswerMachinePrompt = value; }
        }

        // Check to see if AwaitAnswerMachinePrompt property is set
        internal bool IsSetAwaitAnswerMachinePrompt()
        {
            return this._awaitAnswerMachinePrompt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableAnswerMachineDetection. 
        /// <para>
        /// Enable or disable answering machine detection
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableAnswerMachineDetection
        {
            get { return this._enableAnswerMachineDetection; }
            set { this._enableAnswerMachineDetection = value; }
        }

        // Check to see if EnableAnswerMachineDetection property is set
        internal bool IsSetEnableAnswerMachineDetection()
        {
            return this._enableAnswerMachineDetection.HasValue; 
        }

    }
}