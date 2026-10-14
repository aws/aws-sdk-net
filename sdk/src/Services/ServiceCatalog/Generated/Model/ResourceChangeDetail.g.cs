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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a change to a resource attribute.
    /// </summary>
    public partial class ResourceChangeDetail
    {
        /// <summary>
        /// Gets and sets the property CausingEntity. 
        /// <para>
        /// The ID of the entity that caused the change.
        /// </para>
        /// </summary>
        public string CausingEntity { get; set; }

        /// <summary>
        /// Checks to see if the CausingEntity property is set.
        /// </summary>
        internal bool IsSetCausingEntity() => this.CausingEntity != null;

        /// <summary>
        /// Gets and sets the property Evaluation. 
        /// <para>
        /// For static evaluations, the value of the resource attribute will change and the new
        /// value is known. For dynamic evaluations, the value might change, and any new value
        /// will be determined when the plan is updated.
        /// </para>
        /// </summary>
        public EvaluationType Evaluation { get; set; }

        /// <summary>
        /// Checks to see if the Evaluation property is set.
        /// </summary>
        internal bool IsSetEvaluation() => this.Evaluation != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Information about the resource attribute to be modified.
        /// </para>
        /// </summary>
        public ResourceTargetDefinition Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
