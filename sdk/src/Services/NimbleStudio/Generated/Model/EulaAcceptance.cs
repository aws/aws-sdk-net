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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The acceptance of a EULA, required to use Amazon-provided streaming images.
    /// </summary>
    public partial class EulaAcceptance
    {
        private DateTime? _acceptedAt;
        private string _acceptedBy;
        private string _accepteeId;
        private string _eulaAcceptanceId;
        private string _eulaId;

        /// <summary>
        /// Gets and sets the property AcceptedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the EULA was accepted.
        /// </para>
        /// </summary>
        public DateTime AcceptedAt
        {
            get { return this._acceptedAt.GetValueOrDefault(); }
            set { this._acceptedAt = value; }
        }

        // Check to see if AcceptedAt property is set
        internal bool IsSetAcceptedAt()
        {
            return this._acceptedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AcceptedBy. 
        /// <para>
        /// The ID of the person who accepted the EULA.
        /// </para>
        /// </summary>
        public string AcceptedBy
        {
            get { return this._acceptedBy; }
            set { this._acceptedBy = value; }
        }

        // Check to see if AcceptedBy property is set
        internal bool IsSetAcceptedBy()
        {
            return this._acceptedBy != null;
        }

        /// <summary>
        /// Gets and sets the property AccepteeId. 
        /// <para>
        /// The ID of the acceptee.
        /// </para>
        /// </summary>
        public string AccepteeId
        {
            get { return this._accepteeId; }
            set { this._accepteeId = value; }
        }

        // Check to see if AccepteeId property is set
        internal bool IsSetAccepteeId()
        {
            return this._accepteeId != null;
        }

        /// <summary>
        /// Gets and sets the property EulaAcceptanceId. 
        /// <para>
        /// The EULA acceptance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string EulaAcceptanceId
        {
            get { return this._eulaAcceptanceId; }
            set { this._eulaAcceptanceId = value; }
        }

        // Check to see if EulaAcceptanceId property is set
        internal bool IsSetEulaAcceptanceId()
        {
            return this._eulaAcceptanceId != null;
        }

        /// <summary>
        /// Gets and sets the property EulaId. 
        /// <para>
        /// The EULA ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string EulaId
        {
            get { return this._eulaId; }
            set { this._eulaId = value; }
        }

        // Check to see if EulaId property is set
        internal bool IsSetEulaId()
        {
            return this._eulaId != null;
        }

    }
}