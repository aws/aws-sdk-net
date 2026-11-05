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
    /// Container for the parameters to the ImportPolicy operation. Imports a V1 policy into
    /// V2, mapping RTO/RPO values from V1 scenarios.
    /// </summary>
    public partial class ImportPolicyRequest : AmazonResiliencehubv2Request
    {
        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The availability SLO to set on the imported policy.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

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
        /// Gets and sets the property MultiAzDisasterRecoveryApproach. 
        /// <para>
        /// The multi-AZ disaster recovery approach for the imported policy.
        /// </para>
        /// </summary>
        public MultiAzDisasterRecoveryApproach MultiAzDisasterRecoveryApproach { get; set; }

        /// <summary>
        /// Checks to see if the MultiAzDisasterRecoveryApproach property is set.
        /// </summary>
        internal bool IsSetMultiAzDisasterRecoveryApproach() => this.MultiAzDisasterRecoveryApproach != null;

        /// <summary>
        /// Gets and sets the property MultiRegionDisasterRecoveryApproach. 
        /// <para>
        /// The multi-Region disaster recovery approach for the imported policy.
        /// </para>
        /// </summary>
        public MultiRegionDisasterRecoveryApproach MultiRegionDisasterRecoveryApproach { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionDisasterRecoveryApproach property is set.
        /// </summary>
        internal bool IsSetMultiRegionDisasterRecoveryApproach() => this.MultiRegionDisasterRecoveryApproach != null;

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
        /// Gets and sets the property V1PolicyArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string V1PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the V1PolicyArn property is set.
        /// </summary>
        internal bool IsSetV1PolicyArn() => this.V1PolicyArn != null;
    }
}
