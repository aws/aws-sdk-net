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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToOnPremisesInstances operation.
    /// Adds tags to on-premises instances.
    /// </summary>
    public partial class AddTagsToOnPremisesInstancesRequest : AmazonCodeDeployRequest
    {
        private List<string> _instanceNames = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// The names of the on-premises instances to which to add tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceNames
        {
            get { return this._instanceNames; }
            set { this._instanceNames = value; }
        }

        // Check to see if InstanceNames property is set
        internal bool IsSetInstanceNames()
        {
            return this._instanceNames != null && this._instanceNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag key-value pairs to add to the on-premises instances.
        /// </para>
        ///  
        /// <para>
        /// Keys and values are both required. Keys cannot be null or empty strings. Value-only
        /// tags are not allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}