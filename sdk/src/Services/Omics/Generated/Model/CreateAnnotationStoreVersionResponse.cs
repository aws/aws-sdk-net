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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the CreateAnnotationStoreVersion operation.
    /// </summary>
    public partial class CreateAnnotationStoreVersionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _id;
        private string _name;
        private VersionStatus _status;
        private string _storeId;
        private string _versionName;
        private VersionOptions _versionOptions;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time stamp for the creation of an annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  A generated ID for the annotation store 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name given to an annotation store version to distinguish it from other versions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of a annotation store version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StoreId. 
        /// <para>
        ///  The ID for the annotation store from which new versions are being created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StoreId
        {
            get { return this._storeId; }
            set { this._storeId = value; }
        }

        // Check to see if StoreId property is set
        internal bool IsSetStoreId()
        {
            return this._storeId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        ///  The name given to an annotation store version to distinguish it from other versions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionOptions. 
        /// <para>
        ///  The options for an annotation store version. 
        /// </para>
        /// </summary>
        public VersionOptions VersionOptions
        {
            get { return this._versionOptions; }
            set { this._versionOptions = value; }
        }

        // Check to see if VersionOptions property is set
        internal bool IsSetVersionOptions()
        {
            return this._versionOptions != null;
        }

    }
}