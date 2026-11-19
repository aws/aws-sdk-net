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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFieldLevelEncryptionConfig operation. Update
    /// a field-level encryption configuration.
    /// </summary>
    public partial class UpdateFieldLevelEncryptionConfigRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionConfig. 
        /// <para>
        /// Request to update a field-level encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldLevelEncryptionConfig FieldLevelEncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the FieldLevelEncryptionConfig property is set.
        /// </summary>
        internal bool IsSetFieldLevelEncryptionConfig() => this.FieldLevelEncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the configuration you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <c>ETag</c> header that you received when retrieving the configuration
        /// identity to update. For example: <c>E2QWRUHAPOMQZL</c>.
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;
    }
}
