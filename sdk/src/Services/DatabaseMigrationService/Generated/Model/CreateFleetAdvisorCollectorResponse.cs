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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the CreateFleetAdvisorCollector operation.
    /// </summary>
    public partial class CreateFleetAdvisorCollectorResponse : AmazonWebServiceResponse
    {
        private string _collectorName;
        private string _collectorReferencedId;
        private string _description;
        private string _s3BucketName;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property CollectorName. 
        /// <para>
        /// The name of the new Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string CollectorName
        {
            get { return this._collectorName; }
            set { this._collectorName = value; }
        }

        // Check to see if CollectorName property is set
        internal bool IsSetCollectorName()
        {
            return this._collectorName != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorReferencedId. 
        /// <para>
        /// The unique ID of the new Fleet Advisor collector, for example: <c>22fda70c-40d5-4acf-b233-a495bd8eb7f5</c>
        /// 
        /// </para>
        /// </summary>
        public string CollectorReferencedId
        {
            get { return this._collectorReferencedId; }
            set { this._collectorReferencedId = value; }
        }

        // Check to see if CollectorReferencedId property is set
        internal bool IsSetCollectorReferencedId()
        {
            return this._collectorReferencedId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A summary description of the Fleet Advisor collector.
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
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon S3 bucket that the collector uses to store inventory metadata.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to access the specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

    }
}