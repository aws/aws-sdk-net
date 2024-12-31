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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This contains arrays of objects, which may include CreationTimes time condition objects,
    /// FilePaths string objects, LastModificationTimes time condition objects,
    /// </summary>
    public partial class EBSItemFilter
    {
        private List<TimeCondition> _creationTimes = AWSConfigs.InitializeCollections ? new List<TimeCondition>() : null;
        private List<StringCondition> _filePaths = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;
        private List<TimeCondition> _lastModificationTimes = AWSConfigs.InitializeCollections ? new List<TimeCondition>() : null;
        private List<LongCondition> _sizes = AWSConfigs.InitializeCollections ? new List<LongCondition>() : null;

        /// <summary>
        /// Gets and sets the property CreationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<TimeCondition> CreationTimes
        {
            get { return this._creationTimes; }
            set { this._creationTimes = value; }
        }

        // Check to see if CreationTimes property is set
        internal bool IsSetCreationTimes()
        {
            return this._creationTimes != null && (this._creationTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one file path is included, the results will return only items that match the file
        /// path.
        /// </para>
        ///  
        /// <para>
        /// If more than one file path is included, the results will return all items that match
        /// any of the file paths.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringCondition> FilePaths
        {
            get { return this._filePaths; }
            set { this._filePaths = value; }
        }

        // Check to see if FilePaths property is set
        internal bool IsSetFilePaths()
        {
            return this._filePaths != null && (this._filePaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<TimeCondition> LastModificationTimes
        {
            get { return this._lastModificationTimes; }
            set { this._lastModificationTimes = value; }
        }

        // Check to see if LastModificationTimes property is set
        internal bool IsSetLastModificationTimes()
        {
            return this._lastModificationTimes != null && (this._lastModificationTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sizes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<LongCondition> Sizes
        {
            get { return this._sizes; }
            set { this._sizes = value; }
        }

        // Check to see if Sizes property is set
        internal bool IsSetSizes()
        {
            return this._sizes != null && (this._sizes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}