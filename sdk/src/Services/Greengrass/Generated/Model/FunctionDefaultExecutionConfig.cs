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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Configuration that defines the default containerization used for when running Lambda
    /// functions in the group. Individual Lambda functions can be override this setting.
    /// </summary>
    public partial class FunctionDefaultExecutionConfig
    {
        private FunctionIsolationMode _isolationMode;

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

    }
}