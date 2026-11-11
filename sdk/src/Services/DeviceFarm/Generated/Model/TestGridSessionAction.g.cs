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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action taken by the session.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The time, in milliseconds, that the action took to complete in the browser.
        /// </para>
        /// </summary>
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// HTTP method that the browser used to make the request.
        /// </para>
        /// </summary>
        public string RequestMethod { get; set; }

        /// <summary>
        /// Checks to see if the RequestMethod property is set.
        /// </summary>
        internal bool IsSetRequestMethod() => this.RequestMethod != null;

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The time that the session invoked the action.
        /// </para>
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Checks to see if the Started property is set.
        /// </summary>
        internal bool IsSetStarted() => this.Started.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// HTTP status code returned to the browser when the action was taken.
        /// </para>
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;
    }
}
