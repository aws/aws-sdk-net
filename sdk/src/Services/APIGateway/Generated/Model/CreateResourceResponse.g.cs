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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// This is the response object from the CreateResource operation.
    /// </summary>
    public partial class CreateResourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The resource's identifier.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent resource's identifier.
        /// </para>
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Checks to see if the ParentId property is set.
        /// </summary>
        internal bool IsSetParentId() => this.ParentId != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The full path for this resource.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property PathPart. 
        /// <para>
        /// The last path segment for this resource.
        /// </para>
        /// </summary>
        public string PathPart { get; set; }

        /// <summary>
        /// Checks to see if the PathPart property is set.
        /// </summary>
        internal bool IsSetPathPart() => this.PathPart != null;

        /// <summary>
        /// Gets and sets the property ResourceMethods. 
        /// <para>
        /// Gets an API resource's method of a given HTTP verb.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Method> ResourceMethods { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Method>() : null;

        /// <summary>
        /// Checks to see if the ResourceMethods property is set.
        /// </summary>
        internal bool IsSetResourceMethods() => this.ResourceMethods != null && (this.ResourceMethods.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
