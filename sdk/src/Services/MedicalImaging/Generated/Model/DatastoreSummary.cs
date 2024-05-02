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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// List of summaries of data stores.
    /// </summary>
    public partial class DatastoreSummary
    {
        private DateTime? _createdAt;
        private string _datastoreArn;
        private string _datastoreId;
        private string _datastoreName;
        private DatastoreStatus _datastoreStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the data store was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatastoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the data store.
        /// </para>
        /// </summary>
        public string DatastoreArn
        {
            get { return this._datastoreArn; }
            set { this._datastoreArn = value; }
        }

        // Check to see if DatastoreArn property is set
        internal bool IsSetDatastoreArn()
        {
            return this._datastoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreName. 
        /// <para>
        /// The data store name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }

        // Check to see if DatastoreName property is set
        internal bool IsSetDatastoreName()
        {
            return this._datastoreName != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreStatus. 
        /// <para>
        /// The data store status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatastoreStatus DatastoreStatus
        {
            get { return this._datastoreStatus; }
            set { this._datastoreStatus = value; }
        }

        // Check to see if DatastoreStatus property is set
        internal bool IsSetDatastoreStatus()
        {
            return this._datastoreStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the data store was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}