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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for synchronizing registry record metadata from an external source.
    /// </summary>
    public partial class SynchronizationConfiguration
    {
        private FromUrlSynchronizationConfiguration _fromUrl;

        /// <summary>
        /// Gets and sets the property FromUrl. 
        /// <para>
        /// Configuration for synchronizing from a URL-based source.
        /// </para>
        /// </summary>
        public FromUrlSynchronizationConfiguration FromUrl
        {
            get { return this._fromUrl; }
            set { this._fromUrl = value; }
        }

        // Check to see if FromUrl property is set
        internal bool IsSetFromUrl()
        {
            return this._fromUrl != null;
        }

    }
}