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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeHub operation.
    /// </summary>
    public partial class DescribeHubResponse : AmazonWebServiceResponse
    {
        private bool? _autoEnableControls;
        private ControlFindingGenerator _controlFindingGenerator;
        private string _hubArn;
        private string _subscribedAt;

        /// <summary>
        /// Gets and sets the property AutoEnableControls. 
        /// <para>
        /// Whether to automatically enable new controls when they are added to standards that
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// If set to <code>true</code>, then new controls for enabled standards are enabled automatically.
        /// If set to <code>false</code>, then new controls are not enabled.
        /// </para>
        /// </summary>
        public bool AutoEnableControls
        {
            get { return this._autoEnableControls.GetValueOrDefault(); }
            set { this._autoEnableControls = value; }
        }

        // Check to see if AutoEnableControls property is set
        internal bool IsSetAutoEnableControls()
        {
            return this._autoEnableControls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ControlFindingGenerator. 
        /// <para>
        /// Specifies whether the calling account has consolidated control findings turned on.
        /// If the value for this field is set to <code>SECURITY_CONTROL</code>, Security Hub
        /// generates a single finding for a control check even when the check applies to multiple
        /// enabled standards.
        /// </para>
        ///  
        /// <para>
        /// If the value for this field is set to <code>STANDARD_CONTROL</code>, Security Hub
        /// generates separate findings for a control check when the check applies to multiple
        /// enabled standards.
        /// </para>
        ///  
        /// <para>
        /// The value for this field in a member account matches the value in the administrator
        /// account. For accounts that aren't part of an organization, the default value of this
        /// field is <code>SECURITY_CONTROL</code> if you enabled Security Hub on or after February
        /// 9, 2023.
        /// </para>
        /// </summary>
        public ControlFindingGenerator ControlFindingGenerator
        {
            get { return this._controlFindingGenerator; }
            set { this._controlFindingGenerator = value; }
        }

        // Check to see if ControlFindingGenerator property is set
        internal bool IsSetControlFindingGenerator()
        {
            return this._controlFindingGenerator != null;
        }

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The ARN of the Hub resource that was retrieved.
        /// </para>
        /// </summary>
        public string HubArn
        {
            get { return this._hubArn; }
            set { this._hubArn = value; }
        }

        // Check to see if HubArn property is set
        internal bool IsSetHubArn()
        {
            return this._hubArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedAt. 
        /// <para>
        /// The date and time when Security Hub was enabled in the account.
        /// </para>
        /// </summary>
        public string SubscribedAt
        {
            get { return this._subscribedAt; }
            set { this._subscribedAt = value; }
        }

        // Check to see if SubscribedAt property is set
        internal bool IsSetSubscribedAt()
        {
            return this._subscribedAt != null;
        }

    }
}