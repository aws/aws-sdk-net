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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Cors
    {
        private bool? _allowCredentials;
        private List<string> _allowHeaders = new List<string>();
        private List<string> _allowMethods = new List<string>();
        private List<string> _allowOrigins = new List<string>();
        private List<string> _exposeHeaders = new List<string>();
        private int? _maxAge;

        /// <summary>
        /// Gets and sets the property AllowCredentials.
        /// </summary>
        public bool AllowCredentials
        {
            get { return this._allowCredentials.GetValueOrDefault(); }
            set { this._allowCredentials = value; }
        }

        // Check to see if AllowCredentials property is set
        internal bool IsSetAllowCredentials()
        {
            return this._allowCredentials.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowHeaders.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> AllowHeaders
        {
            get { return this._allowHeaders; }
            set { this._allowHeaders = value; }
        }

        // Check to see if AllowHeaders property is set
        internal bool IsSetAllowHeaders()
        {
            return this._allowHeaders != null && this._allowHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowMethods.
        /// </summary>
        [AWSProperty(Max=6)]
        public List<string> AllowMethods
        {
            get { return this._allowMethods; }
            set { this._allowMethods = value; }
        }

        // Check to see if AllowMethods property is set
        internal bool IsSetAllowMethods()
        {
            return this._allowMethods != null && this._allowMethods.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowOrigins.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> AllowOrigins
        {
            get { return this._allowOrigins; }
            set { this._allowOrigins = value; }
        }

        // Check to see if AllowOrigins property is set
        internal bool IsSetAllowOrigins()
        {
            return this._allowOrigins != null && this._allowOrigins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExposeHeaders.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> ExposeHeaders
        {
            get { return this._exposeHeaders; }
            set { this._exposeHeaders = value; }
        }

        // Check to see if ExposeHeaders property is set
        internal bool IsSetExposeHeaders()
        {
            return this._exposeHeaders != null && this._exposeHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxAge.
        /// </summary>
        [AWSProperty(Min=0, Max=86400)]
        public int MaxAge
        {
            get { return this._maxAge.GetValueOrDefault(); }
            set { this._maxAge = value; }
        }

        // Check to see if MaxAge property is set
        internal bool IsSetMaxAge()
        {
            return this._maxAge.HasValue; 
        }

    }
}