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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CopyDBParameterGroup operation.
    /// Copies the specified DBParameterGroup.
    /// </summary>
    public partial class CopyDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _sourceDBParameterGroupIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBParameterGroupDescription;
        private string _targetDBParameterGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceDBParameterGroupIdentifier. 
        /// <para>
        ///  The identifier or ARN for the source DB Parameter Group. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must specify a valid DB Parameter Group.</li> <li>If the source DB Parameter
        /// Group is in the same region as the copy, specify a valid DB Parameter Group identifier,
        /// or a valid ARN.</li> <li>If the source DB Parameter Group is in a different region
        /// than the copy, specify a valid DB parameter group ARN.</li> </ul> 
        /// <para>
        /// Example: <code>my-db-param-group</code>
        /// </para>
        ///  
        /// <para>
        /// Example: <code>arn:aws:rds:us-west-2:123456789012:pg:special-parameters</code>
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetDBParameterGroupDescription. 
        /// <para>
        ///  The description for the copied DB Parameter Group. 
        /// </para>
        /// </summary>
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
        ///  The identifier for the copied DB Parameter Group. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Cannot be null, empty, or blank</li> <li>Must contain from 1 to 255 alphanumeric
        /// characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul> 
        /// <para>
        /// Example: <code>my-db-parameter-group</code>
        /// </para>
        /// </summary>
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