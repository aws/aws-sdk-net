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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the GetObject operation.
    /// Downloads the object at the specified path. If the object’s upload availability is
    /// set to <c>streaming</c>, AWS Elemental MediaStore downloads the object even if it’s
    /// still uploading the object.
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
        /// For example, to upload the file <c>mlaw.avi</c> to the folder path <c>premium\canada</c>
        /// in the container <c>movies</c>, enter the path <c>premium/canada/mlaw.avi</c>.
        /// </para>
        ///  
        /// <para>
        /// Do not include the container name in this path.
        /// </para>
        ///  
        /// <para>
        /// If the path includes any folders that don't exist yet, the service creates them. For
        /// example, suppose you have an existing <c>premium/usa</c> subfolder. If you specify
        /// <c>premium/canada</c>, the service creates a <c>canada</c> subfolder in the <c>premium</c>
        /// folder. You then have two subfolders, <c>usa</c> and <c>canada</c>, in the <c>premium</c>
        /// folder. 
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
        [AWSProperty(Required=true, Min=1, Max=900)]
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
        /// The range bytes of an object to retrieve. For more information about the <c>Range</c>
        /// header, see <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.35">http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.35</a>.
        /// AWS Elemental MediaStore ignores this header for partially uploaded objects that have
        /// streaming upload availability.
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