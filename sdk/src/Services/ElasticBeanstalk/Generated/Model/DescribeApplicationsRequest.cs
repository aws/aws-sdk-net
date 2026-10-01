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
    /// Container for the parameters to the DescribeApplications operation.
    /// Returns the descriptions of existing applications.
    /// 
    ///  
    /// <para>
    /// This action only returns information about applications that the calling principle
    /// has IAM permissions to access. For example, consider a case where a user only has
    /// permission to access two of three applications. When the user calls the <i>DescribeApplications</i>
    /// action, the response will only include the two applications that the user has permission
    /// to access instead of all three applications. If the user doesn’t have access to any
    /// of the applications an empty result is returned.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <i>AWSElasticBeanstalkReadOnly</i> managed policy allows operators to view information
    /// about resources related to Elastic Beanstalk environments. For more information, see
    /// <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeApplicationsRequest : AmazonElasticBeanstalkRequest
    {
        private List<string> _applicationNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeApplicationsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationNames. 
        /// <para>
        /// If specified, Elastic Beanstalk restricts the returned descriptions to only include
        /// those with the specified names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicationNames
        {
            get { return this._applicationNames; }
            set { this._applicationNames = value; }
        }

        // Check to see if ApplicationNames property is set
        internal bool IsSetApplicationNames()
        {
            return this._applicationNames != null && (this._applicationNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}