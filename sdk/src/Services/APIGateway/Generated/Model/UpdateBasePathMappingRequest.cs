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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBasePathMapping operation.
    /// Changes information about the BasePathMapping resource.
    /// </summary>
    public partial class UpdateBasePathMappingRequest : AmazonAPIGatewayRequest
    {
        private string _basePath;
        private string _domainName;
        private string _domainNameId;
        private List<PatchOperation> _patchOperations = AWSConfigs.InitializeCollections ? new List<PatchOperation>() : null;

        /// <summary>
        /// Gets and sets the property BasePath. 
        /// <para>
        /// The base path of the BasePathMapping resource to change.
        /// </para>
        ///  
        /// <para>
        /// To specify an empty base path, set this parameter to <c>'(none)'</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BasePath
        {
            get { return this._basePath; }
            set { this._basePath = value; }
        }

        // Check to see if BasePath property is set
        internal bool IsSetBasePath()
        {
            return this._basePath != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the BasePathMapping resource to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameId. 
        /// <para>
        ///  The identifier for the domain name resource. Supported only for private custom domain
        /// names. 
        /// </para>
        /// </summary>
        public string DomainNameId
        {
            get { return this._domainNameId; }
            set { this._domainNameId = value; }
        }

        // Check to see if DomainNameId property is set
        internal bool IsSetDomainNameId()
        {
            return this._domainNameId != null;
        }

        /// <summary>
        /// Gets and sets the property PatchOperations. 
        /// <para>
        /// For more information about supported patch operations, see <a href="https://docs.aws.amazon.com/apigateway/latest/api/patch-operations.html">Patch
        /// Operations</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PatchOperation> PatchOperations
        {
            get { return this._patchOperations; }
            set { this._patchOperations = value; }
        }

        // Check to see if PatchOperations property is set
        internal bool IsSetPatchOperations()
        {
            return this._patchOperations != null && (this._patchOperations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}