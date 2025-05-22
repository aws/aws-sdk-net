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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// Set to <c>True</c> to automatically generate an endpoint name for a one-click Autopilot
        /// model deployment; set to <c>False</c> otherwise. The default value is <c>False</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <c>AutoGenerateEndpointName</c> to <c>True</c>, do not specify the <c>EndpointName</c>;
        /// otherwise a 400 error is thrown.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? AutoGenerateEndpointName
        {
            get { return this._autoGenerateEndpointName; }
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
        /// Specify the <c>EndpointName</c> if and only if you set <c>AutoGenerateEndpointName</c>
        /// to <c>False</c>; otherwise a 400 error is thrown.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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