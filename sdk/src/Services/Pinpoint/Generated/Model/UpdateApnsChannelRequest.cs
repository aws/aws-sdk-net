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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApnsChannel operation.
    /// Enables the APNs channel for an application or updates the status and settings of
    /// the APNs channel for an application.
    /// </summary>
    public partial class UpdateApnsChannelRequest : AmazonPinpointRequest
    {
        private APNSChannelRequest _apnsChannelRequest;
        private string _applicationId;

        /// <summary>
        /// Gets and sets the property APNSChannelRequest.
        /// </summary>
        [AWSProperty(Required=true)]
        public APNSChannelRequest APNSChannelRequest
        {
            get { return this._apnsChannelRequest; }
            set { this._apnsChannelRequest = value; }
        }

        // Check to see if APNSChannelRequest property is set
        internal bool IsSetAPNSChannelRequest()
        {
            return this._apnsChannelRequest != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

    }
}