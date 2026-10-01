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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CheckNoPublicAccess operation. Checks whether
    /// a resource policy can grant public access to the specified resource type.
    /// </summary>
    public partial class CheckNoPublicAccessRequest : AmazonAccessAnalyzerRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document to evaluate for public access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to evaluate for public access. For example, to check for public
        /// access to Amazon S3 buckets, you can choose <c>AWS::S3::Bucket</c> for the resource
        /// type.
        /// </para>
        ///  
        /// <para>
        /// For resource types not supported as valid values, IAM Access Analyzer will return
        /// an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessCheckResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
