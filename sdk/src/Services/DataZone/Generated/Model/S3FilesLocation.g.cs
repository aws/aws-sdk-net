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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon Simple Storage Service objects to import as the cells of a notebook, specified
    /// as a bucket and an ordered list of object keys.
    /// </summary>
    public partial class S3FilesLocation
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon Simple Storage Service bucket that contains the files to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 3, Max = 63)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property FileList. 
        /// <para>
        /// The files to import. Cells are created in the order in which you list the files. You
        /// can specify between 1 and 100 files.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<S3File> FileList { get; set; } = AWSConfigs.InitializeCollections ? new List<S3File>() : null;

        /// <summary>
        /// Checks to see if the FileList property is set.
        /// </summary>
        internal bool IsSetFileList() => this.FileList != null && (this.FileList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
