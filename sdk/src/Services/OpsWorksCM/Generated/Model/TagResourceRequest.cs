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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Applies tags to an OpsWorks for Chef Automate or OpsWorks for Puppet Enterprise server,
    /// or to server backups.
    /// </summary>
    public partial class TagResourceRequest : AmazonOpsWorksCMRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of a resource to which you want to apply tags. For
        /// example, <c>arn:aws:opsworks-cm:us-west-2:123456789012:server/test-owcm-server/EXAMPLE-66b0-4196-8274-d1a2bEXAMPLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values to attach to OpsWorks CM servers or backups.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key cannot be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key can be a maximum of 127 characters, and can contain only Unicode letters,
        /// numbers, or separators, or the following special characters: <c>+ - = . _ : /</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value can be a maximum 255 characters, and contain only Unicode letters, numbers,
        /// or separators, or the following special characters: <c>+ - = . _ : /</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leading and trailing white spaces are trimmed from both the key and value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A maximum of 50 user-applied tags is allowed for any OpsWorks CM server or backup.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}