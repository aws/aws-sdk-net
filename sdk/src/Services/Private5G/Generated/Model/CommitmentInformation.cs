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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Shows the duration, the date and time that the contract started and ends, and the
    /// renewal status of the commitment period for the radio unit.
    /// </summary>
    public partial class CommitmentInformation
    {
        private CommitmentConfiguration _commitmentConfiguration;
        private DateTime? _expiresOn;
        private DateTime? _startAt;

        /// <summary>
        /// Gets and sets the property CommitmentConfiguration. 
        /// <para>
        /// The duration and renewal status of the commitment period for the radio unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommitmentConfiguration CommitmentConfiguration
        {
            get { return this._commitmentConfiguration; }
            set { this._commitmentConfiguration = value; }
        }

        // Check to see if CommitmentConfiguration property is set
        internal bool IsSetCommitmentConfiguration()
        {
            return this._commitmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresOn. 
        /// <para>
        /// The date and time that the commitment period ends. If you do not cancel or renew the
        /// commitment before the expiration date, you will be billed at the 60-day-commitment
        /// rate.
        /// </para>
        /// </summary>
        public DateTime ExpiresOn
        {
            get { return this._expiresOn.GetValueOrDefault(); }
            set { this._expiresOn = value; }
        }

        // Check to see if ExpiresOn property is set
        internal bool IsSetExpiresOn()
        {
            return this._expiresOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The date and time that the commitment period started.
        /// </para>
        /// </summary>
        public DateTime StartAt
        {
            get { return this._startAt.GetValueOrDefault(); }
            set { this._startAt = value; }
        }

        // Check to see if StartAt property is set
        internal bool IsSetStartAt()
        {
            return this._startAt.HasValue; 
        }

    }
}