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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The retry configuration specifies automatic retry for a failed stage, along with the
    /// configured retry mode.
    /// </summary>
    public partial class RetryConfiguration
    {
        private StageRetryMode _retryMode;

        /// <summary>
        /// Gets and sets the property RetryMode. 
        /// <para>
        /// The method that you want to configure for automatic stage retry on stage failure.
        /// You can specify to retry only failed action in the stage or all actions in the stage.
        /// </para>
        /// </summary>
        public StageRetryMode RetryMode
        {
            get { return this._retryMode; }
            set { this._retryMode = value; }
        }

        // Check to see if RetryMode property is set
        internal bool IsSetRetryMode()
        {
            return this._retryMode != null;
        }

    }
}