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
    /// The properties associated with the data store.
    /// </summary>
    public partial class DatastoreProperties
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the data store was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatastoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the data store.
        /// </para>
        /// </summary>
        public string DatastoreArn { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreArn property is set.
        /// </summary>
        internal bool IsSetDatastoreArn() => this.DatastoreArn != null;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DatastoreName { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreName property is set.
        /// </summary>
        internal bool IsSetDatastoreName() => this.DatastoreName != null;

        /// <summary>
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// The data store status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatastoreStatus DatastoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreStatus property is set.
        /// </summary>
        internal bool IsSetDatastoreStatus() => this.DatastoreStatus != null;

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
        /// The datastore's lossless storage format.
        /// </para>
        /// </summary>
        public LosslessStorageFormat LosslessStorageFormat { get; set; }

        /// <summary>
        /// Checks to see if the LosslessStorageFormat property is set.
        /// </summary>
        internal bool IsSetLosslessStorageFormat() => this.LosslessStorageFormat != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the data store was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
