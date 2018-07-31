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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A <code>HierarchyGroup</code> object that contains information about a hierarchy group
    /// in your Amazon Connect instance.
    /// </summary>
    public partial class HierarchyGroup
    {
        private string _arn;
        private HierarchyPath _hierarchyPath;
        private string _id;
        private string _levelId;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the hierarchy group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyPath. 
        /// <para>
        /// A <code>HierarchyPath</code> object that contains information about the levels in
        /// the hierarchy group.
        /// </para>
        /// </summary>
        public HierarchyPath HierarchyPath
        {
            get { return this._hierarchyPath; }
            set { this._hierarchyPath = value; }
        }

        // Check to see if HierarchyPath property is set
        internal bool IsSetHierarchyPath()
        {
            return this._hierarchyPath != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the hierarchy group.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LevelId. 
        /// <para>
        /// The identifier for the level in the hierarchy group.
        /// </para>
        /// </summary>
        public string LevelId
        {
            get { return this._levelId; }
            set { this._levelId = value; }
        }

        // Check to see if LevelId property is set
        internal bool IsSetLevelId()
        {
            return this._levelId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hierarchy group in your instance.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}