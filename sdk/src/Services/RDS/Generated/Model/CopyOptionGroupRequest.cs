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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyOptionGroup operation.
    /// Copies the specified option group.
    /// </summary>
    public partial class CopyOptionGroupRequest : AmazonRDSRequest
    {
        private string _sourceOptionGroupIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetOptionGroupDescription;
        private string _targetOptionGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceOptionGroupIdentifier. 
        /// <para>
        /// The identifier for the source option group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid option group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceOptionGroupIdentifier
        {
            get { return this._sourceOptionGroupIdentifier; }
            set { this._sourceOptionGroupIdentifier = value; }
        }

        // Check to see if SourceOptionGroupIdentifier property is set
        internal bool IsSetSourceOptionGroupIdentifier()
        {
            return this._sourceOptionGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TargetOptionGroupDescription. 
        /// <para>
        /// The description for the copied option group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetOptionGroupDescription
        {
            get { return this._targetOptionGroupDescription; }
            set { this._targetOptionGroupDescription = value; }
        }

        // Check to see if TargetOptionGroupDescription property is set
        internal bool IsSetTargetOptionGroupDescription()
        {
            return this._targetOptionGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TargetOptionGroupIdentifier. 
        /// <para>
        /// The identifier for the copied option group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be null, empty, or blank
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-option-group</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetOptionGroupIdentifier
        {
            get { return this._targetOptionGroupIdentifier; }
            set { this._targetOptionGroupIdentifier = value; }
        }

        // Check to see if TargetOptionGroupIdentifier property is set
        internal bool IsSetTargetOptionGroupIdentifier()
        {
            return this._targetOptionGroupIdentifier != null;
        }

    }
}