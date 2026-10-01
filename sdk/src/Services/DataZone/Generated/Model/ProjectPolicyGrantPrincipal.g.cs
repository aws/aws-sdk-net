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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The project policy grant principal.
    /// </summary>
    public partial class ProjectPolicyGrantPrincipal
    {
        /// <summary>
        /// Gets and sets the property ProjectDesignation. 
        /// <para>
        /// The project designation of the project policy grant principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProjectDesignation ProjectDesignation { get; set; }

        /// <summary>
        /// Checks to see if the ProjectDesignation property is set.
        /// </summary>
        internal bool IsSetProjectDesignation() => this.ProjectDesignation != null;

        /// <summary>
        /// Gets and sets the property ProjectGrantFilter. 
        /// <para>
        /// The project grant filter of the project policy grant principal.
        /// </para>
        /// </summary>
        public ProjectGrantFilter ProjectGrantFilter { get; set; }

        /// <summary>
        /// Checks to see if the ProjectGrantFilter property is set.
        /// </summary>
        internal bool IsSetProjectGrantFilter() => this.ProjectGrantFilter != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The project ID of the project policy grant principal.
        /// </para>
        /// </summary>
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
