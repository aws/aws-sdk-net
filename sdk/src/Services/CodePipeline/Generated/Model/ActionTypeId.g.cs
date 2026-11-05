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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about an action type.
    /// </summary>
    public partial class ActionTypeId
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A category defines what kind of action can be taken in the stage, and constrains the
        /// provider type for the action. Valid categories are limited to one of the following
        /// values. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Source
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Build
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Test
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deploy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Approval
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Compute
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The creator of the action being called. There are three valid values for the <c>Owner</c>
        /// field in the action category section within your pipeline structure: <c>AWS</c>, <c>ThirdParty</c>,
        /// and <c>Custom</c>. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#actions-valid-providers">Valid
        /// Action Types and Providers in CodePipeline </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionOwner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the service being called by the action. Valid providers are determined
        /// by the action category. For example, an action in the Deploy category type might have
        /// a provider of CodeDeploy, which would be specified as <c>CodeDeploy</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#actions-valid-providers">Valid
        /// Action Types and Providers in CodePipeline </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 35)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A string that describes the action version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 9)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
