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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Describes the real-time endpoint information for an <c>MLModel</c>.
    /// </summary>
    public partial class RealtimeEndpointInfo
    {
        private DateTime? _createdAt;
        private RealtimeEndpointStatus _endpointStatus;
        private string _endpointUrl;
        private int? _peakRequestsPerSecond;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the request to create the real-time endpoint for the <c>MLModel</c>
        /// was received. The time is expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        ///  The current status of the real-time endpoint for the <c>MLModel</c>. This element
        /// can have one of the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - Endpoint does not exist or was previously deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> - Endpoint is ready to be used for real-time predictions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - Updating/creating the endpoint. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RealtimeEndpointStatus EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URI that specifies where to send real-time prediction requests for the <c>MLModel</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> The application must wait until the real-time endpoint is ready before
        /// using this URI.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string EndpointUrl
        {
            get { return this._endpointUrl; }
            set { this._endpointUrl = value; }
        }

        // Check to see if EndpointUrl property is set
        internal bool IsSetEndpointUrl()
        {
            return this._endpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PeakRequestsPerSecond. 
        /// <para>
        ///  The maximum processing rate for the real-time endpoint for <c>MLModel</c>, measured
        /// in incoming requests per second.
        /// </para>
        /// </summary>
        public int? PeakRequestsPerSecond
        {
            get { return this._peakRequestsPerSecond; }
            set { this._peakRequestsPerSecond = value; }
        }

        // Check to see if PeakRequestsPerSecond property is set
        internal bool IsSetPeakRequestsPerSecond()
        {
            return this._peakRequestsPerSecond.HasValue; 
        }

    }
}