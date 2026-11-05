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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// The executed proof's program. Further members, such as command, workingDirectory and
    /// supportingInputs, can be added later as optional details.
    /// </summary>
    public partial class ValidationProofCode
    {
        /// <summary>
        /// Gets and sets the property ProofCode. Proof program files, main file first, in their
        /// retained order.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public List<ValidationProofMaterial> ProofCode { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidationProofMaterial>() : null;

        /// <summary>
        /// Checks to see if the ProofCode property is set.
        /// </summary>
        internal bool IsSetProofCode() => this.ProofCode != null && (this.ProofCode.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
