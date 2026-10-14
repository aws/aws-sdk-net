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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGlossaryTerm operation. Creates a glossary
    /// term within a business glossary in Glue Data Catalog.
    /// </summary>
    public partial class CreateGlossaryTermRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property GlossaryIdentifier. 
        /// <para>
        /// The unique identifier of the glossary in which to create the term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GlossaryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlossaryIdentifier property is set.
        /// </summary>
        internal bool IsSetGlossaryIdentifier() => this.GlossaryIdentifier != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A long description of the glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;
    }
}
