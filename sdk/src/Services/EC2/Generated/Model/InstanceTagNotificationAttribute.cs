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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Describes the registered tag keys for the current Region.
    /// </summary>
    public partial class InstanceTagNotificationAttribute
    {
        private bool? _includeAllTagsOfInstance;
        private List<string> _instanceTagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IncludeAllTagsOfInstance. 
        /// <para>
        /// Indicates wheter all tag keys in the current Region are registered to appear in scheduled
        /// event notifications. <c>true</c> indicates that all tag keys in the current Region
        /// are registered.
        /// </para>
        /// </summary>
        public bool? IncludeAllTagsOfInstance
        {
            get { return this._includeAllTagsOfInstance; }
            set { this._includeAllTagsOfInstance = value; }
        }

        // Check to see if IncludeAllTagsOfInstance property is set
        internal bool IsSetIncludeAllTagsOfInstance()
        {
            return this._includeAllTagsOfInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTagKeys. 
        /// <para>
        /// The registered tag keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTagKeys
        {
            get { return this._instanceTagKeys; }
            set { this._instanceTagKeys = value; }
        }

        // Check to see if InstanceTagKeys property is set
        internal bool IsSetInstanceTagKeys()
        {
            return this._instanceTagKeys != null && (this._instanceTagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}