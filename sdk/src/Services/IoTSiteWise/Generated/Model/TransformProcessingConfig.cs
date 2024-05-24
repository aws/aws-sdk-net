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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// The processing configuration for the given transform property. You can configure transforms
    /// to be kept at the edge or forwarded to the Amazon Web Services Cloud. You can also
    /// configure transforms to be computed at the edge or in the cloud.
    /// </summary>
    public partial class TransformProcessingConfig
    {
        private ComputeLocation _computeLocation;
        private ForwardingConfig _forwardingConfig;

        /// <summary>
        /// Gets and sets the property ComputeLocation. 
        /// <para>
        /// The compute location for the given transform property. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeLocation ComputeLocation
        {
            get { return this._computeLocation; }
            set { this._computeLocation = value; }
        }

        // Check to see if ComputeLocation property is set
        internal bool IsSetComputeLocation()
        {
            return this._computeLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardingConfig.
        /// </summary>
        public ForwardingConfig ForwardingConfig
        {
            get { return this._forwardingConfig; }
            set { this._forwardingConfig = value; }
        }

        // Check to see if ForwardingConfig property is set
        internal bool IsSetForwardingConfig()
        {
            return this._forwardingConfig != null;
        }

    }
}