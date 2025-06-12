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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the PutRumEvents operation.
    /// Sends telemetry events about your application performance and user behavior to CloudWatch
    /// RUM. The code snippet that RUM generates for you to add to your application includes
    /// <c>PutRumEvents</c> operations to send this data to RUM.
    /// 
    ///  
    /// <para>
    /// Each <c>PutRumEvents</c> operation can send a batch of events from one user session.
    /// </para>
    /// </summary>
    public partial class PutRumEventsRequest : AmazonCloudWatchRUMRequest
    {
        private string _alias;
        private AppMonitorDetails _appMonitorDetails;
        private string _batchId;
        private string _id;
        private List<RumEvent> _rumEvents = AWSConfigs.InitializeCollections ? new List<RumEvent>() : null;
        private UserDetails _userDetails;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// If the app monitor uses a resource-based policy that requires <c>PutRumEvents</c>
        /// requests to specify a certain alias, specify that alias here. This alias will be compared
        /// to the <c>rum:alias</c> context key in the resource-based policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-resource-policies.html">Using
        /// resource-based policies with CloudWatch RUM</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._rumEvents != null && (this._rumEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
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