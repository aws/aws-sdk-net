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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The parameters for EventBridge to use when invoking the resource endpoint.
    /// </summary>
    public partial class ConnectivityResourceParameters
    {
        private ConnectivityResourceConfigurationArn _resourceParameters;

        /// <summary>
        /// Gets and sets the property ResourceParameters. 
        /// <para>
        /// The parameters for EventBridge to use when invoking the resource endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectivityResourceConfigurationArn ResourceParameters
        {
            get { return this._resourceParameters; }
            set { this._resourceParameters = value; }
        }

        // Check to see if ResourceParameters property is set
        internal bool IsSetResourceParameters()
        {
            return this._resourceParameters != null;
        }

    }
}