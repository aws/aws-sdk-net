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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Map of MediaLive pipeline IDs to the ARNs of the MediaConnect Router Inputs to which
    /// this Output is connected.
    /// </summary>
    public partial class MediaConnectRouterOutputConnectionMap
    {
        private string _pipeline0;
        private string _pipeline1;

        /// <summary>
        /// Gets and sets the property Pipeline0. The ARN of the MediaConnect Router Input connected
        /// to pipeline 0.
        /// </summary>
        public string Pipeline0
        {
            get { return this._pipeline0; }
            set { this._pipeline0 = value; }
        }

        // Check to see if Pipeline0 property is set
        internal bool IsSetPipeline0()
        {
            return this._pipeline0 != null;
        }

        /// <summary>
        /// Gets and sets the property Pipeline1. The ARN of the MediaConnect Router Input connected
        /// to pipeline 1.
        /// </summary>
        public string Pipeline1
        {
            get { return this._pipeline1; }
            set { this._pipeline1 = value; }
        }

        // Check to see if Pipeline1 property is set
        internal bool IsSetPipeline1()
        {
            return this._pipeline1 != null;
        }

    }
}