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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamingURL operation.
    /// Creates a temporary URL to start an AppStream 2.0 streaming session for the specified
    /// user. A streaming URL enables application streaming to be tested without user setup.
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
        /// The name of the application to launch after the session starts. This is the name that
        /// you specified as <b>Name</b> in the Image Assistant. If your fleet is enabled for
        /// the <b>Desktop</b> stream view, you can also choose to launch directly to the operating
        /// system desktop. To do so, specify <b>Desktop</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The session context. For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/managing-stacks-fleets.html#managing-stacks-fleets-parameters">Session
        /// Context</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The name of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=32)]
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
        /// The time that the streaming URL will be valid, in seconds. Specify a value between
        /// 1 and 604800 seconds. The default is 60 seconds.
        /// </para>
        /// </summary>
        public long? Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity.HasValue; 
        }

    }
}