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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCapability operation. Instantiates a capability
    /// based on the specified parameters. A trading capability contains the information required
    /// to transform incoming EDI documents into JSON or XML outputs.
    /// </summary>
    public partial class CreateCapabilityRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies a structure that contains the details for a capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapabilityConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property InstructionsDocuments. 
        /// <para>
        /// Specifies one or more locations in Amazon S3, each specifying an EDI document that
        /// can be used with this capability. Each item contains the name of the bucket and the
        /// key, to identify the document's location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<S3Location> InstructionsDocuments { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Location>() : null;

        /// <summary>
        /// Checks to see if the InstructionsDocuments property is set.
        /// </summary>
        internal bool IsSetInstructionsDocuments() => this.InstructionsDocuments != null && (this.InstructionsDocuments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the capability, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs assigned to ARNs that you can use to group and search
        /// for resources by type. You can attach this metadata to resources (capabilities, partnerships,
        /// and so on) for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of the capability. Currently, only <c>edi</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapabilityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
