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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Details about the origin restrictions set on the package. The package origin restrictions
    /// determine how new versions of a package can be added to a specific repository.
    /// </summary>
    public partial class PackageOriginRestrictions
    {
        private AllowPublish _publish;
        private AllowUpstream _upstream;

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// The package origin configuration that determines if new versions of the package can
        /// be published directly to the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowPublish Publish
        {
            get { return this._publish; }
            set { this._publish = value; }
        }

        // Check to see if Publish property is set
        internal bool IsSetPublish()
        {
            return this._publish != null;
        }

        /// <summary>
        /// Gets and sets the property Upstream. 
        /// <para>
        /// The package origin configuration that determines if new versions of the package can
        /// be added to the repository from an external connection or upstream source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowUpstream Upstream
        {
            get { return this._upstream; }
            set { this._upstream = value; }
        }

        // Check to see if Upstream property is set
        internal bool IsSetUpstream()
        {
            return this._upstream != null;
        }

    }
}