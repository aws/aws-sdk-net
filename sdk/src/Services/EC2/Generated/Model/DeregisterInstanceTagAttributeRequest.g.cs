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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the tag keys to deregister for the current Region. You can either
    /// specify individual tag keys or deregister all tag keys in the current Region. You
    /// must specify either <c>IncludeAllTagsOfInstance</c> or <c>InstanceTagKeys</c> in the
    /// request
    /// </summary>
    public partial class DeregisterInstanceTagAttributeRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeAllTagsOfInstance. 
        /// <para>
        /// Indicates whether to deregister all tag keys in the current Region. Specify <c>false</c>
        /// to deregister all tag keys.
        /// </para>
        /// </summary>
        public bool? IncludeAllTagsOfInstance { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAllTagsOfInstance property is set.
        /// </summary>
        internal bool IsSetIncludeAllTagsOfInstance() => this.IncludeAllTagsOfInstance.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceTagKeys. 
        /// <para>
        /// Information about the tag keys to deregister.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTagKeys property is set.
        /// </summary>
        internal bool IsSetInstanceTagKeys() => this.InstanceTagKeys != null && (this.InstanceTagKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
