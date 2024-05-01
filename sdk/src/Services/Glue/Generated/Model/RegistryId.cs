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
    /// A wrapper structure that may contain the registry name and Amazon Resource Name (ARN).
    /// </summary>
    public partial class RegistryId
    {
        private string _registryArn;
        private string _registryName;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// Arn of the registry to be updated. One of <c>RegistryArn</c> or <c>RegistryName</c>
        /// has to be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string RegistryArn
        {
            get { return this._registryArn; }
            set { this._registryArn = value; }
        }

        // Check to see if RegistryArn property is set
        internal bool IsSetRegistryArn()
        {
            return this._registryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// Name of the registry. Used only for lookup. One of <c>RegistryArn</c> or <c>RegistryName</c>
        /// has to be provided. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RegistryName
        {
            get { return this._registryName; }
            set { this._registryName = value; }
        }

        // Check to see if RegistryName property is set
        internal bool IsSetRegistryName()
        {
            return this._registryName != null;
        }

    }
}