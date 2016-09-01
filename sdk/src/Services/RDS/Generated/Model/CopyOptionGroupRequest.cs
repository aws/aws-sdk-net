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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the CopyOptionGroup operation.
    /// Copies the specified option group.
    /// </summary>
    public partial class CopyOptionGroupRequest : AmazonRDSRequest
    {
        private string _sourceOptionGroupIdentifier;
        private List<Tag> _tags = new List<Tag>();
        private string _targetOptionGroupDescription;
        private string _targetOptionGroupIdentifier;

        /// <summary>
        /// Gets and sets the property SourceOptionGroupIdentifier. 
        /// <para>
        /// The identifier or ARN for the source option group. For information about creating
        /// an ARN, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an RDS Amazon Resource Name (ARN)</a>. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify a valid option group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source option group is in the same region as the copy, specify a valid option
        /// group identifier, for example <code>my-option-group</code>, or a valid ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source option group is in a different region than the copy, specify a valid
        /// option group ARN, for example <code>arn:aws:rds:us-west-2:123456789012:og:special-options</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property TargetOptionGroupDescription. 
        /// <para>
        /// The description for the copied option group.
        /// </para>
        /// </summary>
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
        /// Cannot be null, empty, or blank
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 255 alphanumeric characters or hyphens
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
        /// Example: <code>my-option-group</code> 
        /// </para>
        /// </summary>
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