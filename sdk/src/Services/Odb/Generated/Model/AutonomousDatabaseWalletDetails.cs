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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The wallet details for an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseWalletDetails
    {
        private WalletPasswordSourceSummary _passwordSourceSummary;
        private AutonomousDatabaseWalletStatus _status;
        private DateTime? _timeRotated;

        /// <summary>
        /// Gets and sets the property PasswordSourceSummary. 
        /// <para>
        /// The summary of the password source configuration for the Autonomous Database wallet.
        /// </para>
        /// </summary>
        public WalletPasswordSourceSummary PasswordSourceSummary
        {
            get { return this._passwordSourceSummary; }
            set { this._passwordSourceSummary = value; }
        }

        // Check to see if PasswordSourceSummary property is set
        internal bool IsSetPasswordSourceSummary()
        {
            return this._passwordSourceSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous Database wallet.
        /// </para>
        /// </summary>
        public AutonomousDatabaseWalletStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRotated. 
        /// <para>
        /// The date and time when the Autonomous Database wallet was last rotated.
        /// </para>
        /// </summary>
        public DateTime? TimeRotated
        {
            get { return this._timeRotated; }
            set { this._timeRotated = value; }
        }

        // Check to see if TimeRotated property is set
        internal bool IsSetTimeRotated()
        {
            return this._timeRotated.HasValue; 
        }

    }
}