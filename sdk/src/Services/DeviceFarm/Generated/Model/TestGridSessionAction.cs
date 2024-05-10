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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// An action taken by a <a>TestGridSession</a> browser instance.
    /// </summary>
    public partial class TestGridSessionAction
    {
        private string _action;
        private long? _duration;
        private string _requestMethod;
        private DateTime? _started;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken by the session.
        /// </para>
        /// </summary>
        public string Action
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// The time, in milliseconds, that the action took to complete in the browser.
        /// </para>
        /// </summary>
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// HTTP method that the browser used to make the request.
        /// </para>
        /// </summary>
        public string RequestMethod
        {
            get { return this._requestMethod; }
            set { this._requestMethod = value; }
        }

        // Check to see if RequestMethod property is set
        internal bool IsSetRequestMethod()
        {
            return this._requestMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The time that the session invoked the action.
        /// </para>
        /// </summary>
        public DateTime? Started
        {
            get { return this._started; }
            set { this._started = value; }
        }

        // Check to see if Started property is set
        internal bool IsSetStarted()
        {
            return this._started.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// HTTP status code returned to the browser when the action was taken.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}