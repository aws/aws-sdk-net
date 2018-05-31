/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBClusterParameterGroup operation.
    /// Copies the specified DB cluster parameter group.
    /// </summary>
    public partial class CopyDBClusterParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _sourceDBClusterParameterGroupIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBClusterParameterGroupDescription;
        private string _targetDBClusterParameterGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceDBClusterParameterGroupIdentifier. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) for the source DB cluster parameter group.
        /// For information about creating an ARN, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an RDS Amazon Resource Name (ARN)</a>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid DB cluster parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB cluster parameter group is in the same AWS Region as the copy, specify
        /// a valid DB parameter group identifier, for example <code>my-db-cluster-param-group</code>,
        /// or a valid ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB parameter group is in a different AWS Region than the copy, specify
        /// a valid DB cluster parameter group ARN, for example <code>arn:aws:rds:us-east-1:123456789012:cluster-pg:custom-cluster-group1</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBClusterParameterGroupIdentifier
        {
            get { return this._sourceDBClusterParameterGroupIdentifier; }
            set { this._sourceDBClusterParameterGroupIdentifier = value; }
        }

        // Check to see if SourceDBClusterParameterGroupIdentifier property is set
        internal bool IsSetSourceDBClusterParameterGroupIdentifier()
        {
            return this._sourceDBClusterParameterGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TargetDBClusterParameterGroupDescription. 
        /// <para>
        /// A description for the copied DB cluster parameter group.
        /// </para>
        /// </summary>
        public string TargetDBClusterParameterGroupDescription
        {
            get { return this._targetDBClusterParameterGroupDescription; }
            set { this._targetDBClusterParameterGroupDescription = value; }
        }

        // Check to see if TargetDBClusterParameterGroupDescription property is set
        internal bool IsSetTargetDBClusterParameterGroupDescription()
        {
            return this._targetDBClusterParameterGroupDescription != null;
        }

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
        /// Cannot be null, empty, or blank
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
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster-param-group1</code> 
        /// </para>
        /// </summary>
        public string TargetDBClusterParameterGroupIdentifier
        {
            get { return this._targetDBClusterParameterGroupIdentifier; }
            set { this._targetDBClusterParameterGroupIdentifier = value; }
        }

        // Check to see if TargetDBClusterParameterGroupIdentifier property is set
        internal bool IsSetTargetDBClusterParameterGroupIdentifier()
        {
            return this._targetDBClusterParameterGroupIdentifier != null;
        }

    }
}