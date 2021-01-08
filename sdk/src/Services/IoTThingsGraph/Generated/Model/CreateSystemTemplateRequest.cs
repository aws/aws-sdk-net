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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSystemTemplate operation.
    /// Creates a system. The system is validated against the entities in the latest version
    /// of the user's namespace unless another namespace version is specified in the request.
    /// </summary>
    public partial class CreateSystemTemplateRequest : AmazonIoTThingsGraphRequest
    {
        private long? _compatibleNamespaceVersion;
        private DefinitionDocument _definition;

        /// <summary>
        /// Gets and sets the property CompatibleNamespaceVersion. 
        /// <para>
        /// The namespace version in which the system is to be created.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the latest version is used by default.
        /// </para>
        /// </summary>
        public long CompatibleNamespaceVersion
        {
            get { return this._compatibleNamespaceVersion.GetValueOrDefault(); }
            set { this._compatibleNamespaceVersion = value; }
        }

        // Check to see if CompatibleNamespaceVersion property is set
        internal bool IsSetCompatibleNamespaceVersion()
        {
            return this._compatibleNamespaceVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The <code>DefinitionDocument</code> used to create the system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefinitionDocument Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

    }
}