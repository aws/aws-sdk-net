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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A notification summary return object.
    /// </summary>
    public partial class NotificationSummary
    {
        private LensUpgradeSummary _lensUpgradeSummary;
        private NotificationType _type;

        /// <summary>
        /// Gets and sets the property LensUpgradeSummary. 
        /// <para>
        /// Summary of lens upgrade.
        /// </para>
        /// </summary>
        public LensUpgradeSummary LensUpgradeSummary
        {
            get { return this._lensUpgradeSummary; }
            set { this._lensUpgradeSummary = value; }
        }

        // Check to see if LensUpgradeSummary property is set
        internal bool IsSetLensUpgradeSummary()
        {
            return this._lensUpgradeSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of notification.
        /// </para>
        /// </summary>
        public NotificationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}