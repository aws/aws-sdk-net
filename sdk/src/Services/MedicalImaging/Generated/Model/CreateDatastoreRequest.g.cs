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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatastore operation. Create a data store.
    /// </summary>
    public partial class CreateDatastoreRequest : AmazonMedicalImagingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for API idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the Key Management Service (KMS) key for
        /// accessing encrypted data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerArn. 
        /// <para>
        /// The ARN of the authorizer's Lambda function.
        /// </para>
        /// </summary>
        public string LambdaAuthorizerArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaAuthorizerArn property is set.
        /// </summary>
        internal bool IsSetLambdaAuthorizerArn() => this.LambdaAuthorizerArn != null;

        /// <summary>
        /// Gets and sets the property LosslessStorageFormat. 
        /// <para>
        /// The lossless storage format for the datastore.
        /// </para>
        /// </summary>
        public LosslessStorageFormat LosslessStorageFormat { get; set; }

        /// <summary>
        /// Checks to see if the LosslessStorageFormat property is set.
        /// </summary>
        internal bool IsSetLosslessStorageFormat() => this.LosslessStorageFormat != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags provided when creating a data store.
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
