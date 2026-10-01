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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// This is the response object from the RegisterService operation.
    /// </summary>
    public partial class RegisterServiceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalStep. 
        /// <para>
        /// Indicates if additional steps are required to complete service registration (e.g.,
        /// 3-legged OAuth)
        /// </para>
        /// </summary>
        public AdditionalServiceRegistrationStep AdditionalStep { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalStep property is set.
        /// </summary>
        internal bool IsSetAdditionalStep() => this.AdditionalStep != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the AWS Key Management Service (AWS KMS) customer managed key that's used
        /// to encrypt resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// Service ID - present when registration is complete, absent when additional steps are
        /// required
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the registered Service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
