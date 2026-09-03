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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about an API call that was observed as part of an activity.
    /// </summary>
    public partial class ApiCall
    {
        private string _error;
        private string _operation;
        private string _service;
        private string _userAgent;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error code that was returned, if the API call failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The name of the API operation that was invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service that the API operation was invoked against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// User agent in the request to the API operation
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UserAgent
        {
            get { return this._userAgent; }
            set { this._userAgent = value; }
        }

        // Check to see if UserAgent property is set
        internal bool IsSetUserAgent()
        {
            return this._userAgent != null;
        }

    }
}