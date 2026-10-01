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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The scaling configuration for a web function endpoint.
    /// </summary>
    public partial class ScalingConfig
    {
        private int? _maxEnvironments;

        /// <summary>
        /// Gets and sets the property MaxEnvironments. 
        /// <para>
        /// The maximum number of concurrent execution environments for the endpoint. Minimum
        /// value of 2, maximum value of 10000. There is no default value. If you don't specify
        /// a value, the scaling configuration is absent from the response. On an update, omit
        /// <c>scalingConfig</c> to keep the current value, or specify an empty object to clear
        /// a previously set value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10000)]
        public int? MaxEnvironments
        {
            get { return this._maxEnvironments; }
            set { this._maxEnvironments = value; }
        }

        // Check to see if MaxEnvironments property is set
        internal bool IsSetMaxEnvironments()
        {
            return this._maxEnvironments.HasValue; 
        }

    }
}