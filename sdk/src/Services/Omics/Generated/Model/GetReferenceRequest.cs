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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the GetReference operation.
    /// Gets a reference file.
    /// </summary>
    public partial class GetReferenceRequest : AmazonOmicsRequest
    {
        private ReferenceFile _file;
        private string _id;
        private int? _partNumber;
        private string _range;
        private string _referenceStoreId;

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// The file to retrieve.
        /// </para>
        /// </summary>
        public ReferenceFile File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The reference's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
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
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// The part number to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public int PartNumber
        {
            get { return this._partNumber.GetValueOrDefault(); }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The range to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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

        /// <summary>
        /// Gets and sets the property ReferenceStoreId. 
        /// <para>
        /// The reference's store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string ReferenceStoreId
        {
            get { return this._referenceStoreId; }
            set { this._referenceStoreId = value; }
        }

        // Check to see if ReferenceStoreId property is set
        internal bool IsSetReferenceStoreId()
        {
            return this._referenceStoreId != null;
        }

    }
}