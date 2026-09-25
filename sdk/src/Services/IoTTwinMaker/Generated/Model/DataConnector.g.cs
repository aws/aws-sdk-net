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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The data connector.
    /// </summary>
    public partial class DataConnector
    {
        /// <summary>
        /// Gets and sets the property IsNative. 
        /// <para>
        /// A Boolean value that specifies whether the data connector is native to IoT TwinMaker.
        /// </para>
        /// </summary>
        public bool? IsNative { get; set; }

        /// <summary>
        /// Checks to see if the IsNative property is set.
        /// </summary>
        internal bool IsSetIsNative() => this.IsNative.HasValue;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The Lambda function associated with this data connector.
        /// </para>
        /// </summary>
        public LambdaFunction Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;
    }
}
