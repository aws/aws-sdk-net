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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Details of code review settings
    /// </summary>
    public partial class CodeReviewSettings
    {
        private bool? _controlsScanning;
        private bool? _generalPurposeScanning;

        /// <summary>
        /// Gets and sets the property ControlsScanning. 
        /// <para>
        /// Whether Controls are utilized for code review analysis
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ControlsScanning
        {
            get { return this._controlsScanning; }
            set { this._controlsScanning = value; }
        }

        // Check to see if ControlsScanning property is set
        internal bool IsSetControlsScanning()
        {
            return this._controlsScanning.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeneralPurposeScanning. 
        /// <para>
        /// Whether general purpose analysis is performed for code review
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? GeneralPurposeScanning
        {
            get { return this._generalPurposeScanning; }
            set { this._generalPurposeScanning = value; }
        }

        // Check to see if GeneralPurposeScanning property is set
        internal bool IsSetGeneralPurposeScanning()
        {
            return this._generalPurposeScanning.HasValue; 
        }

    }
}