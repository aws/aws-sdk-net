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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Describes a single calling action the business can take with an end user, including
    /// whether the action is currently allowed and any limits that apply to it. Returned
    /// as an item in the actions list from <c>GetWhatsAppCallPermission</c>.
    /// </summary>
    public partial class WhatsAppCallPermissionAction
    {
        private string _actionName;
        private bool? _canPerformAction;
        private List<WhatsAppCallPermissionLimit> _limits = AWSConfigs.InitializeCollections ? new List<WhatsAppCallPermissionLimit>() : null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the calling action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property CanPerformAction. 
        /// <para>
        /// Specifies whether the business can currently perform the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? CanPerformAction
        {
            get { return this._canPerformAction; }
            set { this._canPerformAction = value; }
        }

        // Check to see if CanPerformAction property is set
        internal bool IsSetCanPerformAction()
        {
            return this._canPerformAction.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The time-bound limits that apply to the action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<WhatsAppCallPermissionLimit> Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null && (this._limits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}