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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates an AWS Mobile Hub project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonMobileRequest
    {
        private MemoryStream _contents;
        private string _name;
        private string _region;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property Contents. 
        /// <para>
        ///  ZIP or YAML file which contains configuration settings to be used when creating the
        /// project. This may be the contents of the file downloaded from the URL provided in
        /// an export project operation. 
        /// </para>
        /// </summary>
        public MemoryStream Contents
        {
            get { return this._contents; }
            set { this._contents = value; }
        }

        // Check to see if Contents property is set
        internal bool IsSetContents()
        {
            return this._contents != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the project. 
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

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  Default region where project resources should be created. 
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        ///  Unique identifier for an exported snapshot of project configuration. This snapshot
        /// identifier is included in the share URL when a project is exported. 
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}