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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBClusterParameterGroup operation. Copies
    /// the specified DB cluster parameter group. <note> <para> You can't copy a default DB
    /// cluster parameter group. Instead, create a new custom DB cluster parameter group,
    /// which copies the default parameters and values for the specified DB cluster parameter
    /// group family. </para> </note>
    /// </summary>
    public partial class CopyDBClusterParameterGroupRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property SourceDBClusterParameterGroupIdentifier. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) for the source DB cluster parameter group.
        /// For information about creating an ARN, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an ARN for Amazon RDS</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid DB cluster parameter group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDBClusterParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBClusterParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBClusterParameterGroupIdentifier() => this.SourceDBClusterParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags.
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
        /// Gets and sets the property TargetDBClusterParameterGroupDescription. 
        /// <para>
        /// A description for the copied DB cluster parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDBClusterParameterGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBClusterParameterGroupDescription property is set.
        /// </summary>
        internal bool IsSetTargetDBClusterParameterGroupDescription() => this.TargetDBClusterParameterGroupDescription != null;

        /// <summary>
        /// Gets and sets the property TargetDBClusterParameterGroupIdentifier. 
        /// <para>
        /// The identifier for the copied DB cluster parameter group.
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
        /// Example: <c>my-cluster-param-group1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDBClusterParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBClusterParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetDBClusterParameterGroupIdentifier() => this.TargetDBClusterParameterGroupIdentifier != null;
    }
}
