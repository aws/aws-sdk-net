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
    /// A resource that represents your subscription to a supported standard.
    /// </summary>
    public partial class StandardsSubscription
    {
        private string _standardsArn;
        private Dictionary<string, string> _standardsInput = new Dictionary<string, string>();
        private StandardsStatus _standardsStatus;
        private StandardsStatusReason _standardsStatusReason;
        private string _standardsSubscriptionArn;

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The ARN of a standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsInput. 
        /// <para>
        /// A key-value pair of input for the standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> StandardsInput
        {
            get { return this._standardsInput; }
            set { this._standardsInput = value; }
        }

        // Check to see if StandardsInput property is set
        internal bool IsSetStandardsInput()
        {
            return this._standardsInput != null && this._standardsInput.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StandardsStatus. 
        /// <para>
        /// The status of the standard subscription.
        /// </para>
        ///  
        /// <para>
        /// The status values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> - Standard is in the process of being enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>READY</code> - Standard is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INCOMPLETE</code> - Standard could not be enabled completely. Some controls
        /// may not be available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Standard is in the process of being disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - Standard could not be disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StandardsStatus StandardsStatus
        {
            get { return this._standardsStatus; }
            set { this._standardsStatus = value; }
        }

        // Check to see if StandardsStatus property is set
        internal bool IsSetStandardsStatus()
        {
            return this._standardsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsStatusReason. 
        /// <para>
        /// The reason for the current status.
        /// </para>
        /// </summary>
        public StandardsStatusReason StandardsStatusReason
        {
            get { return this._standardsStatusReason; }
            set { this._standardsStatusReason = value; }
        }

        // Check to see if StandardsStatusReason property is set
        internal bool IsSetStandardsStatusReason()
        {
            return this._standardsStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsSubscriptionArn. 
        /// <para>
        /// The ARN of a resource that represents your subscription to a supported standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsSubscriptionArn
        {
            get { return this._standardsSubscriptionArn; }
            set { this._standardsSubscriptionArn = value; }
        }

        // Check to see if StandardsSubscriptionArn property is set
        internal bool IsSetStandardsSubscriptionArn()
        {
            return this._standardsSubscriptionArn != null;
        }

    }
}