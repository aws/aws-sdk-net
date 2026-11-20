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
    /// This is the response object from the GetTrustedAccessProgramOrganizationEnrollment
    /// operation.
    /// </summary>
    public partial class GetTrustedAccessProgramOrganizationEnrollmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OptIn. 
        /// <para>
        /// Stored preference at the addressed scope. A missing enrollment returns inherit without
        /// updatedAt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessProgramOptIn OptIn { get; set; }

        /// <summary>
        /// Checks to see if the OptIn property is set.
        /// </summary>
        internal bool IsSetOptIn() => this.OptIn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Last change to the stored enrollment. Present whenever a row exists, including an
        /// explicitly stored inherit setting.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
