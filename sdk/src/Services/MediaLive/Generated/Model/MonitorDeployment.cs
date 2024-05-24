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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Represents the latest monitor deployment of a signal map.
    /// </summary>
    public partial class MonitorDeployment
    {
        private string _detailsUri;
        private string _errorMessage;
        private SignalMapMonitorDeploymentStatus _status;

        /// <summary>
        /// Gets and sets the property DetailsUri. URI associated with a signal map's monitor
        /// deployment.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DetailsUri
        {
            get { return this._detailsUri; }
            set { this._detailsUri = value; }
        }

        // Check to see if DetailsUri property is set
        internal bool IsSetDetailsUri()
        {
            return this._detailsUri != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message associated with a failed monitor
        /// deployment of a signal map.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required=true)]
        public SignalMapMonitorDeploymentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}