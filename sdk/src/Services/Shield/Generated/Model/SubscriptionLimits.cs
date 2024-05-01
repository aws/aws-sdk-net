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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings for your subscription.
    /// </summary>
    public partial class SubscriptionLimits
    {
        private ProtectionGroupLimits _protectionGroupLimits;
        private ProtectionLimits _protectionLimits;

        /// <summary>
        /// Gets and sets the property ProtectionGroupLimits. 
        /// <para>
        /// Limits settings on protection groups for your subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionGroupLimits ProtectionGroupLimits
        {
            get { return this._protectionGroupLimits; }
            set { this._protectionGroupLimits = value; }
        }

        // Check to see if ProtectionGroupLimits property is set
        internal bool IsSetProtectionGroupLimits()
        {
            return this._protectionGroupLimits != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectionLimits. 
        /// <para>
        /// Limits settings on protections for your subscription. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionLimits ProtectionLimits
        {
            get { return this._protectionLimits; }
            set { this._protectionLimits = value; }
        }

        // Check to see if ProtectionLimits property is set
        internal bool IsSetProtectionLimits()
        {
            return this._protectionLimits != null;
        }

    }
}