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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the GetBlockPublicAccessConfiguration operation.
    /// </summary>
    public partial class GetBlockPublicAccessConfigurationResponse : AmazonWebServiceResponse
    {
        private BlockPublicAccessConfiguration _blockPublicAccessConfiguration;
        private BlockPublicAccessConfigurationMetadata _blockPublicAccessConfigurationMetadata;

        /// <summary>
        /// Gets and sets the property BlockPublicAccessConfiguration. 
        /// <para>
        /// A configuration for Amazon EMR block public access. The configuration applies to all
        /// clusters created in your account for the current Region. The configuration specifies
        /// whether block public access is enabled. If block public access is enabled, security
        /// groups associated with the cluster cannot have rules that allow inbound traffic from
        /// 0.0.0.0/0 or ::/0 on a port, unless the port is specified as an exception using <c>PermittedPublicSecurityGroupRuleRanges</c>
        /// in the <c>BlockPublicAccessConfiguration</c>. By default, Port 22 (SSH) is an exception,
        /// and public access is allowed on this port. You can change this by updating the block
        /// public access configuration to remove the exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// For accounts that created clusters in a Region before November 25, 2019, block public
        /// access is disabled by default in that Region. To use this feature, you must manually
        /// enable and configure it. For accounts that did not create an Amazon EMR cluster in
        /// a Region before this date, block public access is enabled by default in that Region.
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

        /// <summary>
        /// Gets and sets the property BlockPublicAccessConfigurationMetadata. 
        /// <para>
        /// Properties that describe the Amazon Web Services principal that created the <c>BlockPublicAccessConfiguration</c>
        /// using the <c>PutBlockPublicAccessConfiguration</c> action as well as the date and
        /// time that the configuration was created. Each time a configuration for block public
        /// access is updated, Amazon EMR updates this metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BlockPublicAccessConfigurationMetadata BlockPublicAccessConfigurationMetadata
        {
            get { return this._blockPublicAccessConfigurationMetadata; }
            set { this._blockPublicAccessConfigurationMetadata = value; }
        }

        // Check to see if BlockPublicAccessConfigurationMetadata property is set
        internal bool IsSetBlockPublicAccessConfigurationMetadata()
        {
            return this._blockPublicAccessConfigurationMetadata != null;
        }

    }
}