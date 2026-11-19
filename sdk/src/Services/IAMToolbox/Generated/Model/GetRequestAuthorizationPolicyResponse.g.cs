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

namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// This is the response object from the GetRequestAuthorizationPolicy operation.
    /// </summary>
    public partial class GetRequestAuthorizationPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The policy document evaluated for the denied request, returned as a JSON object.
        /// </para>
        ///  
        /// <para>
        /// For some AWS services and policy types, this document includes all actions relevant
        /// to the service that processed the denied request, but might omit actions for other
        /// services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => !this.PolicyDocument.IsNull();
    }
}
