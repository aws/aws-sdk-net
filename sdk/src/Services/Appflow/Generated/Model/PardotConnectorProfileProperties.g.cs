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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required when using Salesforce Pardot.
    /// </summary>
    public partial class PardotConnectorProfileProperties
    {
        /// <summary>
        /// Gets and sets the property BusinessUnitId. 
        /// <para>
        /// The business unit id of Salesforce Pardot instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 18)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// Checks to see if the BusinessUnitId property is set.
        /// </summary>
        internal bool IsSetBusinessUnitId() => this.BusinessUnitId != null;

        /// <summary>
        /// Gets and sets the property InstanceUrl. 
        /// <para>
        /// The location of the Salesforce Pardot resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// Checks to see if the InstanceUrl property is set.
        /// </summary>
        internal bool IsSetInstanceUrl() => this.InstanceUrl != null;

        /// <summary>
        /// Gets and sets the property IsSandboxEnvironment. 
        /// <para>
        /// Indicates whether the connector profile applies to a sandbox or production environment.
        /// </para>
        /// </summary>
        public bool? IsSandboxEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the IsSandboxEnvironment property is set.
        /// </summary>
        internal bool IsSetIsSandboxEnvironment() => this.IsSandboxEnvironment.HasValue;
    }
}
