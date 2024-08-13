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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents the percentage of requests over the last 10 seconds that resulted in each
    /// type of status code response. For more information, see <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec10.html">Status
    /// Code Definitions</a>.
    /// </summary>
    public partial class StatusCodes
    {
        private int? _status2xx;
        private int? _status3xx;
        private int? _status4xx;
        private int? _status5xx;

        /// <summary>
        /// Gets and sets the property Status2xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 2xx (200, 201,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status2xx
        {
            get { return this._status2xx; }
            set { this._status2xx = value; }
        }

        // Check to see if Status2xx property is set
        internal bool IsSetStatus2xx()
        {
            return this._status2xx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status3xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 3xx (300, 301,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status3xx
        {
            get { return this._status3xx; }
            set { this._status3xx = value; }
        }

        // Check to see if Status3xx property is set
        internal bool IsSetStatus3xx()
        {
            return this._status3xx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status4xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 4xx (400, 401,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status4xx
        {
            get { return this._status4xx; }
            set { this._status4xx = value; }
        }

        // Check to see if Status4xx property is set
        internal bool IsSetStatus4xx()
        {
            return this._status4xx.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status5xx. 
        /// <para>
        /// The percentage of requests over the last 10 seconds that resulted in a 5xx (500, 501,
        /// etc.) status code.
        /// </para>
        /// </summary>
        public int? Status5xx
        {
            get { return this._status5xx; }
            set { this._status5xx = value; }
        }

        // Check to see if Status5xx property is set
        internal bool IsSetStatus5xx()
        {
            return this._status5xx.HasValue; 
        }

    }
}