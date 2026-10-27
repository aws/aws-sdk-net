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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportApp operation. Imports a V1 app into the
    /// V2 resource model, creating a service with the same name.
    /// </summary>
    public partial class ImportAppRequest : AmazonResiliencehubv2Request
    {
        /// <summary>
        /// Gets and sets the property AssociatedSystems. 
        /// <para>
        /// The systems to associate with the imported service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<AssociatedSystem> AssociatedSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;

        /// <summary>
        /// Checks to see if the AssociatedSystems property is set.
        /// </summary>
        internal bool IsSetAssociatedSystems() => this.AssociatedSystems != null && (this.AssociatedSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property SkipManuallyAddedResources. 
        /// <para>
        /// Whether to skip manually added resources during import.
        /// </para>
        /// </summary>
        public bool? SkipManuallyAddedResources { get; set; }

        /// <summary>
        /// Checks to see if the SkipManuallyAddedResources property is set.
        /// </summary>
        internal bool IsSetSkipManuallyAddedResources() => this.SkipManuallyAddedResources.HasValue;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property V1AppArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string V1AppArn { get; set; }

        /// <summary>
        /// Checks to see if the V1AppArn property is set.
        /// </summary>
        internal bool IsSetV1AppArn() => this.V1AppArn != null;
    }
}
