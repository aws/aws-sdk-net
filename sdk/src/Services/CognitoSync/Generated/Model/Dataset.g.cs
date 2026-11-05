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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// A collection of data for an identity pool. An identity pool can have multiple datasets.
    /// A dataset is per identity and can be general or associated with a particular entity
    /// in an application (like a saved game). Datasets are automatically created if they
    /// don't exist. Data is synced by dataset, and a dataset can hold up to 1MB of key-value
    /// pairs.
    /// </summary>
    public partial class Dataset
    {
        /// <summary>
        /// Gets and sets the property CreationDate. Date on which the dataset was created.
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property DataStorage. Total size in bytes of the records in this
        /// dataset.
        /// </summary>
        public long? DataStorage { get; set; }

        /// <summary>
        /// Checks to see if the DataStorage property is set.
        /// </summary>
        internal bool IsSetDataStorage() => this.DataStorage.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetName. A string of up to 128 characters. Allowed
        /// characters are a-z, A-Z, 0-9, '_' (underscore), '-' (dash), and '.' (dot).
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property IdentityId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. The device that made the last change to
        /// this dataset.
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. Date when the dataset was last modified.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property NumRecords. Number of records in this dataset.
        /// </summary>
        public long? NumRecords { get; set; }

        /// <summary>
        /// Checks to see if the NumRecords property is set.
        /// </summary>
        internal bool IsSetNumRecords() => this.NumRecords.HasValue;
    }
}
