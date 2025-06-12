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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBClusterParameterGroup operation.
    /// Copies the specified cluster parameter group.
    /// </summary>
    public partial class CopyDBClusterParameterGroupRequest : AmazonDocDBRequest
    {
        private string _sourceDBClusterParameterGroupIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetDBClusterParameterGroupDescription;
        private string _targetDBClusterParameterGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceDBClusterParameterGroupIdentifier. 
        /// <para>
        /// The identifier or Amazon Resource Name (ARN) for the source cluster parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid cluster parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source cluster parameter group is in the same Amazon Web Services Region as
        /// the copy, specify a valid parameter group identifier; for example, <c>my-db-cluster-param-group</c>,
        /// or a valid ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source parameter group is in a different Amazon Web Services Region than the
        /// copy, specify a valid cluster parameter group ARN; for example, <c>arn:aws:rds:us-east-1:123456789012:sample-cluster:sample-parameter-group</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <para>
        /// The tags that are to be assigned to the parameter group.
        /// </para>
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
        /// Gets and sets the property TargetDBClusterParameterGroupDescription. 
        /// <para>
        /// A description for the copied cluster parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier for the copied cluster parameter group.
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
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster-param-group1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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