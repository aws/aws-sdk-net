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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteExtensionAssociation operation.
    /// Deletes an extension association. This action doesn't delete extensions defined in
    /// the association.
    /// </summary>
    public partial class DeleteExtensionAssociationRequest : AmazonAppConfigRequest
    {
        private string _extensionAssociationId;

        /// <summary>
        /// Gets and sets the property ExtensionAssociationId. 
        /// <para>
        /// The ID of the extension association to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExtensionAssociationId
        {
            get { return this._extensionAssociationId; }
            set { this._extensionAssociationId = value; }
        }

        // Check to see if ExtensionAssociationId property is set
        internal bool IsSetExtensionAssociationId()
        {
            return this._extensionAssociationId != null;
        }

    }
}