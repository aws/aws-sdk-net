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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLensVersion operation. Create a new lens
    /// version. <para> A lens can have up to 100 versions. </para> <para> Use this operation
    /// to publish a new lens version after you have imported a lens. The <c>LensAlias</c>
    /// is used to identify the lens to be published. The owner of a lens can share the lens
    /// with other Amazon Web Services accounts and users in the same Amazon Web Services
    /// Region. Only the owner of a lens can delete it. </para>
    /// </summary>
    public partial class CreateLensVersionRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property IsMajorVersion. 
        /// <para>
        /// Set to true if this new major lens version.
        /// </para>
        /// </summary>
        public bool? IsMajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsMajorVersion property is set.
        /// </summary>
        internal bool IsSetIsMajorVersion() => this.IsMajorVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LensAlias.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string LensAlias { get; set; }

        /// <summary>
        /// Checks to see if the LensAlias property is set.
        /// </summary>
        internal bool IsSetLensAlias() => this.LensAlias != null;

        /// <summary>
        /// Gets and sets the property LensVersion. 
        /// <para>
        /// The version of the lens being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string LensVersion { get; set; }

        /// <summary>
        /// Checks to see if the LensVersion property is set.
        /// </summary>
        internal bool IsSetLensVersion() => this.LensVersion != null;
    }
}
