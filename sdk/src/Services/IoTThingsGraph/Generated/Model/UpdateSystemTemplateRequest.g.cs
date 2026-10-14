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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSystemTemplate operation. Updates the specified
    /// system. You don't need to run this action after updating a workflow. Any deployment
    /// that uses the system will see the changes in the system when it is redeployed.
    /// </summary>
    public partial class UpdateSystemTemplateRequest : AmazonIoTThingsGraphRequest
    {
        /// <summary>
        /// Gets and sets the property CompatibleNamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the latest version is used by default.
        /// </para>
        /// </summary>
        public long? CompatibleNamespaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the CompatibleNamespaceVersion property is set.
        /// </summary>
        internal bool IsSetCompatibleNamespaceVersion() => this.CompatibleNamespaceVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The <c>DefinitionDocument</c> that contains the updated system definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefinitionDocument Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the system to be updated.
        /// </para>
        ///  
        /// <para>
        /// The ID should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>urn:tdm:REGION/ACCOUNT ID/default:system:SYSTEMNAME</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 160)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
