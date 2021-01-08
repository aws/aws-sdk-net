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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the PutBlockPublicAccessConfiguration operation.
    /// Creates or updates an Amazon EMR block public access configuration for your AWS account
    /// in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
    /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
    /// </summary>
    public partial class PutBlockPublicAccessConfigurationRequest : AmazonElasticMapReduceRequest
    {
        private BlockPublicAccessConfiguration _blockPublicAccessConfiguration;

        /// <summary>
        /// Gets and sets the property BlockPublicAccessConfiguration. 
        /// <para>
        /// A configuration for Amazon EMR block public access. The configuration applies to all
        /// clusters created in your account for the current Region. The configuration specifies
        /// whether block public access is enabled. If block public access is enabled, security
        /// groups associated with the cluster cannot have rules that allow inbound traffic from
        /// 0.0.0.0/0 or ::/0 on a port, unless the port is specified as an exception using <code>PermittedPublicSecurityGroupRuleRanges</code>
        /// in the <code>BlockPublicAccessConfiguration</code>. By default, Port 22 (SSH) is an
        /// exception, and public access is allowed on this port. You can change this by updating
        /// <code>BlockPublicSecurityGroupRules</code> to remove the exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// For accounts that created clusters in a Region before November 25, 2019, block public
        /// access is disabled by default in that Region. To use this feature, you must manually
        /// enable and configure it. For accounts that did not create an EMR cluster in a Region
        /// before this date, block public access is enabled by default in that Region.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockPublicAccessConfiguration BlockPublicAccessConfiguration
        {
            get { return this._blockPublicAccessConfiguration; }
            set { this._blockPublicAccessConfiguration = value; }
        }

        // Check to see if BlockPublicAccessConfiguration property is set
        internal bool IsSetBlockPublicAccessConfiguration()
        {
            return this._blockPublicAccessConfiguration != null;
        }

    }
}