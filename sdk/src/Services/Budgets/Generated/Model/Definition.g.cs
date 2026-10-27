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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Specifies all of the type-specific parameters.
    /// </summary>
    public partial class Definition
    {
        /// <summary>
        /// Gets and sets the property IamActionDefinition. 
        /// <para>
        /// The Identity and Access Management (IAM) action definition details. 
        /// </para>
        /// </summary>
        public IamActionDefinition IamActionDefinition { get; set; }

        /// <summary>
        /// Checks to see if the IamActionDefinition property is set.
        /// </summary>
        internal bool IsSetIamActionDefinition() => this.IamActionDefinition != null;

        /// <summary>
        /// Gets and sets the property ScpActionDefinition. 
        /// <para>
        /// The service control policies (SCPs) action definition details. 
        /// </para>
        /// </summary>
        public ScpActionDefinition ScpActionDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ScpActionDefinition property is set.
        /// </summary>
        internal bool IsSetScpActionDefinition() => this.ScpActionDefinition != null;

        /// <summary>
        /// Gets and sets the property SsmActionDefinition. 
        /// <para>
        /// The Amazon Web Services Systems Manager (SSM) action definition details. 
        /// </para>
        /// </summary>
        public SsmActionDefinition SsmActionDefinition { get; set; }

        /// <summary>
        /// Checks to see if the SsmActionDefinition property is set.
        /// </summary>
        internal bool IsSetSsmActionDefinition() => this.SsmActionDefinition != null;
    }
}
