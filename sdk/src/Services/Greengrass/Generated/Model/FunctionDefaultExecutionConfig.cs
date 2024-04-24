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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Configuration information that specifies how a Lambda function runs.
    /// </summary>
    public partial class FunctionDefaultExecutionConfig
    {
        private FunctionIsolationMode _isolationMode;
        private FunctionRunAsConfig _runAs;

        /// <summary>
        /// Gets and sets the property IsolationMode.
        /// </summary>
        public FunctionIsolationMode IsolationMode
        {
            get { return this._isolationMode; }
            set { this._isolationMode = value; }
        }

        // Check to see if IsolationMode property is set
        internal bool IsSetIsolationMode()
        {
            return this._isolationMode != null;
        }

        /// <summary>
        /// Gets and sets the property RunAs.
        /// </summary>
        public FunctionRunAsConfig RunAs
        {
            get { return this._runAs; }
            set { this._runAs = value; }
        }

        // Check to see if RunAs property is set
        internal bool IsSetRunAs()
        {
            return this._runAs != null;
        }

    }
}