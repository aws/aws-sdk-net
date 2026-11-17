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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// How a dataset generation was asked to choose sessions. Filters are returned as submitted.
    /// Session and trace IDs are returned as counts, and the IDs themselves are never returned.
    /// </summary>
    public partial class GenerationSelectionRecord
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters the generation was started with.
        /// </para>
        /// </summary>
        public GenerationFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// The number of session and trace IDs the generation was started with.
        /// </para>
        /// </summary>
        public GenerationIdentifierCounts Identifiers { get; set; }

        /// <summary>
        /// Checks to see if the Identifiers property is set.
        /// </summary>
        internal bool IsSetIdentifiers() => this.Identifiers != null;
    }
}
