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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A configuration object that specifies the destination of an event after Lambda processes
    /// it. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations">Adding
    /// a destination</a>.
    /// </summary>
    public partial class DestinationConfig
    {
        private OnFailure _onFailure;
        private OnSuccess _onSuccess;

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The destination configuration for failed invocations.
        /// </para>
        /// </summary>
        public OnFailure OnFailure
        {
            get { return this._onFailure; }
            set { this._onFailure = value; }
        }

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this._onFailure != null;
        }

        /// <summary>
        /// Gets and sets the property OnSuccess. 
        /// <para>
        /// The destination configuration for successful invocations. Not supported in <c>CreateEventSourceMapping</c>
        /// or <c>UpdateEventSourceMapping</c>.
        /// </para>
        /// </summary>
        public OnSuccess OnSuccess
        {
            get { return this._onSuccess; }
            set { this._onSuccess = value; }
        }

        // Check to see if OnSuccess property is set
        internal bool IsSetOnSuccess()
        {
            return this._onSuccess != null;
        }

    }
}