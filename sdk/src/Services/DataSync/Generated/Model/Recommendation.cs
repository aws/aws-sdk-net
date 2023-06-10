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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The details about an Amazon Web Services storage service that DataSync Discovery recommends
    /// for a resource in your on-premises storage system.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
    /// provided by DataSync Discovery</a>.
    /// </para>
    /// </summary>
    public partial class Recommendation
    {
        private string _estimatedMonthlyStorageCost;
        private Dictionary<string, string> _storageConfiguration = new Dictionary<string, string>();
        private string _storageType;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyStorageCost. 
        /// <para>
        /// The estimated monthly cost of the recommended Amazon Web Services storage service.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string EstimatedMonthlyStorageCost
        {
            get { return this._estimatedMonthlyStorageCost; }
            set { this._estimatedMonthlyStorageCost = value; }
        }

        // Check to see if EstimatedMonthlyStorageCost property is set
        internal bool IsSetEstimatedMonthlyStorageCost()
        {
            return this._estimatedMonthlyStorageCost != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Information about how you can set up a recommended Amazon Web Services storage service.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null && this._storageConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// A recommended Amazon Web Services storage service that you can migrate data to based
        /// on information that DataSync Discovery collects about your on-premises storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}