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
    /// The operation that uses this structure is retired. Amazon Redshift automatically determines
    /// whether to use AQUA (Advanced Query Accelerator).
    /// </summary>
    public partial class AquaConfiguration
    {
        /// <summary>
        /// Gets and sets the property AquaConfigurationStatus. 
        /// <para>
        /// This field is retired. Amazon Redshift automatically determines whether to use AQUA
        /// (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaConfigurationStatus AquaConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AquaConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetAquaConfigurationStatus() => this.AquaConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property AquaStatus. 
        /// <para>
        /// This field is retired. Amazon Redshift automatically determines whether to use AQUA
        /// (Advanced Query Accelerator).
        /// </para>
        /// </summary>
        public AquaStatus AquaStatus { get; set; }

        /// <summary>
        /// Checks to see if the AquaStatus property is set.
        /// </summary>
        internal bool IsSetAquaStatus() => this.AquaStatus != null;
    }
}
