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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Container for the parameters to the ListModels operation.
    /// Lists all available AI models that can be used for workflow execution, including their
    /// status and compatibility information.
    /// </summary>
    public partial class ListModelsRequest : AmazonNovaActRequest
    {
        private int? _clientCompatibilityVersion;

        /// <summary>
        /// Gets and sets the property ClientCompatibilityVersion. 
        /// <para>
        /// The client compatibility version to filter models by compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ClientCompatibilityVersion
        {
            get { return this._clientCompatibilityVersion.GetValueOrDefault(); }
            set { this._clientCompatibilityVersion = value; }
        }

        // Check to see if ClientCompatibilityVersion property is set
        internal bool IsSetClientCompatibilityVersion()
        {
            return this._clientCompatibilityVersion.HasValue; 
        }

    }
}