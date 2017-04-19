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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The parent object that contains your function's tracing settings.
    /// </summary>
    public partial class TracingConfig
    {
        private TracingMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Can be either PassThrough or Active. If PassThrough, Lambda will only trace the request
        /// from an upstream service if it contains a tracing header with "sampled=1". If Active,
        /// Lambda will respect any tracing header it receives from an upstream service. If no
        /// tracing header is received, Lambda will call X-Ray for a tracing decision.
        /// </para>
        /// </summary>
        public TracingMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}