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
    /// Container for the parameters to the DescribeInstancesHealth operation.
    /// Retrieves detailed information about the health of instances in your Elastic Beanstalk
    /// environments. This operation requires <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced.html">enhanced
    /// health reporting</a>.
    /// 
    ///  
    /// <para>
    /// This action only returns information about environments that the calling principle
    /// has IAM permissions to access. For example, consider a case where a user only has
    /// permission to access one of three environments. When the user calls this action, the
    /// response will only include the one environment that the user has permission to access
    /// instead of all three environments. If the user doesn’t have access to any of the environments
    /// an empty result is returned.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/aws-managed-policy/latest/reference/AWSElasticBeanstalkReadOnly.html">AWSElasticBeanstalkReadOnly</a>
    /// managed policy allows operators to view information about resources related to Elastic
    /// Beanstalk environments. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html">
    /// Managing Elastic Beanstalk user policies</a> in the <i>Elastic Beanstalk Developer
    /// Guide</i>. For detailed instructions to attach a policy to a user or group, see the
    /// section <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#iam-userpolicies-managed">
    /// Controlling access with managed policies</a> in the same topic.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeInstancesHealthRequest : AmazonElasticBeanstalkRequest
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _environmentId;
        private string _environmentName;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// Specifies the response elements you wish to receive. To retrieve all attributes, set
        /// to <c>All</c>. If no attribute names are specified, returns a list of instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// Specify the Elastic Beanstalk environment by ID.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// Specify the Elastic Beanstalk environment by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token returned by a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}