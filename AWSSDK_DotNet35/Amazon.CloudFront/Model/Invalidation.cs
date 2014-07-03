/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An invalidation.
    /// </summary>
    public partial class Invalidation
    {
        private DateTime? _createTime;
        private string _id;
        private InvalidationBatch _invalidationBatch;
        private string _status;


        /// <summary>
        /// Gets and sets the property CreateTime. The date and time the invalidation request
        /// was first made.
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Id. The identifier for the invalidation request. For example:
        /// IDFDVBD632BHDS5.
        /// </summary>
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
        /// Gets and sets the property InvalidationBatch. The current invalidation information
        /// for the batch request.
        /// </summary>
        public InvalidationBatch InvalidationBatch
        {
            get { return this._invalidationBatch; }
            set { this._invalidationBatch = value; }
        }

        // Check to see if InvalidationBatch property is set
        internal bool IsSetInvalidationBatch()
        {
            return this._invalidationBatch != null;
        }


        /// <summary>
        /// Gets and sets the property Status. The status of the invalidation request. When the
        /// invalidation batch is finished, the status is Completed.
        /// </summary>
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