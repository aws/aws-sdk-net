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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePlatformVersion operation.
    /// Describes a platform version. Provides full details. Compare to <a>ListPlatformVersions</a>,
    /// which provides summary information about a list of platform versions.
    /// 
    ///  
    /// <para>
    /// For definitions of platform version and other platform-related terms, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/platforms-glossary.html">Elastic
    /// Beanstalk Platforms Glossary</a>.
    /// </para>
    ///  
    /// <para>
    /// This action only returns information about resources that the calling principle has
    /// IAM permissions to access. For example, consider a case where a user only has permission
    /// to access one of three resources. When the user calls the this action, the response
    /// will only include the one resource that the user has permission to access instead
    /// of all three resources. If the user doesn’t have access to any of the resources an
    /// empty result is returned.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/aws-managed-policy/latest/reference/AWSElasticBeanstalkReadOnly.html">AWSElasticBeanstalkReadOnly</a>
    /// managed policy allows operators to view information about resources related to Elastic
    /// Beanstalk. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribePlatformVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string _platformArn;

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform version.
        /// </para>
        /// </summary>
        public string PlatformArn
        {
            get { return this._platformArn; }
            set { this._platformArn = value; }
        }

        // Check to see if PlatformArn property is set
        internal bool IsSetPlatformArn()
        {
            return this._platformArn != null;
        }

    }
}