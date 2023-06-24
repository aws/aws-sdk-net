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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about each OpenSearch Serverless collection, including the collection endpoint
    /// and the OpenSearch Dashboards endpoint.
    /// </summary>
    public partial class CollectionDetail
    {
        private string _arn;
        private string _collectionEndpoint;
        private long? _createdDate;
        private string _dashboardEndpoint;
        private string _description;
        private string _id;
        private string _kmsKeyArn;
        private long? _lastModifiedDate;
        private string _name;
        private CollectionStatus _status;
        private CollectionType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection.
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
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// Collection-specific endpoint used to submit index, search, and data upload requests
        /// to an OpenSearch Serverless collection.
        /// </para>
        /// </summary>
        public string CollectionEndpoint
        {
            get { return this._collectionEndpoint; }
            set { this._collectionEndpoint = value; }
        }

        // Check to see if CollectionEndpoint property is set
        internal bool IsSetCollectionEndpoint()
        {
            return this._collectionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The Epoch time when the collection was created.
        /// </para>
        /// </summary>
        public long CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardEndpoint. 
        /// <para>
        /// Collection-specific endpoint used to access OpenSearch Dashboards.
        /// </para>
        /// </summary>
        public string DashboardEndpoint
        {
            get { return this._dashboardEndpoint; }
            set { this._dashboardEndpoint = value; }
        }

        // Check to see if DashboardEndpoint property is set
        internal bool IsSetDashboardEndpoint()
        {
            return this._dashboardEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collection.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the collection was last modified.
        /// </para>
        /// </summary>
        public long LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
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
        /// The current status of the collection.
        /// </para>
        /// </summary>
        public CollectionStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of collection.
        /// </para>
        /// </summary>
        public CollectionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}