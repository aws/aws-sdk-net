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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies how to generate the endpoint name for an automatic one-click Autopilot model
    /// deployment.
    /// </summary>
    public partial class ModelDeployConfig
    {
        private bool? _autoGenerateEndpointName;
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property AutoGenerateEndpointName. 
        /// <para>
        /// Set to <code>True</code> to automatically generate an endpoint name for a one-click
        /// Autopilot model deployment; set to <code>False</code> otherwise. The default value
        /// is <code>False</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <code>AutoGenerateEndpointName</code> to <code>True</code>, do not specify
        /// the <code>EndpointName</code>; otherwise a 400 error is thrown.
        /// </para>
        ///  </note>
        /// </summary>
        public bool AutoGenerateEndpointName
        {
            get { return this._autoGenerateEndpointName.GetValueOrDefault(); }
            set { this._autoGenerateEndpointName = value; }
        }

        // Check to see if AutoGenerateEndpointName property is set
        internal bool IsSetAutoGenerateEndpointName()
        {
            return this._autoGenerateEndpointName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// Specifies the endpoint name to use for a one-click Autopilot model deployment if the
        /// endpoint name is not generated automatically.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify the <code>EndpointName</code> if and only if you set <code>AutoGenerateEndpointName</code>
        /// to <code>False</code>; otherwise a 400 error is thrown.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

    }
}