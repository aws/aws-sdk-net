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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBParameterGroup operation. Copies the specified
    /// DB parameter group.
    /// </summary>
    public partial class CopyDBParameterGroupRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property SourceDBParameterGroupIdentifier. 
        /// <para>
        /// The identifier or ARN for the source DB parameter group. For information about creating
        /// an ARN, see <a href="https://docs.aws.amazon.com/neptune/latest/UserGuide/tagging.ARN.html#tagging.ARN.Constructing">
        /// Constructing an Amazon Resource Name (ARN)</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid DB parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must specify a valid DB parameter group identifier, for example <c>my-db-param-group</c>,
        /// or a valid ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The source DB parameter group must be in the same Amazon Region as the copy. Neptune
        /// does not support cross-Region copying of parameter groups.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDBParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBParameterGroupIdentifier() => this.SourceDBParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the copied DB parameter group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDBParameterGroupDescription. 
        /// <para>
        /// A description for the copied DB parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDBParameterGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBParameterGroupDescription property is set.
        /// </summary>
        internal bool IsSetTargetDBParameterGroupDescription() => this.TargetDBParameterGroupDescription != null;

        /// <summary>
        /// Gets and sets the property TargetDBParameterGroupIdentifier. 
        /// <para>
        /// The identifier for the copied DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Cannot be null, empty, or blank.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-db-parameter-group</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDBParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetDBParameterGroupIdentifier() => this.TargetDBParameterGroupIdentifier != null;
    }
}
