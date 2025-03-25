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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStandardsControl operation.
    /// Used to control whether an individual security standard control is enabled or disabled.
    /// 
    ///  
    /// <para>
    /// Calls to this operation return a <c>RESOURCE_NOT_FOUND_EXCEPTION</c> error when the
    /// standard subscription for the control has <c>StandardsControlsUpdatable</c> value
    /// <c>NOT_READY_FOR_UPDATES</c>.
    /// </para>
    /// </summary>
    public partial class UpdateStandardsControlRequest : AmazonSecurityHubRequest
    {
        private ControlStatus _controlStatus;
        private string _disabledReason;
        private string _standardsControlArn;

        /// <summary>
        /// Gets and sets the property ControlStatus. 
        /// <para>
        /// The updated status of the security standard control.
        /// </para>
        /// </summary>
        public ControlStatus ControlStatus
        {
            get { return this._controlStatus; }
            set { this._controlStatus = value; }
        }

        // Check to see if ControlStatus property is set
        internal bool IsSetControlStatus()
        {
            return this._controlStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// A description of the reason why you are disabling a security standard control. If
        /// you are disabling a control, then this is required.
        /// </para>
        /// </summary>
        public string DisabledReason
        {
            get { return this._disabledReason; }
            set { this._disabledReason = value; }
        }

        // Check to see if DisabledReason property is set
        internal bool IsSetDisabledReason()
        {
            return this._disabledReason != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsControlArn. 
        /// <para>
        /// The ARN of the security standard control to enable or disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsControlArn
        {
            get { return this._standardsControlArn; }
            set { this._standardsControlArn = value; }
        }

        // Check to see if StandardsControlArn property is set
        internal bool IsSetStandardsControlArn()
        {
            return this._standardsControlArn != null;
        }

    }
}