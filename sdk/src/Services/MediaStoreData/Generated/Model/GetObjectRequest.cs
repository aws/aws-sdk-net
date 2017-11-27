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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// Downloads the object at the specified path.
    /// </summary>
    public partial class GetObjectRequest : AmazonMediaStoreDataRequest
    {
        private string _path;
        private string _range;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path (including the file name) where the object is stored in the container. Format:
        /// &lt;folder name&gt;/&lt;folder name&gt;/&lt;file name&gt;
        /// </para>
        ///  
        /// <para>
        /// For example, to upload the file <code>mlaw.avi</code> to the folder path <code>premium\canada</code>
        /// in the container <code>movies</code>, enter the path <code>premium/canada/mlaw.avi</code>.
        /// </para>
        ///  
        /// <para>
        /// Do not include the container name in this path.
        /// </para>
        ///  
        /// <para>
        /// If the path includes any folders that don't exist yet, the service creates them. For
        /// example, suppose you have an existing <code>premium/usa</code> subfolder. If you specify
        /// <code>premium/canada</code>, the service creates a <code>canada</code> subfolder in
        /// the <code>premium</code> folder. You then have two subfolders, <code>usa</code> and
        /// <code>canada</code>, in the <code>premium</code> folder. 
        /// </para>
        ///  
        /// <para>
        /// There is no correlation between the path to the source and the path (folders) in the
        /// container in AWS Elemental MediaStore.
        /// </para>
        ///  
        /// <para>
        /// For more information about folders and how they exist in a container, see the <a href="http://docs.aws.amazon.com/mediastore/latest/ug/">AWS
        /// Elemental MediaStore User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// The file name is the name that is assigned to the file that you upload. The file can
        /// have the same name inside and outside of AWS Elemental MediaStore, or it can have
        /// the same name. The file name can include or omit an extension. 
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The range bytes of an object to retrieve. For more information about the <code>Range</code>
        /// header, go to <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.35">http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.35</a>.
        /// </para>
        /// </summary>
        public string Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

    }
}