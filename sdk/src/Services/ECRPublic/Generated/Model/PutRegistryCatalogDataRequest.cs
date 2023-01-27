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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// Container for the parameters to the PutRegistryCatalogData operation.
    /// Create or update the catalog data for a public registry.
    /// </summary>
    public partial class PutRegistryCatalogDataRequest : AmazonECRPublicRequest
    {
        private string _displayName;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for a public registry. The display name is shown as the repository
        /// author in the Amazon ECR Public Gallery.
        /// </para>
        ///  <note> 
        /// <para>
        /// The registry display name is only publicly visible in the Amazon ECR Public Gallery
        /// for verified accounts.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

    }
}