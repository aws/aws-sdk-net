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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about whether DevOps Guru is configured to create an OpsItem in Amazon
    /// Web Services Systems Manager OpsCenter for each created insight. You can use this
    /// to update the configuration.
    /// </summary>
    public partial class OpsCenterIntegrationConfig
    {
        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        ///  Specifies if DevOps Guru is enabled to create an Amazon Web Services Systems Manager
        /// OpsItem for each created insight. 
        /// </para>
        /// </summary>
        public OptInStatus OptInStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptInStatus property is set.
        /// </summary>
        internal bool IsSetOptInStatus() => this.OptInStatus != null;
    }
}
