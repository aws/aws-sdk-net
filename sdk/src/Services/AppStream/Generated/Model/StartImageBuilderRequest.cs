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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the StartImageBuilder operation.
    /// Starts the specified image builder.
    /// </summary>
    public partial class StartImageBuilderRequest : AmazonAppStreamRequest
    {
        private string _appstreamAgentVersion;
        private string _name;

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the AppStream 2.0 agent to use for this image builder. To use the latest
        /// version of the AppStream 2.0 agent, specify [LATEST]. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AppstreamAgentVersion
        {
            get { return this._appstreamAgentVersion; }
            set { this._appstreamAgentVersion = value; }
        }

        // Check to see if AppstreamAgentVersion property is set
        internal bool IsSetAppstreamAgentVersion()
        {
            return this._appstreamAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}