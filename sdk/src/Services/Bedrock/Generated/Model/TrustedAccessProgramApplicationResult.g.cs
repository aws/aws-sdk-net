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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Result of preparing an application. A provider handoff does not submit an application,
    /// grant eligibility, or change enrollment. Clients must tolerate unknown union members.
    /// </summary>
    public partial class TrustedAccessProgramApplicationResult
    {
        /// <summary>
        /// Gets and sets the property ProviderHandoff. 
        /// <para>
        /// Information for continuing the application with the provider.
        /// </para>
        /// </summary>
        public TrustedAccessProgramProviderHandoff ProviderHandoff { get; set; }

        /// <summary>
        /// Checks to see if the ProviderHandoff property is set.
        /// </summary>
        internal bool IsSetProviderHandoff() => this.ProviderHandoff != null;
    }
}
