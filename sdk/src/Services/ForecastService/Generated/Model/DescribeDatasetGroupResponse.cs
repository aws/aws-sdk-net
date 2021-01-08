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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatasetGroup operation.
    /// </summary>
    public partial class DescribeDatasetGroupResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private List<string> _datasetArns = new List<string>();
        private string _datasetGroupArn;
        private string _datasetGroupName;
        private Domain _domain;
        private DateTime? _lastModificationTime;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset group was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArns. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the datasets contained in the dataset
        /// group.
        /// </para>
        /// </summary>
        public List<string> DatasetArns
        {
            get { return this._datasetArns; }
            set { this._datasetArns = value; }
        }

        // Check to see if DatasetArns property is set
        internal bool IsSetDatasetArns()
        {
            return this._datasetArns != null && this._datasetArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The ARN of the dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupName. 
        /// <para>
        /// The name of the dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DatasetGroupName
        {
            get { return this._datasetGroupName; }
            set { this._datasetGroupName = value; }
        }

        // Check to see if DatasetGroupName property is set
        internal bool IsSetDatasetGroupName()
        {
            return this._datasetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain associated with the dataset group.
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// When the dataset group was created or last updated from a call to the <a>UpdateDatasetGroup</a>
        /// operation. While the dataset group is being updated, <code>LastModificationTime</code>
        /// is the current time of the <code>DescribeDatasetGroup</code> call.
        /// </para>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset group. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_PENDING</code>, <code>UPDATE_IN_PROGRESS</code>, <code>UPDATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <code>UPDATE</code> states apply when you call the <a>UpdateDatasetGroup</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the dataset group must be <code>ACTIVE</code> before you
        /// can use the dataset group to create a predictor.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}