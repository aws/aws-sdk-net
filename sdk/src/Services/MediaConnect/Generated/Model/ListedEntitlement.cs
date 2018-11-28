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
    /// An entitlement that has been granted to you from other AWS accounts.
    /// </summary>
    public partial class ListedEntitlement
    {
        private string _entitlementArn;
        private string _entitlementName;

        /// <summary>
        /// Gets and sets the property EntitlementArn. The ARN of the entitlement.
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
        /// Gets and sets the property EntitlementName. The name of the entitlement.
        /// </summary>
        public string EntitlementName
        {
            get { return this._entitlementName; }
            set { this._entitlementName = value; }
        }

        // Check to see if EntitlementName property is set
        internal bool IsSetEntitlementName()
        {
            return this._entitlementName != null;
        }

    }
}