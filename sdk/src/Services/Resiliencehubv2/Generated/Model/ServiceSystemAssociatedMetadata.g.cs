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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Metadata for a service system associated event.
    /// </summary>
    public partial class ServiceSystemAssociatedMetadata
    {
        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string SystemArn { get; set; }

        /// <summary>
        /// Checks to see if the SystemArn property is set.
        /// </summary>
        internal bool IsSetSystemArn() => this.SystemArn != null;

        /// <summary>
        /// Gets and sets the property SystemName. 
        /// <para>
        /// The name of the associated system.
        /// </para>
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Checks to see if the SystemName property is set.
        /// </summary>
        internal bool IsSetSystemName() => this.SystemName != null;
    }
}
