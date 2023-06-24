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
    /// The function's Lambda SnapStart setting. Set <code>ApplyOn</code> to <code>PublishedVersions</code>
    /// to create a snapshot of the initialized execution environment when you publish a function
    /// version.
    /// 
    ///  
    /// <para>
    /// SnapStart is supported with the <code>java11</code> runtime. For more information,
    /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/snapstart.html">Improving
    /// startup performance with Lambda SnapStart</a>.
    /// </para>
    /// </summary>
    public partial class SnapStart
    {
        private SnapStartApplyOn _applyOn;

        /// <summary>
        /// Gets and sets the property ApplyOn. 
        /// <para>
        /// Set to <code>PublishedVersions</code> to create a snapshot of the initialized execution
        /// environment when you publish a function version.
        /// </para>
        /// </summary>
        public SnapStartApplyOn ApplyOn
        {
            get { return this._applyOn; }
            set { this._applyOn = value; }
        }

        // Check to see if ApplyOn property is set
        internal bool IsSetApplyOn()
        {
            return this._applyOn != null;
        }

    }
}