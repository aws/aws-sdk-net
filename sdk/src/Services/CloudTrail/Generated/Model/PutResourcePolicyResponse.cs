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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the PutResourcePolicy operation.
    /// </summary>
    public partial class PutResourcePolicyResponse : AmazonWebServiceResponse
    {
        private string _delegatedAdminResourcePolicy;
        private string _resourceArn;
        private string _resourcePolicy;

        /// <summary>
        /// Gets and sets the property DelegatedAdminResourcePolicy. 
        /// <para>
        ///  The default resource-based policy that is automatically generated for the delegated
        /// administrator of an Organizations organization. This policy will be evaluated in tandem
        /// with any policy you submit for the resource. For more information about this policy,
        /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-lake-organizations.html#cloudtrail-lake-organizations-eds-rbp">Default
        /// resource policy for delegated administrators</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string DelegatedAdminResourcePolicy
        {
            get { return this._delegatedAdminResourcePolicy; }
            set { this._delegatedAdminResourcePolicy = value; }
        }

        // Check to see if DelegatedAdminResourcePolicy property is set
        internal bool IsSetDelegatedAdminResourcePolicy()
        {
            return this._delegatedAdminResourcePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the CloudTrail event data store, dashboard, or
        /// channel attached to the resource-based policy. 
        /// </para>
        ///  
        /// <para>
        /// Example event data store ARN format: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example dashboard ARN format: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example channel ARN format: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        ///  The JSON-formatted string of the Amazon Web Services resource-based policy attached
        /// to the CloudTrail event data store, dashboard, or channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

    }
}