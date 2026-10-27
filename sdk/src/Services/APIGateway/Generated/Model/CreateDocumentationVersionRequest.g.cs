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
    /// Container for the parameters to the CreateDocumentationVersion operation. Creates
    /// a documentation version
    /// </summary>
    public partial class CreateDocumentationVersionRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the new documentation snapshot.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentationVersion. 
        /// <para>
        /// The version identifier of the new snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DocumentationVersion { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationVersion property is set.
        /// </summary>
        internal bool IsSetDocumentationVersion() => this.DocumentationVersion != null;

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The stage name to be associated with the new documentation snapshot.
        /// </para>
        /// </summary>
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;
    }
}
