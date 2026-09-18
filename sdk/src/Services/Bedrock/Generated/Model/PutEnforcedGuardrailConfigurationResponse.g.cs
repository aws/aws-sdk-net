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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the PutEnforcedGuardrailConfiguration operation.
    /// </summary>
    public partial class PutEnforcedGuardrailConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// Unique ID for the account enforced configuration.
        /// </para>
        /// </summary>
        public string ConfigId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigId property is set.
        /// </summary>
        internal bool IsSetConfigId() => this.ConfigId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the role used to update the configuration.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
