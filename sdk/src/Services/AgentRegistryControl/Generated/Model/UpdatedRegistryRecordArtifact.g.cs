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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// The skill package patch wrapper. Omit to leave the package unchanged; supply an empty
    /// object to remove an uploaded package; supply optionalValue to upload a new package.
    /// </summary>
    public partial class UpdatedRegistryRecordArtifact
    {
        /// <summary>
        /// Gets and sets the property OptionalValue. 
        /// <para>
        /// The skill package to upload. It replaces the record's current package or its synchronized
        /// content.
        /// </para>
        /// </summary>
        public RegistryRecordArtifactUpload OptionalValue { get; set; }

        /// <summary>
        /// Checks to see if the OptionalValue property is set.
        /// </summary>
        internal bool IsSetOptionalValue() => this.OptionalValue != null;
    }
}
