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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Information about associations that are successfully created: <c>DataSetId</c>, <c>TargetAccountId</c>,
    /// <c>ResourceShareId</c>, <c>ResourceShareArn</c>. 
    /// </para>
    /// </summary>
    public partial class AnalyticsDataAssociationResult
    {
        private string _dataSetId;
        private string _resourceShareArn;
        private string _resourceShareId;
        private string _resourceShareStatus;
        private string _targetAccountId;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The identifier of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Resource Access Manager share. 
        /// </para>
        /// </summary>
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareId. 
        /// <para>
        /// The Resource Access Manager share ID.
        /// </para>
        /// </summary>
        public string ResourceShareId
        {
            get { return this._resourceShareId; }
            set { this._resourceShareId = value; }
        }

        // Check to see if ResourceShareId property is set
        internal bool IsSetResourceShareId()
        {
            return this._resourceShareId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareStatus. 
        /// <para>
        /// The Amazon Web Services Resource Access Manager status of association.
        /// </para>
        /// </summary>
        public string ResourceShareStatus
        {
            get { return this._resourceShareStatus; }
            set { this._resourceShareStatus = value; }
        }

        // Check to see if ResourceShareStatus property is set
        internal bool IsSetResourceShareStatus()
        {
            return this._resourceShareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The identifier of the target account. 
        /// </para>
        /// </summary>
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

    }
}