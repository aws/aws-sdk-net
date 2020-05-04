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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Provides messages from the service about jobs that you have already successfully submitted.
    /// </summary>
    public partial class JobMessages
    {
        private List<string> _info = new List<string>();
        private List<string> _warning = new List<string>();

        /// <summary>
        /// Gets and sets the property Info. List of messages that are informational only and
        /// don't indicate a problem with your job.
        /// </summary>
        public List<string> Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info != null && this._info.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Warning. List of messages that warn about conditions that
        /// might cause your job not to run or to fail.
        /// </summary>
        public List<string> Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null && this._warning.Count > 0; 
        }

    }
}