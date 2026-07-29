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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthCode operation.
    /// Creates an authorization code for the specified Connect Customer instance. The authorization
    /// code can be used to establish a session with scoped permissions defined by the specified
    /// scope parameters.
    /// </summary>
    public partial class CreateAuthCodeRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxSessionDurationMinutes;
        private AuthScope _scope;
        private int? _sessionInactivityDurationMinutes;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDurationMinutes. 
        /// <para>
        /// The maximum duration of the session, in minutes. Minimum value of 1440 (24 hours).
        /// Maximum value of 43200 (30 days). If no value is provided, the session will expire
        /// after 400 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1440, Max=43200)]
        public int? MaxSessionDurationMinutes
        {
            get { return this._maxSessionDurationMinutes; }
            set { this._maxSessionDurationMinutes = value; }
        }

        // Check to see if MaxSessionDurationMinutes property is set
        internal bool IsSetMaxSessionDurationMinutes()
        {
            return this._maxSessionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope for the authorization code. Defines the permissions and access boundaries
        /// for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SessionInactivityDurationMinutes. 
        /// <para>
        /// The duration of inactivity, in minutes, after which the session expires. Minimum value
        /// of 1440 (24 hours). Maximum value of 20160 (14 days).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20160)]
        public int? SessionInactivityDurationMinutes
        {
            get { return this._sessionInactivityDurationMinutes; }
            set { this._sessionInactivityDurationMinutes = value; }
        }

        // Check to see if SessionInactivityDurationMinutes property is set
        internal bool IsSetSessionInactivityDurationMinutes()
        {
            return this._sessionInactivityDurationMinutes.HasValue; 
        }

    }
}