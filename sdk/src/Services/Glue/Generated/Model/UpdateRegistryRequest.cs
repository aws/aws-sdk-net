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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegistry operation.
    /// Updates an existing registry which is used to hold a collection of schemas. The updated
    /// properties relate to the registry, and do not modify any of the schemas within the
    /// registry.
    /// </summary>
    public partial class UpdateRegistryRequest : AmazonGlueRequest
    {
        private string _description;
        private RegistryId _registryId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the registry. If description is not provided, this field will not
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// This is a wrapper structure that may contain the registry name and Amazon Resource
        /// Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryId RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

    }
}