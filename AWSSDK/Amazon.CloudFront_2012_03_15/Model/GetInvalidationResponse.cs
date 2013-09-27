/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The GetInvalidationResponse contains the details of a particular invalidation
    /// and any headers returned by CloudFront.
    /// </summary>
    public class GetInvalidationResponse : CloudFrontResponse
    {
        private string status;
        private string id;
        private DateTime createTime;
        private InvalidationBatch invalidationBatch;

        /// <summary>
        /// Gets and Sets the Status property.  Valid Values are InProgress and Completed
        /// </summary>
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        /// <summary>
        /// Gets and Sets the Id property which is the invalidation id
        /// </summary>
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets and Sets the CreateTime property which is the date and time the invalidation request was first made.
        /// </summary>
        public DateTime CreateTime
        {
            get
            {
                return this.createTime;
            }
            set
            {
                this.createTime = value;
            }
        }

        /// <summary>
        /// Gets and Sets the InvalidationBatch property.
        /// </summary>
        public InvalidationBatch InvalidationBatch
        {
            get
            {
                return this.invalidationBatch;
            }
            set
            {
                this.invalidationBatch = value;
            }
        }
    }
}
