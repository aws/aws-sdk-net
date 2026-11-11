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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the PutParameter operation.
    /// </summary>
    public partial class PutParameterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier assigned to the parameter.
        /// </para>
        /// </summary>
        public ParameterTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The new version number of a parameter. If you edit a parameter value, Parameter Store
        /// automatically creates a new version and assigns this new version a unique ID. You
        /// can reference a parameter version ID in API operations or in Systems Manager documents
        /// (SSM documents). By default, if you don't specify a specific version, the system returns
        /// the latest parameter value when a parameter is called.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
