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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrust operation.
    /// Updates the trust that has been set up between your Managed Microsoft AD directory
    /// and an self-managed Active Directory.
    /// </summary>
    public partial class UpdateTrustRequest : AmazonDirectoryServiceRequest
    {
        private SelectiveAuth _selectiveAuth;
        private string _trustId;

        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Updates selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth
        {
            get { return this._selectiveAuth; }
            set { this._selectiveAuth = value; }
        }

        // Check to see if SelectiveAuth property is set
        internal bool IsSetSelectiveAuth()
        {
            return this._selectiveAuth != null;
        }

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// Identifier of the trust relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrustId
        {
            get { return this._trustId; }
            set { this._trustId = value; }
        }

        // Check to see if TrustId property is set
        internal bool IsSetTrustId()
        {
            return this._trustId != null;
        }

    }
}