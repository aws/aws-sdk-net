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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about the state of any changes to the ECR automated re-scan duration setting.
    /// </summary>
    public partial class EcrRescanDurationState
    {
        private EcrRescanDuration _rescanDuration;
        private EcrRescanDurationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property RescanDuration. 
        /// <para>
        /// The ECR automated re-scan duration defines how long an ECR image will be actively
        /// scanned by Amazon Inspector. When the number of days since an image was last pushed
        /// exceeds the automated re-scan duration the monitoring state of that image becomes
        /// <code>inactive</code> and all associated findings are scheduled for closure.
        /// </para>
        /// </summary>
        public EcrRescanDuration RescanDuration
        {
            get { return this._rescanDuration; }
            set { this._rescanDuration = value; }
        }

        // Check to see if RescanDuration property is set
        internal bool IsSetRescanDuration()
        {
            return this._rescanDuration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of changes to the ECR automated re-scan duration.
        /// </para>
        /// </summary>
        public EcrRescanDurationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// A timestamp representing when the last time the ECR scan duration setting was changed.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}