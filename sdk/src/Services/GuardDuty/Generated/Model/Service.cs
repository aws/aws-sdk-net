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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Additional information assigned to the generated finding by GuardDuty.
    /// </summary>
    public partial class Service
    {
        private Action _action;
        private bool? _archived;
        private int? _count;
        private string _detectorId;
        private string _eventFirstSeen;
        private string _eventLastSeen;
        private string _resourceRole;
        private string _serviceName;
        private string _userFeedback;

        /// <summary>
        /// Gets and sets the property Action. Information about the activity described in a finding.
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Archived. Indicates whether this finding is archived.
        /// </summary>
        public bool Archived
        {
            get { return this._archived.GetValueOrDefault(); }
            set { this._archived = value; }
        }

        // Check to see if Archived property is set
        internal bool IsSetArchived()
        {
            return this._archived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. Total count of the occurrences of this finding type.
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. Detector ID for the GuardDuty service.
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property EventFirstSeen. First seen timestamp of the activity that
        /// prompted GuardDuty to generate this finding.
        /// </summary>
        public string EventFirstSeen
        {
            get { return this._eventFirstSeen; }
            set { this._eventFirstSeen = value; }
        }

        // Check to see if EventFirstSeen property is set
        internal bool IsSetEventFirstSeen()
        {
            return this._eventFirstSeen != null;
        }

        /// <summary>
        /// Gets and sets the property EventLastSeen. Last seen timestamp of the activity that
        /// prompted GuardDuty to generate this finding.
        /// </summary>
        public string EventLastSeen
        {
            get { return this._eventLastSeen; }
            set { this._eventLastSeen = value; }
        }

        // Check to see if EventLastSeen property is set
        internal bool IsSetEventLastSeen()
        {
            return this._eventLastSeen != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRole. Resource role information for this finding.
        /// </summary>
        public string ResourceRole
        {
            get { return this._resourceRole; }
            set { this._resourceRole = value; }
        }

        // Check to see if ResourceRole property is set
        internal bool IsSetResourceRole()
        {
            return this._resourceRole != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. The name of the AWS service (GuardDuty) that
        /// generated a finding.
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property UserFeedback. Feedback left about the finding.
        /// </summary>
        public string UserFeedback
        {
            get { return this._userFeedback; }
            set { this._userFeedback = value; }
        }

        // Check to see if UserFeedback property is set
        internal bool IsSetUserFeedback()
        {
            return this._userFeedback != null;
        }

    }
}