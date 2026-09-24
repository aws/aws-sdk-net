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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// This is the response object from the CreateConfig operation.
    /// </summary>
    public partial class CreateConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigArn. 
        /// <para>
        /// ARN of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 424)]
        public string ConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigArn property is set.
        /// </summary>
        internal bool IsSetConfigArn() => this.ConfigArn != null;

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// UUID of a <c>Config</c>.
        /// </para>
        /// </summary>
        public string ConfigId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigId property is set.
        /// </summary>
        internal bool IsSetConfigId() => this.ConfigId != null;

        /// <summary>
        /// Gets and sets the property ConfigType. 
        /// <para>
        /// Type of a <c>Config</c>.
        /// </para>
        /// </summary>
        public ConfigCapabilityType ConfigType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigType property is set.
        /// </summary>
        internal bool IsSetConfigType() => this.ConfigType != null;
    }
}
