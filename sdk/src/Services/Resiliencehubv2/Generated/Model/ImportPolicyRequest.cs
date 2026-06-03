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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
    /// Container for the parameters to the ImportPolicy operation.
    /// Imports a V1 policy into V2, mapping RTO/RPO values from V1 scenarios.
    /// </summary>
    public partial class ImportPolicyRequest : AmazonResiliencehubv2Request
    {
        private AvailabilitySlo _availabilitySlo;
        private string _clientToken;
        private string _kmsKeyId;
        private MultiAzDisasterRecoveryApproach _multiAzDisasterRecoveryApproach;
        private MultiRegionDisasterRecoveryApproach _multiRegionDisasterRecoveryApproach;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _v1PolicyArn;

        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The availability SLO to set on the imported policy.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo
        {
            get { return this._availabilitySlo; }
            set { this._availabilitySlo = value; }
        }

        // Check to see if AvailabilitySlo property is set
        internal bool IsSetAvailabilitySlo()
        {
            return this._availabilitySlo != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAzDisasterRecoveryApproach. 
        /// <para>
        /// The multi-AZ disaster recovery approach for the imported policy.
        /// </para>
        /// </summary>
        public MultiAzDisasterRecoveryApproach MultiAzDisasterRecoveryApproach
        {
            get { return this._multiAzDisasterRecoveryApproach; }
            set { this._multiAzDisasterRecoveryApproach = value; }
        }

        // Check to see if MultiAzDisasterRecoveryApproach property is set
        internal bool IsSetMultiAzDisasterRecoveryApproach()
        {
            return this._multiAzDisasterRecoveryApproach != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionDisasterRecoveryApproach. 
        /// <para>
        /// The multi-Region disaster recovery approach for the imported policy.
        /// </para>
        /// </summary>
        public MultiRegionDisasterRecoveryApproach MultiRegionDisasterRecoveryApproach
        {
            get { return this._multiRegionDisasterRecoveryApproach; }
            set { this._multiRegionDisasterRecoveryApproach = value; }
        }

        // Check to see if MultiRegionDisasterRecoveryApproach property is set
        internal bool IsSetMultiRegionDisasterRecoveryApproach()
        {
            return this._multiRegionDisasterRecoveryApproach != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property V1PolicyArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string V1PolicyArn
        {
            get { return this._v1PolicyArn; }
            set { this._v1PolicyArn = value; }
        }

        // Check to see if V1PolicyArn property is set
        internal bool IsSetV1PolicyArn()
        {
            return this._v1PolicyArn != null;
        }

    }
}