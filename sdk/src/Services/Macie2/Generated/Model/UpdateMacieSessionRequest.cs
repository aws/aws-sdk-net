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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMacieSession operation.
    /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
    /// account.
    /// </summary>
    public partial class UpdateMacieSessionRequest : AmazonMacie2Request
    {
        private FindingPublishingFrequency _findingPublishingFrequency;
        private MacieStatus _status;

        /// <summary>
        /// Gets and sets the property FindingPublishingFrequency. 
        /// <para>
        /// Specifies how often to publish updates to policy findings for the account. This includes
        /// publishing updates to Security Hub and Amazon EventBridge (formerly Amazon CloudWatch
        /// Events).
        /// </para>
        /// </summary>
        public FindingPublishingFrequency FindingPublishingFrequency
        {
            get { return this._findingPublishingFrequency; }
            set { this._findingPublishingFrequency = value; }
        }

        // Check to see if FindingPublishingFrequency property is set
        internal bool IsSetFindingPublishingFrequency()
        {
            return this._findingPublishingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies a new status for the account. Valid values are: ENABLED, resume all Amazon
        /// Macie activities for the account; and, PAUSED, suspend all Macie activities for the
        /// account.
        /// </para>
        /// </summary>
        public MacieStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}