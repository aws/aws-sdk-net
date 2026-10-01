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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroupCertificateAuthority operation. Creates
    /// a CA for the group. If a CA already exists, it will rotate the existing CA.
    /// </summary>
    public partial class CreateGroupCertificateAuthorityRequest : AmazonGreengrassRequest
    {
        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken { get; set; }

        /// <summary>
        /// Checks to see if the AmznClientToken property is set.
        /// </summary>
        internal bool IsSetAmznClientToken() => this.AmznClientToken != null;

        /// <summary>
        /// Gets and sets the property GroupId. The ID of the Greengrass group.
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;
    }
}
