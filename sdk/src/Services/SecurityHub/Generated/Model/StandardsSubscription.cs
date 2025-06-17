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
    /// A resource that represents your subscription to a supported standard.
    /// </summary>
    public partial class StandardsSubscription
    {
        private string _standardsArn;
        private StandardsControlsUpdatable _standardsControlsUpdatable;
        private Dictionary<string, string> _standardsInput = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private StandardsStatus _standardsStatus;
        private StandardsStatusReason _standardsStatusReason;
        private string _standardsSubscriptionArn;

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The ARN of the standard.
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
        /// Gets and sets the property StandardsControlsUpdatable. 
        /// <para>
        /// Specifies whether you can retrieve information about and configure individual controls
        /// that apply to the standard. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READY_FOR_UPDATES</c> - Controls in the standard can be retrieved and configured.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_READY_FOR_UPDATES</c> - Controls in the standard cannot be retrieved or configured.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StandardsControlsUpdatable StandardsControlsUpdatable
        {
            get { return this._standardsControlsUpdatable; }
            set { this._standardsControlsUpdatable = value; }
        }

        // Check to see if StandardsControlsUpdatable property is set
        internal bool IsSetStandardsControlsUpdatable()
        {
            return this._standardsControlsUpdatable != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsInput. 
        /// <para>
        /// A key-value pair of input for the standard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._standardsInput != null && (this._standardsInput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StandardsStatus. 
        /// <para>
        /// The status of your subscription to the standard. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The standard is in the process of being enabled. Or the standard
        /// is already enabled and Security Hub is adding new controls to the standard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> - The standard is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCOMPLETE</c> - The standard could not be enabled completely. One or more errors
        /// (<c>StandardsStatusReason</c>) occurred when Security Hub attempted to enable the
        /// standard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The standard is in the process of being disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The standard could not be disabled. One or more errors (<c>StandardsStatusReason</c>)
        /// occurred when Security Hub attempted to disable the standard.
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
        /// The ARN of the resource that represents your subscription to the standard.
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