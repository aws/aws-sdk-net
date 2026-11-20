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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Exactly one of the members is set: `none` for no custom domain, or `acmManaged` to
    /// bring a domain + ACM certificate. Modeled as a union so the "exactly one" choice is
    /// enforced by type.
    /// </summary>
    public partial class EndpointConfigurationRequest
    {
        /// <summary>
        /// Gets and sets the property AcmManaged. Serve the portal on your own domain, using
        /// a certificate from AWS Certificate Manager.
        /// </summary>
        public ACMManaged AcmManaged { get; set; }

        /// <summary>
        /// Checks to see if the AcmManaged property is set.
        /// </summary>
        internal bool IsSetAcmManaged() => this.AcmManaged != null;

        /// <summary>
        /// Gets and sets the property None. Serve the portal only on its default domain.
        /// </summary>
        public None None { get; set; }

        /// <summary>
        /// Checks to see if the None property is set.
        /// </summary>
        internal bool IsSetNone() => this.None != null;
    }
}
