/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlowEntitlement operation.
    /// You can change an entitlement's description, subscribers, and encryption. If you change
    /// the subscribers, the service will remove the outputs that are are used by the subscribers
    /// that are removed.
    /// </summary>
    public partial class UpdateFlowEntitlementRequest : AmazonMediaConnectRequest
    {
        private string _description;
        private UpdateEncryption _encryption;
        private string _entitlementArn;
        private string _flowArn;
        private List<string> _subscribers = new List<string>();

        /// <summary>
        /// Gets and sets the property Description. A description of the entitlement. This description
        /// appears only on the AWS Elemental MediaConnect console and will not be seen by the
        /// subscriber or end user.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. The type of encryption that will be used on
        /// the output associated with this entitlement.
        /// </summary>
        public UpdateEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property EntitlementArn. The ARN of the entitlement that you want
        /// to update.
        /// </summary>
        public string EntitlementArn
        {
            get { return this._entitlementArn; }
            set { this._entitlementArn = value; }
        }

        // Check to see if EntitlementArn property is set
        internal bool IsSetEntitlementArn()
        {
            return this._entitlementArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowArn. The flow that is associated with the entitlement
        /// that you want to update.
        /// </summary>
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subscribers. The AWS account IDs that you want to share
        /// your content with. The receiving accounts (subscribers) will be allowed to create
        /// their own flow using your content as the source.
        /// </summary>
        public List<string> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && this._subscribers.Count > 0; 
        }

    }
}