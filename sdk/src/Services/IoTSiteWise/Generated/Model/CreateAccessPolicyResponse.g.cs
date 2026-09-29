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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessPolicy operation.
    /// </summary>
    public partial class CreateAccessPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessPolicyArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the access policy, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:access-policy/${AccessPolicyId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string AccessPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyArn property is set.
        /// </summary>
        internal bool IsSetAccessPolicyArn() => this.AccessPolicyArn != null;

        /// <summary>
        /// Gets and sets the property AccessPolicyId. 
        /// <para>
        /// The ID of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AccessPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyId property is set.
        /// </summary>
        internal bool IsSetAccessPolicyId() => this.AccessPolicyId != null;
    }
}
