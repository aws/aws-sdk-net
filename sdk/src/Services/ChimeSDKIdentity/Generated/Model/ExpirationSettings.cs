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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Determines the interval after which an <code>AppInstanceUser</code> is automatically
    /// deleted.
    /// </summary>
    public partial class ExpirationSettings
    {
        private ExpirationCriterion _expirationCriterion;
        private int? _expirationDays;

        /// <summary>
        /// Gets and sets the property ExpirationCriterion. 
        /// <para>
        /// Specifies the conditions under which an <code>AppInstanceUser</code> will expire.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExpirationCriterion ExpirationCriterion
        {
            get { return this._expirationCriterion; }
            set { this._expirationCriterion = value; }
        }

        // Check to see if ExpirationCriterion property is set
        internal bool IsSetExpirationCriterion()
        {
            return this._expirationCriterion != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDays. 
        /// <para>
        /// The period in days after which an <code>AppInstanceUser</code> will be automatically
        /// deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5475)]
        public int ExpirationDays
        {
            get { return this._expirationDays.GetValueOrDefault(); }
            set { this._expirationDays = value; }
        }

        // Check to see if ExpirationDays property is set
        internal bool IsSetExpirationDays()
        {
            return this._expirationDays.HasValue; 
        }

    }
}