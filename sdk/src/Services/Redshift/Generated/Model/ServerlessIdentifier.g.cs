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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The identifier for a serverless namespace.
    /// </summary>
    public partial class ServerlessIdentifier
    {
        /// <summary>
        /// Gets and sets the property NamespaceIdentifier. 
        /// <para>
        /// The unique identifier for the serverless namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string NamespaceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceIdentifier property is set.
        /// </summary>
        internal bool IsSetNamespaceIdentifier() => this.NamespaceIdentifier != null;

        /// <summary>
        /// Gets and sets the property WorkgroupIdentifier. 
        /// <para>
        /// The unique identifier for the workgroup associated with the serverless namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string WorkgroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupIdentifier property is set.
        /// </summary>
        internal bool IsSetWorkgroupIdentifier() => this.WorkgroupIdentifier != null;
    }
}
