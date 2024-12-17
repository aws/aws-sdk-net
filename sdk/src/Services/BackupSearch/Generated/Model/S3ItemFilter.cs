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
    /// This contains arrays of objects, which may include ObjectKeys, Sizes, CreationTimes,
    /// VersionIds, and/or Etags.
    /// </summary>
    public partial class S3ItemFilter
    {
        private List<TimeCondition> _creationTimes = AWSConfigs.InitializeCollections ? new List<TimeCondition>() : null;
        private List<StringCondition> _eTags = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;
        private List<StringCondition> _objectKeys = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;
        private List<LongCondition> _sizes = AWSConfigs.InitializeCollections ? new List<LongCondition>() : null;
        private List<StringCondition> _versionIds = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;

        /// <summary>
        /// Gets and sets the property CreationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
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
        /// Gets and sets the property ETags. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringCondition> ETags
        {
            get { return this._eTags; }
            set { this._eTags = value; }
        }

        // Check to see if ETags property is set
        internal bool IsSetETags()
        {
            return this._eTags != null && (this._eTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ObjectKeys. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringCondition> ObjectKeys
        {
            get { return this._objectKeys; }
            set { this._objectKeys = value; }
        }

        // Check to see if ObjectKeys property is set
        internal bool IsSetObjectKeys()
        {
            return this._objectKeys != null && (this._objectKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sizes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
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

        /// <summary>
        /// Gets and sets the property VersionIds. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringCondition> VersionIds
        {
            get { return this._versionIds; }
            set { this._versionIds = value; }
        }

        // Check to see if VersionIds property is set
        internal bool IsSetVersionIds()
        {
            return this._versionIds != null && (this._versionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}