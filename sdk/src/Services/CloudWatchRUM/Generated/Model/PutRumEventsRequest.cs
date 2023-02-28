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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the PutRumEvents operation.
    /// Sends telemetry events about your application performance and user behavior to CloudWatch
    /// RUM. The code snippet that RUM generates for you to add to your application includes
    /// <code>PutRumEvents</code> operations to send this data to RUM.
    /// 
    ///  
    /// <para>
    /// Each <code>PutRumEvents</code> operation can send a batch of events from one user
    /// session.
    /// </para>
    /// </summary>
    public partial class PutRumEventsRequest : AmazonCloudWatchRUMRequest
    {
        private AppMonitorDetails _appMonitorDetails;
        private string _batchId;
        private string _id;
        private List<RumEvent> _rumEvents = new List<RumEvent>();
        private UserDetails _userDetails;

        /// <summary>
        /// Gets and sets the property AppMonitorDetails. 
        /// <para>
        /// A structure that contains information about the app monitor that collected this telemetry
        /// information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppMonitorDetails AppMonitorDetails
        {
            get { return this._appMonitorDetails; }
            set { this._appMonitorDetails = value; }
        }

        // Check to see if AppMonitorDetails property is set
        internal bool IsSetAppMonitorDetails()
        {
            return this._appMonitorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property BatchId. 
        /// <para>
        /// A unique identifier for this batch of RUM event data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BatchId
        {
            get { return this._batchId; }
            set { this._batchId = value; }
        }

        // Check to see if BatchId property is set
        internal bool IsSetBatchId()
        {
            return this._batchId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the app monitor that is sending this data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RumEvents. 
        /// <para>
        /// An array of structures that contain the telemetry event data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RumEvent> RumEvents
        {
            get { return this._rumEvents; }
            set { this._rumEvents = value; }
        }

        // Check to see if RumEvents property is set
        internal bool IsSetRumEvents()
        {
            return this._rumEvents != null && this._rumEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserDetails. 
        /// <para>
        /// A structure that contains information about the user session that this batch of events
        /// was collected from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserDetails UserDetails
        {
            get { return this._userDetails; }
            set { this._userDetails = value; }
        }

        // Check to see if UserDetails property is set
        internal bool IsSetUserDetails()
        {
            return this._userDetails != null;
        }

    }
}