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
    /// This is the response object from the CreateCapability operation.
    /// </summary>
    public partial class CreateCapabilityResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CapabilityArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for a specific Amazon Web Services resource,
        /// such as a capability, partnership, profile, or transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CapabilityArn { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityArn property is set.
        /// </summary>
        internal bool IsSetCapabilityArn() => this.CapabilityArn != null;

        /// <summary>
        /// Gets and sets the property CapabilityId. 
        /// <para>
        /// Returns a system-assigned unique identifier for the capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CapabilityId { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityId property is set.
        /// </summary>
        internal bool IsSetCapabilityId() => this.CapabilityId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Returns a structure that contains the details for a capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapabilityConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp for creation date and time of the capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstructionsDocuments. 
        /// <para>
        /// Returns one or more locations in Amazon S3, each specifying an EDI document that can
        /// be used with this capability. Each item contains the name of the bucket and the key,
        /// to identify the document's location.
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
        /// Returns the name of the capability used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Returns the type of the capability. Currently, only <c>edi</c> is supported.
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
