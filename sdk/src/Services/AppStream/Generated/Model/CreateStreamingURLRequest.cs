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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamingURL operation.
    /// Gives a URL to start a AppStream stream for a user. The URL is valid only for 1 minute
    /// from the time that it is generated.
    /// </summary>
    public partial class CreateStreamingURLRequest : AmazonAppStreamRequest
    {
        private string _applicationId;
        private string _fleetName;
        private string _sessionContext;
        private string _stackName;
        private string _userId;
        private long? _validity;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// ID of the application that must be launched after the session starts.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The fleet for which the URL is generated.
        /// </para>
        /// </summary>
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionContext. 
        /// <para>
        /// The sessionContext of the AppStream stream.
        /// </para>
        /// </summary>
        public string SessionContext
        {
            get { return this._sessionContext; }
            set { this._sessionContext = value; }
        }

        // Check to see if SessionContext property is set
        internal bool IsSetSessionContext()
        {
            return this._sessionContext != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The stack for which the URL is generated.
        /// </para>
        /// </summary>
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// A unique user ID for which the URL is generated.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// The validity duration of the URL in seconds.
        /// </para>
        /// </summary>
        public long Validity
        {
            get { return this._validity.GetValueOrDefault(); }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity.HasValue; 
        }

    }
}