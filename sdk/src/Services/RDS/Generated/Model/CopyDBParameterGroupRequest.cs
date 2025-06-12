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
    /// Container for the parameters to the CopyDBParameterGroup operation.
    /// Copies the specified DB parameter group.
    /// 
    ///  <note> 
    /// <para>
    /// You can't copy a default DB parameter group. Instead, create a new custom DB parameter
    /// group, which copies the default parameters and values for the specified DB parameter
    /// group family.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CopyDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _sourceDBParameterGroupIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetDBParameterGroupDescription;
        private string _targetDBParameterGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceDBParameterGroupIdentifier. 
        /// <para>
        /// The identifier or ARN for the source DB parameter group. For information about creating
        /// an ARN, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid DB parameter group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBParameterGroupIdentifier
        {
            get { return this._sourceDBParameterGroupIdentifier; }
            set { this._sourceDBParameterGroupIdentifier = value; }
        }

        // Check to see if SourceDBParameterGroupIdentifier property is set
        internal bool IsSetSourceDBParameterGroupIdentifier()
        {
            return this._sourceDBParameterGroupIdentifier != null;
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
        /// Gets and sets the property TargetDBParameterGroupDescription. 
        /// <para>
        /// A description for the copied DB parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDBParameterGroupDescription
        {
            get { return this._targetDBParameterGroupDescription; }
            set { this._targetDBParameterGroupDescription = value; }
        }

        // Check to see if TargetDBParameterGroupDescription property is set
        internal bool IsSetTargetDBParameterGroupDescription()
        {
            return this._targetDBParameterGroupDescription != null;
        }

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
        /// Example: <c>my-db-parameter-group</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDBParameterGroupIdentifier
        {
            get { return this._targetDBParameterGroupIdentifier; }
            set { this._targetDBParameterGroupIdentifier = value; }
        }

        // Check to see if TargetDBParameterGroupIdentifier property is set
        internal bool IsSetTargetDBParameterGroupIdentifier()
        {
            return this._targetDBParameterGroupIdentifier != null;
        }

    }
}