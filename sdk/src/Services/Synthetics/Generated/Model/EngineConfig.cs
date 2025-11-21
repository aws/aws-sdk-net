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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure of engine configurations for the canary, one for each browser type that
    /// the canary is configured to run on.
    /// </summary>
    public partial class EngineConfig
    {
        private BrowserType _browserType;
        private string _engineArn;

        /// <summary>
        /// Gets and sets the property BrowserType. 
        /// <para>
        /// The browser type associated with this engine configuration.
        /// </para>
        /// </summary>
        public BrowserType BrowserType
        {
            get { return this._browserType; }
            set { this._browserType = value; }
        }

        // Check to see if BrowserType property is set
        internal bool IsSetBrowserType()
        {
            return this._browserType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineArn. 
        /// <para>
        /// Each engine configuration contains the ARN of the Lambda function that is used as
        /// the canary's engine for a specific browser type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EngineArn
        {
            get { return this._engineArn; }
            set { this._engineArn = value; }
        }

        // Check to see if EngineArn property is set
        internal bool IsSetEngineArn()
        {
            return this._engineArn != null;
        }

    }
}